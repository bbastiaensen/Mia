using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBeheerLeverancier : Form
    {
        List<leverancier> leveranciers;
        bool IsNew = false;
        bool isClearing = false;

        public frmBeheerLeverancier()
        {
            InitializeComponent();
        }

        private void frmLeverancier_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLanden();
            BindLstLeveranciers();
        }

        private void frmBeheerLeverancier_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
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

        public void BindLstLeveranciers()
        {
            leveranciers = LeverancierManager.GetAllLeveranciers();
            LstLeveranciers.DisplayMember = "Leverancier";
            LstLeveranciers.ValueMember = "Id";
            LstLeveranciers.DataSource = leveranciers;
        }

        private void ClearFields()
        {
            isClearing = true;

            LstLeveranciers.SelectedIndex = -1;
            txtAdres.Text = string.Empty;
            txtId.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLeverancier.Text = string.Empty;
            txtWebsite.Text = string.Empty;

            ddlLand.SelectedIndex = -1;
            ddlPostcodeGemeente.DataSource = null;
            ddlPostcodeGemeente.SelectedIndex = -1;

            isClearing = false;
            IsNew = true;
        }

        private void LstLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isClearing) return;

            leverancier leverancier = (leverancier)LstLeveranciers.SelectedItem;

            if (leverancier != null)
            {
                txtId.Text = Convert.ToString(leverancier.Id);
                txtLeverancier.Text = leverancier.Leverancier;
                txtAdres.Text = leverancier.Adres;
                txtEmail.Text = leverancier.Email;
                txtWebsite.Text = leverancier.Website;

                //Land en Gemeente laden op basis van GemeenteId
                if (leverancier.GemeenteId > 0)
                {
                    Gemeente gem = GemeenteManager.GetGemeenteById(leverancier.GemeenteId);
                    if (gem != null)
                    {
                        // Eerst het land selecteren
                        ddlLand.SelectedValue = gem.LandId;

                        // Dan de gemeente selecteren
                        ddlPostcodeGemeente.SelectedValue = gem.Id;
                    }
                }
                else
                {
                    ddlLand.SelectedIndex = -1;
                    ddlPostcodeGemeente.SelectedIndex = -1;
                }

                IsNew = false;
            }
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            leverancier leverancier;

            if (IsNew)
            {
                leverancier = new leverancier();
            }
            else
            {
                leverancier = (leverancier)LstLeveranciers.SelectedItem;
            }

            // Validatie
            if (string.IsNullOrWhiteSpace(txtLeverancier.Text))
            {
                MessageBox.Show("Vul een leveranciersnaam in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLeverancier.Focus();
                return;
            }

            if (ddlLand.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een land.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ddlLand.Focus();
                return;
            }

            if (ddlPostcodeGemeente.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een gemeente.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ddlPostcodeGemeente.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!IsValid(txtEmail.Text))
                {
                    MessageBox.Show("Vul een geldig e-mailadres in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
            }

            if (!string.IsNullOrEmpty(txtWebsite.Text))
            {
                if (!IsValidUrl(txtWebsite.Text))
                {
                    MessageBox.Show("Vul een geldige website-URL in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWebsite.Focus();
                    return;
                }
            }

            leverancier.Leverancier = txtLeverancier.Text.Trim();
            leverancier.Email = txtEmail.Text.Trim();
            leverancier.Adres = txtAdres.Text.Trim();
            leverancier.Website = txtWebsite.Text.Trim();

            Gemeente gem = (Gemeente)ddlPostcodeGemeente.SelectedItem;
            leverancier.GemeenteId = gem.Id;

            leverancier.Id = LeverancierManager.SaveLeverancier(leverancier, IsNew);

            BindLstLeveranciers();
            LstLeveranciers.SelectedValue = leverancier.Id;
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (LstLeveranciers.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een leverancier.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            leverancier leverancier = (leverancier)LstLeveranciers.SelectedItem;

            DialogResult res = MessageBox.Show($"Ben je zeker dat je leverancier '{leverancier.Leverancier}' wil verwijderen?", "Bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
            {
                return;
            }

            try
            {
                LeverancierManager.DeleteLeverancier(leverancier.Id);
                BindLstLeveranciers();
                ClearFields();

                MessageBox.Show("Leverancier werd verwijderd.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Deze leverancier kan niet verwijderd worden omdat hij nog gebruikt wordt.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindLanden()
        {
            List<Land> landen = LandenManager.GetLanden();

            ddlLand.DataSource = landen;
            ddlLand.DisplayMember = "Naam";
            ddlLand.ValueMember = "Id";
            ddlLand.SelectedIndex = -1;
        }

        private void ddlLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlLand.SelectedItem == null)
            {
                ddlPostcodeGemeente.DataSource = null;
                return;
            }

            Land l = (Land)ddlLand.SelectedItem;

            // Eerst DataSource clearen om volledige refresh te forceren
            ddlPostcodeGemeente.DataSource = null;
            ddlPostcodeGemeente.Items.Clear();

            ddlPostcodeGemeente.DisplayMember = "PostcodeNaam";
            ddlPostcodeGemeente.ValueMember = "Id";
            ddlPostcodeGemeente.DataSource =
            GemeenteManager.GetGemeentenByLandId(l.Id);
            ddlPostcodeGemeente.SelectedIndex = -1;
        }

        private static bool IsValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }

        private bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}
