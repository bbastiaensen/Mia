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
    public partial class frmBeheerAankopers : Form
    {
        List<Aankoper> aankopers;
        public event EventHandler AankopersChanged;

        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;
        bool IsNew = false;
        
        public frmBeheerAankopers()
        {
            InitializeComponent();
        }

        private void frmBeheerAankopers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();

            if (AppForms.frmBeheerAankopers == this)
            {
                AppForms.frmBeheerAankopers = null;
            }
        }

        private void frmBeheerAankopers_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstAankopers();

            AppForms.frmBeheerAankopers = this;

            if (AppForms.frmAanvraagFormulier != null)
            {
                this.AankopersChanged -= AppForms.frmAanvraagFormulier.FrmBeheerAankopers_AankopersChanged;
                this.AankopersChanged += AppForms.frmAanvraagFormulier.FrmBeheerAankopers_AankopersChanged;
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
        public void BindLstAankopers()
        {

            aankopers = AankoperManager.GetAankoper();
            LstAankopers.DisplayMember = "FullName";
            
            LstAankopers.ValueMember = "Id";    
            LstAankopers.DataSource= aankopers;
            
        }

        private void LstAankopers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aankoper aankoper  = (Aankoper)LstAankopers.SelectedItem;

           
            if (aankoper != null) 
            {
                txtId.Text = Convert.ToString(aankoper.Id);
                txtVoornaam.Text = aankoper.Voornaam;
                txtAchternaam.Text = aankoper.Achternaam;
                if (aankoper.actief)
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
            txtAchternaam.Text = string.Empty;
            txtId.Text = string.Empty;
            txtVoornaam.Text = string.Empty;
            checkActief.Checked = false;
            IsNew = true;
        }
        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            Aankoper a = new Aankoper();
            a.Id = Convert.ToInt32(LstAankopers.SelectedValue);
            a.Voornaam = txtVoornaam.Text;
            a.Achternaam = txtAchternaam.Text;
            if (checkActief.Checked)
            {
                a.actief = true;
            }
            else
            {
                a.actief= false;
            }
          

            a.Id = AankoperManager.SaveAankoper(a, IsNew);
            AankopersChanged?.Invoke(this, EventArgs.Empty);

            BindLstAankopers();
            ClearFields();
            LstAankopers.SelectedValue = a.Id.ToString();
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Aankoper a = new Aankoper();
            a.Id = Convert.ToInt32(LstAankopers.SelectedValue);
            a.Voornaam= txtVoornaam.Text;
            a.Achternaam= txtAchternaam.Text;
            if (checkActief.Checked) 
            {
                a.actief = true;
            }
            else
            {
                a.actief= false;
            }
            
            if (MessageBox.Show($"Bent u dat u {LstAankopers.Text} wilt verwijderen?", "Aankoper verwijderen", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                MessageBox.Show("De Aankoper is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AankoperManager.DeleteAankoper(a);
                AankopersChanged?.Invoke(this, EventArgs.Empty);
            }

            BindLstAankopers();
            ClearFields();  
        }
    }
}
