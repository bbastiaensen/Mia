using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBeheerKostenplaatsen : Form
    {
        Boolean isNew = false;
        public event EventHandler KostenplaatsChanged;
        public static int? LastActiveKostenplaatsId { get; set; }

        public frmBeheerKostenplaatsen()
        {
            InitializeComponent();
        }

        private void frmBeheerKostenplaatsen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void frmBeheerKostenplaatsen_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLsbKostenplaatsen();

            AppForms.frmBeheerKostenplaatsen = this;

            if (AppForms.frmAanvraagFormulier != null)
            {
                this.KostenplaatsChanged -= AppForms.frmAanvraagFormulier.FrmBeheerKostenplaatsen_KostenplaatsChanged;
                this.KostenplaatsChanged += AppForms.frmAanvraagFormulier.FrmBeheerKostenplaatsen_KostenplaatsChanged;
            }
        }

        public void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            //this.Icon = imgFormIcon;

            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = StyleParameters.ButtonBack;
                btn.ForeColor = StyleParameters.Buttontext;
            }

            try
            {
                BindLsbKostenplaatsen();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een probleem opgetreden bij het inladen van de kostenplaatsen. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindLsbKostenplaatsen()
        {
            lsbKostenplaatsen.DisplayMember = "Naam";
            lsbKostenplaatsen.ValueMember = "Id";
            lsbKostenplaatsen.DataSource = KostenplaatsManager.GetAllKostenplaatsen();
        }

        private void lsbKostenplaatsen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Kostenplaats k = KostenplaatsManager.GetKostenplaatsById(Convert.ToInt32(lsbKostenplaatsen.SelectedValue));

                if (k != null)
                {
                    SetFields(k);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een probleem opgetreden bij het inladen van een kostenplaats. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SetFields(Kostenplaats k)
        {
            txtId.Text = k.Id.ToString();
            txtNaam.Text = k.Naam;
            txtCode.Text = k.Code.ToString();
            chkActief.Checked = k.Actief;
            btnVerwijderen.Enabled = true;
            isNew = false;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            //Formulier klaarmaken voor nieuwe invoer
            txtId.Text = string.Empty; 
            txtNaam.Text = string.Empty; 
            txtCode.Text = string.Empty;
            chkActief.Checked = false;
            btnVerwijderen.Enabled = false;
            isNew = true;
            lsbKostenplaatsen.SelectedValue = 0;
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            try
            {
                Kostenplaats k = null;

                //Controleer de invoer
                if (string.IsNullOrEmpty(txtNaam.Text))
                {
                    MessageBox.Show("Het veld 'Naam' moet ingevuld zijn.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNaam.Focus();
                    return;
                }

                if (!Program.IsNumeric(txtCode.Text))
                {
                    MessageBox.Show("Het veld 'Code' moet een geheel getal zijn.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCode.Focus();
                    txtCode.SelectAll();
                    return;
                }

                k = KostenplaatsManager.SaveKostenplaats(isNew, CreateObjectFromFields());

                if (k.Actief)
                {
                    LastActiveKostenplaatsId = k.Id;
                }

                // Event naar frmAanvraagFormulier sturen
                KostenplaatsChanged?.Invoke(this, EventArgs.Empty);

                SetFields(k);

                BindLsbKostenplaatsen();

                lsbKostenplaatsen.SelectedValue = k.Id;

                isNew = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een probleem opgetreden bij het bewaren van een kostenplaats. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("De gegevens zijn bewaard", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Kostenplaats k = null;

            try
            {
                if (MessageBox.Show("Ben je zeker dat je deze kostenplaats wilt verwijderen?", "MIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                //invoer controleren
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("Er is geen huidig record dat we kunnen verwijderen.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNaam.Focus();
                    return;
                }

                k = CreateObjectFromFields();

                KostenplaatsManager.DeleteKostenplaats(k);

                BindLsbKostenplaatsen();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    //De kostenplaats is al gebruikt in de databank en kan dus niet zomaar verwijderd worden.
                    string msg = "De kostenplaats '" + txtNaam.Text + "' is al in gebruik en kan niet zomaar verwijderd worden. Wil je deze in plaats daarvan de-activeren? Dit heeft tot gevolg dat ze niet meer kan gebruikt worden door de gebruikers.";

                    if (MessageBox.Show(msg, "MIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        k.Actief = false;

                        k = KostenplaatsManager.SaveKostenplaats(isNew, k);

                        SetFields(k);

                        BindLsbKostenplaatsen();

                        lsbKostenplaatsen.SelectedValue = k.Id;

                        isNew = false;

                        MessageBox.Show("De gegevens zijn gedeactiveerd.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Er is een probleem opgetreden bij het verwijderen van een kostenplaats. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een probleem opgetreden bij het verwijderen van een kostenplaats. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("De gegevens zijn verwijderd.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            KostenplaatsChanged?.Invoke(this, EventArgs.Empty);
            lsbKostenplaatsen.SelectedValue = 0;
        }

        private Kostenplaats CreateObjectFromFields()
        {
            Kostenplaats k = new Kostenplaats();

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                k.Id = Convert.ToInt32(txtId.Text);
            }
            else
            {
                k.Id = 0;
            }
            k.Naam = txtNaam.Text;
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                k.Code = Convert.ToInt32(txtCode.Text);
            }
            else
            {
                k.Code = 0;
            }

            k.Actief = chkActief.Checked;

            return k;
        }


    }
}
