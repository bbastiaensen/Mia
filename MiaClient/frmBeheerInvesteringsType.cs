using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBeheerInvesteringsType : Form
    {
        List<Investering> investeringen;
        public event EventHandler InvesteringsTypesChanged;

        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;
        bool IsNew = false;

        public frmBeheerInvesteringsType()
        {
            InitializeComponent();
        }

        private void frmBeheerInvesteringsType_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();

            if (AppForms.frmBeheerInvesteringsType == this)
            {
                AppForms.frmBeheerInvesteringsType = null;
            }
        }

        private void frmBeheerInvesteringsType_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstInvesteringsTypes();

            AppForms.frmBeheerInvesteringsType = this;

            if (AppForms.frmAanvraagFormulier != null)
            {
                this.InvesteringsTypesChanged -=
                    AppForms.frmAanvraagFormulier.FrmBeheerInvesteringsType_InvesteringsTypeChanged;

                this.InvesteringsTypesChanged +=
                    AppForms.frmAanvraagFormulier.FrmBeheerInvesteringsType_InvesteringsTypeChanged;
            }
        }

        public void CreateUI()
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

        public void BindLstInvesteringsTypes()
        {
            investeringen = InvesteringenManager.GetInvesteringen();

            InvesteringsTypes.DisplayMember = "Naam";
            InvesteringsTypes.ValueMember = "Id";
            InvesteringsTypes.DataSource = investeringen;
        }

        private void InvesteringsTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Investering investering = (Investering)InvesteringsTypes.SelectedItem;

            if (investering != null)
            {
                txtId.Text = investering.Id.ToString();
                txtNaam.Text = investering.Naam;
                checkActief.Checked = investering.Actief;

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

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaam.Text))
            {
                MessageBox.Show("Naam is verplicht");
                return;
            }

            Investering i = new Investering();

            if (!IsNew && InvesteringsTypes.SelectedValue != null)
            {
                i.Id = Convert.ToInt32(InvesteringsTypes.SelectedValue);
            }

            i.Naam = txtNaam.Text;
            i.Actief = checkActief.Checked;

            i.Id = InvesteringenManager.SaveInvestering(i, IsNew);
            InvesteringsTypesChanged?.Invoke(this, EventArgs.Empty);

            BindLstInvesteringsTypes();
            ClearFields();
            InvesteringsTypes.SelectedValue = i.Id;
            IsNew = false;

            MessageBox.Show(
                "De gegevens werden succesvol bewaard.",
                "MIA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                Investering i = new Investering();
                i.Id = Convert.ToInt32(InvesteringsTypes.SelectedValue);
                i.Naam = txtNaam.Text;
                if (checkActief.Checked)
                {
                    i.Actief = true;
                }
                else
                {
                    i.Actief = false;

                }

                if (MessageBox.Show($"Bent u dat u {InvesteringsTypes.Text} wilt verwijderen?", "InvesteringsType verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    InvesteringenManager.DeleteInvestering(i);
                    InvesteringsTypesChanged?.Invoke(this, EventArgs.Empty);
                }

                BindLstInvesteringsTypes();
                ClearFields();

            }
            catch (SqlException ex)
            {
                if(ex.Number == 547)
                {
                    MessageBox.Show("Dit investeringstype kan niet verwijderd worden aangezien het al in gebruik is", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een onbekende fout opgetreden. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            MessageBox.Show("De InvesteringsType is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
