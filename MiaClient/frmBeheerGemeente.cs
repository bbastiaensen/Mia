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
    public partial class frmBeheerGemeente : MdiChildBoundedForm
    {
        public event EventHandler LandenChanged;
        List<Gemeente> gemeentes;
        public event EventHandler GemeentesChanged;

        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;
        bool IsNew = false;
        private bool _isLoaded = false;
        public frmBeheerGemeente()
        {
            InitializeComponent();
            VulLandDropDown(ddlLand);

        }

        private void frmBeheerGemeente_Load(object sender, EventArgs e)
        {
            AppForms.frmBeheerGemeente = this;
            CreateUI();
            TriggerLandEvent();
            _isLoaded = true;
            BindLstGemeentes();

             

            if (AppForms.frmBeheerLeverancier != null)
            {
                this.GemeentesChanged -= AppForms.frmBeheerLeverancier.FrmBeheerGemeentes_GemeentesChanged;
                this.GemeentesChanged += AppForms.frmBeheerLeverancier.FrmBeheerGemeentes_GemeentesChanged;
            }

        }

        private void LstGemeente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gemeente gemeente = (Gemeente)LstGemeente.SelectedItem;


            if (gemeente != null)
            {
                txtId.Text = Convert.ToString(gemeente.Id);
                txtNaam.Text = gemeente.Naam;
                txtLandId.Text = Convert.ToString(gemeente.LandId);
                txtPostcode.Text = Convert.ToString(gemeente.Postcode);
                ddlLand.Text = gemeente.LandNaam;
                IsNew = false;
                btnVerwijderen.Enabled = true;
                btnVerwijderen.BackColor = StyleParameters.ButtonBack;
            }

        }

        private void frmBeheerGemeente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();

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
        public void BindLstGemeentes()
        {

            gemeentes = GemeenteManager.GetGemeentes();
            LstGemeente.DisplayMember = "Naam";

            LstGemeente.ValueMember = "Id";
            LstGemeente.DataSource = gemeentes;

        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
            LstGemeente.SelectedValue = 0;
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            try { 
            Gemeente g = new Gemeente();
            g.Id = Convert.ToInt32(LstGemeente.SelectedValue);
            g.Naam = txtNaam.Text;
            g.Postcode = Convert.ToInt32(txtPostcode.Text);
            g.LandNaam = ddlLand.Text;



            g.Id = GemeenteManager.SaveGemeente(g, IsNew);
            GemeentesChanged?.Invoke(this, EventArgs.Empty);


                BindLstGemeentes();
                VulLandDropDown(ddlLand);
                LstGemeente.SelectedValue = g.Id;
                IsNew = false;

                MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Er is een fout opgetreden bij het bewaren van de gegevens. Gelieve alle velden correct in te vullen.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Gemeente g = new Gemeente();
            g.Id = Convert.ToInt32(LstGemeente.SelectedValue);
            g.Naam = txtNaam.Text;
            g.LandId = Convert.ToInt32(txtLandId.Text);
            g.Postcode = Convert.ToInt32(txtPostcode.Text);

            if (MessageBox.Show($"Bent u zeker dat u {LstGemeente.Text} wilt verwijderen?", "MIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                GemeenteManager.DeleteGemeente(g);
                GemeentesChanged?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("De Gemeente is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            BindLstGemeentes();
            VulLandDropDown(ddlLand);
            ClearFields();
            LstGemeente.SelectedValue = 0;

        }
        private void ClearFields()
        {
            txtNaam.Text = string.Empty;
            txtId.Text = string.Empty;
            txtLandId.Text = string.Empty;
            txtPostcode.Text = string.Empty;
            ddlLand.SelectedValue = 0;
            IsNew = true;
            btnVerwijderen.Enabled = false;
            btnVerwijderen.BackColor = Color.Gray;
        }
        public void FrmBeheerLanden_LandenChanged(object sender, EventArgs e)
        {
            RefreshLandDropdown();
        }
        public void TriggerLandEvent()
        {   
            if (AppForms.frmBeheerLanden != null)
            {
                AppForms.frmBeheerLanden.LandenChanged += FrmBeheerLanden_LandenChanged;
            }
        }
        public void RefreshLandDropdown()
        {

            int? geselecteerdeId = ddlLand.SelectedValue as int?;

            var nieuwLand = LandenManager.GetLanden();

            ddlLand.DataSource = null;
            ddlLand.DisplayMember = "Naam";
            ddlLand.ValueMember = "Id";
            ddlLand.DataSource = nieuwLand;

            if (geselecteerdeId.HasValue &&
                nieuwLand.Any(a => a.Id == geselecteerdeId.Value))
            {
                ddlLand.SelectedValue = geselecteerdeId.Value;
            }
            else
            {
                ddlLand.SelectedIndex = -1;
            }
        }
        public void VulLandDropDown(ComboBox cmbLand)
        {
            List<Land> landen = MiaLogic.Manager.LandenManager.GetLanden();

            cmbLand.DataSource = landen;
            cmbLand.DisplayMember = "Naam";
            cmbLand.ValueMember = "Id";
            cmbLand.SelectedIndex = -1;
        }

        private void txtPostcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
