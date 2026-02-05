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

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true; // mag ook false als je wil
        }

        private void frmBeheerInvesteringsType_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();

            //if (AppForms.frmBeheerInvesteringsType == this)
            //{
            //    AppForms.frmBeheerInvesteringsType = null;
            //}
        }

        private void frmBeheerInvesteringsType_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstInvesteringsTypes();
            txtNaam.MaxLength = 100;
            // ⬇️ altijd leeg starten
            ClearFields();
            InvesteringsTypes.SelectedIndex = -1;

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
            InvesteringsTypes.SelectedIndex = -1;
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

            // ⬇️ niets geselecteerd in de lijst
            InvesteringsTypes.SelectedIndex = -1;
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            string naam = txtNaam.Text.Trim();

            if (string.IsNullOrWhiteSpace(naam))
            {
                MessageBox.Show("Naam is verplicht");
                return;
            }

            Investering i = new Investering();

            if (!IsNew && InvesteringsTypes.SelectedValue != null)
            {
                i.Id = Convert.ToInt32(InvesteringsTypes.SelectedValue);
            }

            i.Naam = naam; // getrimde waarde
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
            // 1. Niets geselecteerd → stoppen
            if (InvesteringsTypes.SelectedValue == null || InvesteringsTypes.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecteer eerst een investeringstype om te verwijderen.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 2. Bevestiging vragen
            DialogResult result = MessageBox.Show(
                $"Bent u zeker dat u '{InvesteringsTypes.Text}' wilt verwijderen?",
                "InvesteringsType verwijderen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                // Nee → niets doen
                return;
            }

            try
            {
                Investering i = new Investering
                {
                    Id = Convert.ToInt32(InvesteringsTypes.SelectedValue),
                    Naam = txtNaam.Text,
                    Actief = checkActief.Checked
                };

                InvesteringenManager.DeleteInvestering(i);

                InvesteringsTypesChanged?.Invoke(this, EventArgs.Empty);
                BindLstInvesteringsTypes();
                ClearFields();

                MessageBox.Show(
                    "Het investeringstype is succesvol verwijderd.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(
                    "Dit investeringstype kan niet verwijderd worden aangezien het al in gebruik is.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Er is een onbekende fout opgetreden.\n" + ex.Message,
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
