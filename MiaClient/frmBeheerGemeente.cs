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
    public partial class frmBeheerGemeente : Form
    {

        List<Gemeente> gemeentes;
      

        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;
        bool IsNew = false;
        public frmBeheerGemeente()
        {
            InitializeComponent();

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
            lstGemeente.DisplayMember = "Naam";
            
            lstGemeente.ValueMember = "Id";
            lstGemeente.DataSource = gemeentes;

        }
        
        private void frmBeheerGemeente_Load(object sender, EventArgs e)
        {
            CreateUI();
          
            BindLstGemeentes();
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            Gemeente g = new Gemeente();
            g.Id = Convert.ToInt32(lstGemeente.SelectedValue);
            g.Naam = txtNaam.Text;
            g.Postcode = Convert.ToInt32(txtPostcode.Text);
            g.LandNaam = ddlLand.Text;
          


            g.Id = GemeenteManager.SaveGemeente(g, IsNew);
            

            BindLstGemeentes();
           
            ClearFields();
            lstGemeente.SelectedValue = g.Id.ToString();
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Gemeente g = new Gemeente();
            g.Id = Convert.ToInt32(lstGemeente.SelectedValue);
            g.Naam = txtNaam.Text;
            g.LandId = Convert.ToInt32(txtLandId.Text);
            g.Postcode = Convert.ToInt32(txtPostcode.Text);

            if (MessageBox.Show($"Bent u zeker dat u {lstGemeente.Text} wilt verwijderen?", "Gemeente verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                GemeenteManager.DeleteGemeente(g);
                MessageBox.Show("De Gemeente is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            BindLstGemeentes();

            ClearFields();
        }

        private void lstGemeente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gemeente gemeente = (Gemeente)lstGemeente.SelectedItem;


            if (gemeente != null)
            {
                txtId.Text = Convert.ToString(gemeente.Id);
                txtNaam.Text = gemeente.Naam;
                txtLandId.Text = Convert.ToString(gemeente.LandId);
                txtPostcode.Text = Convert.ToString(gemeente.Postcode);
                ddlLand.Items.Add(gemeente.LandNaam);
                IsNew = false;
            }
        }
        private void ClearFields()
        {
            txtNaam.Text = string.Empty;
            txtId.Text = string.Empty;
            txtLandId.Text = string.Empty;
            txtPostcode.Text = string.Empty;
            ddlLand.Text = string.Empty;
            IsNew = true;
        }


    } 
}
