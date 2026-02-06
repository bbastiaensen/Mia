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
using System.Runtime.InteropServices;

namespace MiaClient
{
    public partial class frmBeheerFinancieringsType : MdiChildBoundedForm
    {

        public event EventHandler FinancieringTypeChanged;
        List<Financiering> financierings;
        public static int? LastActiveFinancieringsId { get; set; }


        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;
        bool IsNew = false;

        public frmBeheerFinancieringsType()
        {
            InitializeComponent();
        }



        private void frmBeheerFinancieringsType_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstFinancieringsTypen();

            AppForms.frmBeheerFinancieringsType = this;

            if (AppForms.frmAanvraagFormulier != null)
            {
                this.FinancieringTypeChanged -= AppForms.frmAanvraagFormulier.frmBeheerFinancieringsType_financieringTypeChanged;
                this.FinancieringTypeChanged += AppForms.frmAanvraagFormulier.frmBeheerFinancieringsType_financieringTypeChanged;
            }
        }

        private void frmBeheerFinancieringsType_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {

            txtId.Text = string.Empty;
            txtNaam.Text = string.Empty;
            checkActief.Checked = false;


            LstFinancieringsTypen.ClearSelected(); // <-- toevoegen
            IsNew = true;

            // Verwijderen-knop uitschakelen en grijs maken
            btnVerwijderen.Enabled = false;
            btnVerwijderen.BackColor = Color.Gray;
        }
        private void btnBewaren_Click(object sender, EventArgs e)
        {
            // UI-validatie (snel feedback)
            if (string.IsNullOrWhiteSpace(txtNaam.Text))
            {
                MessageBox.Show(
                    "Naam is een verplicht veld.",
                    "Validatie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNaam.Focus();
                return;
            }

            Financiering a = new Financiering
            {
                Id = IsNew ? 0 : (int)LstFinancieringsTypen.SelectedValue,
                Naam = txtNaam.Text.Trim(),
                Actief = checkActief.Checked
            };

            //HIER hoort de try/catch
            try
            {
                a.Id = FinancieringenManager.SaveFinancieringType(a, IsNew);
                if (a.Actief)
                {
                    LastActiveFinancieringsId = a.Id;
                }
                FinancieringTypeChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validatie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return; // STOP: niets bewaren
            }

           

            BindLstFinancieringsTypen();
            LstFinancieringsTypen.SelectedValue = a.Id;

            IsNew = false;

            MessageBox.Show(
                "De gegevens werden succesvol bewaard.",
                "MIA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            



        }
        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            // Zorg dat er iets geselecteerd is
            if (LstFinancieringsTypen.SelectedItem == null)
            {
                MessageBox.Show(
                    "Er is geen financieringstype geselecteerd om te verwijderen.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Actueel geselecteerd record
            Financiering a = (Financiering)LstFinancieringsTypen.SelectedItem;

            // Vraag bevestiging
            if (MessageBox.Show(
                    $"Bent u zeker dat u het financieringstype \"{LstFinancieringsTypen.Text}\" wilt verwijderen?",
                    "MIA",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Controleer of het al gebruikt wordt
                    if (FinancieringenManager.IsFinancieringGebruikt(a.Id))
                    {
                        // Alleen deactiveren
                        FinancieringenManager.DeactiveerFinanciering(a.Id);
                        FinancieringTypeChanged?.Invoke(this, EventArgs.Empty);

                      

                        MessageBox.Show(
                            "Dit financieringstype is gekoppeld aan een aanvraag en werd op niet-actief gezet.",
                            "MIA",
                            MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Kan veilig verwijderen (of deactiveren)
                        FinancieringenManager.DeleteFinancier(a);

                        FinancieringTypeChanged?.Invoke(this, EventArgs.Empty);

                        MessageBox.Show(
                            "Het financieringstype werd succesvol verwijderd.",
                            "MIA",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    // Lijst vernieuwen en velden leegmaken
                    BindLstFinancieringsTypen();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    // Exception netjes afvangen, geen crash
                    MessageBox.Show(
                        "Er is een fout opgetreden bij het verwijderen.\n\n" + ex.Message,
                        "MIA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


    

        public void BindLstFinancieringsTypen()
        {

            financierings = FinancieringenManager.GetFinancieringen();

            LstFinancieringsTypen.DisplayMember = "Naam";
            LstFinancieringsTypen.ValueMember = "Id";
            LstFinancieringsTypen.DataSource = financierings;

        }

        private void LstFinancieringsTypen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bescherming tegen null / herbinding
            if (LstFinancieringsTypen.SelectedItem == null)
                return;

            Financiering financier = (Financiering)LstFinancieringsTypen.SelectedItem;

            txtId.Text = financier.Id.ToString();
            txtNaam.Text = financier.Naam;
            checkActief.Checked = financier.Actief;

            // Zodra iets geselecteerd is, is het GEEN nieuw record
            IsNew = false;
            btnVerwijderen.Enabled = true;
            btnVerwijderen.BackColor = StyleParameters.ButtonBack;
        }
    }
}

