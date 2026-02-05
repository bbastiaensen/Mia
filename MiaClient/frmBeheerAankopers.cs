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
            Aankoper aankoper = (Aankoper)LstAankopers.SelectedItem;

            if (aankoper != null)
            {
                txtId.Text = Convert.ToString(aankoper.Id);
                txtVoornaam.Text = aankoper.Voornaam;
                txtAchternaam.Text = aankoper.Achternaam;
                checkActief.Checked = aankoper.actief;

                IsNew = false;

                // Verwijderen-knop inschakelen
                btnVerwijderen.Enabled = true;
                btnVerwijderen.BackColor = StyleParameters.ButtonBack; // terug naar normale kleur
            }

        }
        private void ClearFields()
        {
            txtAchternaam.Text = string.Empty;
            txtId.Text = string.Empty;
            txtVoornaam.Text = string.Empty;
            checkActief.Checked = false;
            IsNew = true;

            // Verwijderen-knop uitschakelen
            btnVerwijderen.Enabled = false;
            btnVerwijderen.BackColor = Color.Gray; // visueel uitgeschakeld
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
            if (IsNew)
            {
                MessageBox.Show(
                    "Er is geen leverancier geselecteerd om te verwijderen.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (LstAankopers.SelectedItem == null)
            {
                MessageBox.Show(
                    "Gelieve eerst een aankoper te selecteren.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Aankoper a = (Aankoper)LstAankopers.SelectedItem;

            if (MessageBox.Show(
                $"Bent u zeker dat u {a.FullName} wilt verwijderen?",
                "Aankoper verwijderen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AankoperManager.DeleteAankoper(a);

                MessageBox.Show(
                    "De aankoper is succesvol verwijderd.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                AankopersChanged?.Invoke(this, EventArgs.Empty);

                BindLstAankopers();
                ClearFields();
            }
        }

        private void txtVoornaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAchternaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkActief_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblActief_Click(object sender, EventArgs e)
        {

        }

        private void lblAchternaam_Click(object sender, EventArgs e)
        {

        }

        private void lblVoornaam_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
