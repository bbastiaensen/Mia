using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBeheerPrioriteit : Form
    {
        List<Prioriteit> prioriteiten = new List<Prioriteit>();
        public event EventHandler PrioriteitenChanged;
        public static int? LastActivePrioriteitId { get; set; }

        bool IsNew = false;

     

        public frmBeheerPrioriteit()
        {
            InitializeComponent();
        }

        private void frmPrioriteit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }
        private void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            

            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = StyleParameters.ButtonBack;
                btn.ForeColor = StyleParameters.Buttontext;
            }
        }

        private void frmPrioriteit_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindlstPrioriteiten();

            AppForms.frmBeheerPrioriteit = this;

            if (AppForms.frmAanvraagFormulier != null)
            {
                this.PrioriteitenChanged -= AppForms.frmAanvraagFormulier.FrmBeheerPrioriteiten_PrioriteitenChanged;
                this.PrioriteitenChanged += AppForms.frmAanvraagFormulier.FrmBeheerPrioriteiten_PrioriteitenChanged;
            }
        }
        public void BindlstPrioriteiten()
        {
            prioriteiten = PrioriteitManager.GetPrioriteiten();
            lstPrioriteiten.DisplayMember = "Naam";
            lstPrioriteiten.ValueMember = "Id";
            lstPrioriteiten.DataSource = prioriteiten;
        }

        private void lstPrioriteiten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prioriteit prioriteit = (Prioriteit)lstPrioriteiten.SelectedItem;

            if (prioriteit != null) 
            {
                txtId.Text = Convert.ToString(prioriteit.Id);
                txtNaam.Text = Convert.ToString(prioriteit.Naam);
                if (prioriteit.Actief)
                {
                    chkActief.Checked = true;
                }
                else
                {
                    chkActief.Checked = false;
                }
                 IsNew = false;

            }
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
            IsNew = true;
            lstPrioriteiten.SelectedValue = 0;
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaam.Text))
            {
                MessageBox.Show("Gelieve een geldige naam in te vullen.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtNaam.Text = txtNaam.Text.Trim();
            Prioriteit p = new Prioriteit();
            p.Id = Convert.ToInt32(lstPrioriteiten.SelectedValue);
            p.Naam = txtNaam.Text;
            if (chkActief.Checked)
            {
                p.Actief = true;
            }
            else
            {
                p.Actief = false;
            }
            p.Id = PrioriteitManager.SavePrioriteit(p, IsNew);
            if (p.Actief)
            {
                LastActivePrioriteitId = p.Id;
            }
            PrioriteitenChanged?.Invoke(this, EventArgs.Empty);

            BindlstPrioriteiten();

            lstPrioriteiten.SelectedValue = p.Id;
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (IsNew)
            {
                MessageBox.Show(
                    "Er is geen prioriteit geselecteerd om te verwijderen.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (lstPrioriteiten.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecteer eerst een prioriteit om te verwijderen.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Prioriteit p = (Prioriteit)lstPrioriteiten.SelectedItem;

            if (MessageBox.Show(
                    $"Bent u zeker dat u {p.Naam} wilt verwijderen?",
                    "MIA",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (PrioriteitManager.PrioriteitGebruikt(p.Id))
                {
                    PrioriteitManager.DeactiveerPrioriteit(p.Id);
                    MessageBox.Show(
                        "Deze prioriteit is gekoppeld aan een aanvraag en werd op niet-actief gezet.",
                        "MIA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    PrioriteitManager.DeletePrioriteit(p);
                    MessageBox.Show(
                        "De prioriteit is succesvol verwijderd.",
                        "MIA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                PrioriteitenChanged?.Invoke(this, EventArgs.Empty);
                BindlstPrioriteiten();
                ClearFields();
                IsNew = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Het systeem kon de prioriteit niet verwijderen. " + ex.Message,
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        public void ClearFields()
        {
            txtId.Text = string.Empty;
            txtNaam.Text = string.Empty;
            chkActief.Checked = false;
        }
        
    }
}
