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
    public partial class frmBeheerInvesteringsType : Form
    {

        List<Financiering>  financierings;

        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;
        bool IsNew = false;
        public frmBeheerInvesteringsType()
        {
            InitializeComponent();
        }

        private void frmBeheerInvesteringsType_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstFinancieringsTypen();
        }

        private void frmBeheerInvesteringsType_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void CreateUI()
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



        public void BindLstFinancieringsTypen()
        {

            financierings = FinancieringenManager.GetFinancieringen();
            LstFinancieringsTypen.DisplayMember = "FullName";

            LstFinancieringsTypen.ValueMember = "Id";
            LstFinancieringsTypen.DataSource = financierings;

        }

   
       
        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void LstFinancieringsTypen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Financiering financier = (Financiering)LstFinancieringsTypen.SelectedItem;


            if (financier != null)
            {
                txtId.Text = Convert.ToString(financier.Id);
                txtNaam.Text = financier.Naam;
              
                if (financier.actief)
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
            
            txtId.Text = string.Empty;
            txtNaam.Text = string.Empty;
            checkActief.Checked = false;
            IsNew = true;
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            Financiering a = new Financiering();
            a.Id = Convert.ToInt32(LstFinancieringsTypen.SelectedValue);
            a.Naam = txtNaam.Text;
          
            if (checkActief.Checked)
            {
                a.actief = true;
            }
            else
            {
                a.actief = false;
            }


            a.Id = FinancieringenManager.SaveFinancieringType(a, IsNew);

            BindLstFinancieringsTypen();
            ClearFields();
            LstFinancieringsTypen.SelectedValue = a.Id.ToString();
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Financiering a = new Financiering();
            a.Id = Convert.ToInt32(LstFinancieringsTypen.SelectedValue);
            a.Naam = txtNaam.Text;
           
            if (checkActief.Checked)
            {
                a.actief = true;
            }
            else
            {
                a.actief = false;
            }

            if (MessageBox.Show($"Bent u zeker dat u {LstFinancieringsTypen.Text} wilt verwijderen?", "FinancieringsTypen verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("De FinancieringsTypen is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FinancieringenManager.DeleteAankoper(a);
                //AankopersChanged?.Invoke(this, EventArgs.Empty); ik thomas ga hier nog is naar kijken.
            }

            BindLstFinancieringsTypen();
            ClearFields();
        }
    }
}
