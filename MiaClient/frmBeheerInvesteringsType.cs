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
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBeheerInvesteringsType : Form
    {
        private Investering huidige;
        private bool isNew;
        public event EventHandler InvesteringsTypeschanged;

        public frmBeheerInvesteringsType()
        {
            InitializeComponent();
        }
     

        private void frmBeheerInvesteringsType_Load(object sender, EventArgs e)
        {
            CreateUI();
            LoadList();
           
        }

        //    btnNieuw.Click += btnNieuw_Click;
        //    btnBewaren.Click += btnBewaren_Click;
        //    btnVerwijderen.Click += btnVerwijderen_Click;
        //    InvesteringsTypes.SelectedIndexChanged += InvesteringsTypes_SelectedIndexChanged;

        //    AppForms.frmBeheerInvesteringsType = this;

        //    if (AppForms.frmAanvraagFormulier != null)
        //    {
        //        this.InvesteringsTypeschanged -= AppForms.frmAanvraagFormulier.FrmBeheerInvesteringsType_InvesteringsTypeChanged;
        //        this.InvesteringsTypeschanged += AppForms.frmAanvraagFormulier.FrmBeheerInvesteringsType_InvesteringsTypeChanged;
        //    }
        //}


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

        private void LoadList()
        {
            InvesteringsTypes.DataSource = null;
            InvesteringsTypes.DataSource = InvesteringenManager.GetInvesteringen();
        }

        private void InvesteringsTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            huidige = InvesteringsTypes.SelectedItem as Investering;
            if (huidige == null) return;

            txtId.Text = huidige.Id.ToString();
            txtVoornaam.Text = huidige.Naam;
            checkActief.Checked = huidige.Actief;
            isNew = false;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            huidige = new Investering();
            isNew = true;

            txtId.Clear();
            txtVoornaam.Clear();
            checkActief.Checked = true;
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVoornaam.Text))
            {
                MessageBox.Show("Naam is verplicht");
                return;
            }

            Investering i = new Investering();

            if (!isNew && InvesteringsTypes.SelectedItem is Investering selected)
            {
                i.Id = selected.Id;
            }

            i.Naam = txtVoornaam.Text;
            i.Actief = checkActief.Checked;

            i.Id = InvesteringenManager.SaveInvestering(i, isNew);

            LoadList();

            InvesteringsTypeschanged?.Invoke(this, EventArgs.Empty);

            InvesteringsTypes.SelectedItem = i; 
            isNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (huidige == null) return;

            if (MessageBox.Show(
                "Ben je zeker dat je dit InvesteringsType wil verwijderen?",
                "Bevestiging",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                InvesteringenManager.DeleteInvestering(huidige);
                LoadList();
                btnNieuw_Click(null, null);
            }
            InvesteringsTypeschanged?.Invoke(this, EventArgs.Empty);
        }

        private void frmBeheerInvesteringsType_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            if (AppForms.frmBeheerInvesteringsType == this)
            {
                AppForms.frmBeheerInvesteringsType = null;
            }
        }

       
        

   
       
      

      



  
    }
}

