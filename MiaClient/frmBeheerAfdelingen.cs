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
using System.Web;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBeheerAfdelingen : Form
    {
        List<Afdeling> afdelingen;
        bool IsNew = false;
        public event EventHandler AfdelingChanged;


        public frmBeheerAfdelingen()
        {
            InitializeComponent();
        }

        private void frmBeheerAfdelingen_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstAfdelingen();
            AppForms.frmbeheerAfdelingen = this;

            if (AppForms.frmAanvraagFormulier != null)
            {
                this.AfdelingChanged -= AppForms.frmAanvraagFormulier.FrmBeheerAfdeling_AfdelingChanged;
                this.AfdelingChanged += AppForms.frmAanvraagFormulier.FrmBeheerAfdeling_AfdelingChanged;
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

        private void frmBeheerAfdelingen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden..
            e.Cancel = true;
            ((Form)sender).Hide();

            if (AppForms.frmbeheerAfdelingen == this)
            {
                AppForms.frmbeheerAfdelingen = null;
            }
        }

        public void BindLstAfdelingen()
        {
            afdelingen = AfdelingenManager.GetAfdelingen();
            LstAfdelingen.DisplayMember = "Naam";

            LstAfdelingen.ValueMember = "Id";
            LstAfdelingen.DataSource = afdelingen;


        }

        private void LstAfdelingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Afdeling afdeling = (Afdeling)LstAfdelingen.SelectedItem;


            if (afdeling != null)
            {
                txtId.Text = Convert.ToString(afdeling.Id);
                txtNaam.Text = afdeling.Naam;
                if (afdeling.actief)
                {
                    checkActief.Checked = true;
                }
                else
                {
                    checkActief.Checked = false;
                }

                IsNew = false;
            }
        }

        private void ClearFields()
        {
            txtNaam.Text = string.Empty;
            txtId.Text = string.Empty;
            checkActief.Checked = false;
            IsNew = true;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaam?.Text))
            {
                MessageBox.Show("Gelieve een geldige naam in te vullen.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string naam = txtNaam.Text.Trim();

            Afdeling a = new Afdeling();
            a.Id = Convert.ToInt32(LstAfdelingen.SelectedValue);
            a.Naam = naam;
            if (checkActief.Checked)
            {
                a.actief = true;
            }
            else
            {
                a.actief = false;
            }


            a.Id = AfdelingenManager.SaveAfdeling(a, IsNew);
            AfdelingChanged?.Invoke(this, EventArgs.Empty);

            BindLstAfdelingen();
            ClearFields();
            LstAfdelingen.SelectedValue = a.Id;
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Afdeling a = new Afdeling
            {
                Id = Convert.ToInt32(LstAfdelingen.SelectedValue),
                Naam = txtNaam.Text,
                actief = checkActief.Checked
            };

            if (MessageBox.Show($"Bent u zeker dat u {LstAfdelingen.Text} wilt verwijderen?", "MIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                // Probeer verwijderen
                AfdelingenManager.DeleteAfdeling(a);
                MessageBox.Show("De Afdeling is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Als foreign key voorkomt dat verwijderen, zet op inactief
                MessageBox.Show("Deze afdeling kan niet verwijderd worden omdat er nog gekoppelde records zijn. De afdeling wordt op inactief gezet.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                a.actief = false;
                AfdelingenManager.SaveAfdeling(a, false);
            }

            AfdelingChanged?.Invoke(this, EventArgs.Empty);
            BindLstAfdelingen();
            ClearFields();
        }

    }
}
