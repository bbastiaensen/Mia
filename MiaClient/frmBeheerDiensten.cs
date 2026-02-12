using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBeheerDiensten : Form
    {
        List<Dienst> diensten;
        bool IsNew = false;

        public event EventHandler DienstenChanged;
        public static int? LastActiveDienstId { get; set; }


        public frmBeheerDiensten()
        {
            InitializeComponent();
        }

        private void frmBeheerDiensten_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindlstDiensten();
            AppForms.frmBeheerDiensten = this;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;


            if (AppForms.frmAanvraagFormulier != null)
            {
                this.DienstenChanged -= AppForms.frmAanvraagFormulier.FrmBeheerDiensten_DienstenChanged;
                this.DienstenChanged += AppForms.frmAanvraagFormulier.FrmBeheerDiensten_DienstenChanged;
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
        }

        private void frmBeheerDiensten_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();


            if (AppForms.frmBeheerDiensten == this)
            {
                AppForms.frmBeheerDiensten = null;
            }

        }

        public void BindlstDiensten()
        {

            diensten = DienstenManager.GetDiensten();
            lstDiensten.DisplayMember = "Naam";

            lstDiensten.ValueMember = "Id";
            lstDiensten.DataSource = diensten;
        }


        private void btnBewaren_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaam.Text))
            {
                MessageBox.Show("Gelieve een geldige naam in te vullen.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtNaam.Text = txtNaam.Text.Trim();
                Dienst d = new Dienst();
                d.Id = Convert.ToInt32(lstDiensten.SelectedValue);
                d.Naam = txtNaam.Text;

                if (checkActief.Checked)
                {
                    d.actief = true;
                }
                else
                {
                    d.actief = false;
                }


                d.Id = DienstenManager.SaveDiensten(d, IsNew);
                if (d.actief)
                {
                    LastActiveDienstId = d.Id;
                }
                DienstenChanged?.Invoke(this, EventArgs.Empty);

                BindlstDiensten();

                lstDiensten.SelectedValue = d.Id;
                IsNew = false;

                MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           

        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (lstDiensten.SelectedItem == null)
            {
                MessageBox.Show(
                    "Er is geen Dienst geselecteerd om te verwijderen.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            Dienst d = new Dienst();
            d.Id = Convert.ToInt32(lstDiensten.SelectedValue);
            d.Naam = txtNaam.Text;

            if (checkActief.Checked)
            {
                d.actief = true;
            }
            else
            {
                d.actief = false;
            }

            if (MessageBox.Show($"Bent u zeker dat u {lstDiensten.Text} wilt verwijderen?", "MIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DienstenManager.CheckPrioriteitInUse(d.Id))
                {
                    DienstenManager.DeactivateDienst(d);
                    DienstenChanged?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("De Dienst kan niet verwijderd worden omdat deze in gebruik is.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BindlstDiensten();
                    return;
                }
                else
                {
                    DienstenManager.DeleteDienst(d);

                    MessageBox.Show("De Dienst is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DienstenChanged?.Invoke(this, EventArgs.Empty);
                }

            }

            BindlstDiensten();
            ClearFields();
            lstDiensten.SelectedValue = 0;

        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
            lstDiensten.SelectedValue = 0;
        }

        private void lstDiensten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dienst dienst = (Dienst)lstDiensten.SelectedItem;


            if (dienst != null)
            {
                txtId.Text = Convert.ToString(dienst.Id);
                txtNaam.Text = dienst.Naam;

                if (dienst.actief)
                {
                    checkActief.Checked = true;
                }
                else
                {
                    checkActief.Checked = false;
                }

                IsNew = false;

                // Verwijderen-knop inschakelen en terug naar normale kleur
                btnVerwijderen.Enabled = true;
                btnVerwijderen.BackColor = StyleParameters.ButtonBack;
            }

        }
        private void ClearFields()
        {
            txtNaam.Text = string.Empty;
            txtId.Text = string.Empty;
            checkActief.Checked = false;
            IsNew = true;

            // Verwijderen-knop uitschakelen en grijs maken
            btnVerwijderen.Enabled = false;
            btnVerwijderen.BackColor = Color.Gray;
        }
    }
}
