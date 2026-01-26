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
        List<Dienst> Diensten;
      

      
        bool IsNew = false;
        public frmBeheerDiensten()
        {
            InitializeComponent();
        }

        private void frmBeheerDiensten_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstDiensten();
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
        }
        public void BindLstDiensten()
        {

            Diensten = DienstenManager.GetDiensten();
            lstDiensten.DisplayMember = "Naam";

            lstDiensten.ValueMember = "Id";
            lstDiensten.DataSource = Diensten;

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


            d.Id = DienstenManager.SaveDienst(d, IsNew);


            BindLstDiensten();
            ClearFields();
           lstDiensten.SelectedValue = d.Id.ToString();
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
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

            if (MessageBox.Show($"Bent u zeker dat u {lstDiensten.Text} wilt verwijderen?", "Aankoper verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("De Dienst   is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DienstenManager.DeleteDienst(d);
             
            }

            BindLstDiensten();
            ClearFields();
        }
    }
}
