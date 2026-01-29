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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MiaClient
{
    public partial class frmBeheerLeveranciers : Form
    {
        List<leverancier> leveranciers;
        bool IsNew = false;

        public frmBeheerLeveranciers()
        {
            InitializeComponent();
        }

        private void frmBeheerLeveranciers_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstLeveranciers();
            BindLanden();
        }

        private void frmBeheerAankopers_FormClosing(object sender, FormClosingEventArgs e)
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
            txtAdres.Text = string.Empty;
            txtId.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLeverancier.Text = string.Empty;
            txtWebsite.Text = string.Empty;
            
            // Fix: Dropdowns correct leegmaken
            ddlLand.SelectedIndex = -1;
            ddlPostcodeGemeente.DataSource = null;
            ddlPostcodeGemeente.SelectedIndex = -1;
            
            IsNew = true;
        }



        private void LstLeveranciers_SelectedIndexChanged(object sender, EventArgs e)
        {
            leverancier leverancier = (leverancier)LstLeveranciers.SelectedItem;

            if (leverancier != null)
            {
                txtId.Text = Convert.ToString(leverancier.Id);
                txtLeverancier.Text = leverancier.Leverancier;
                txtAdres.Text = leverancier.Adres;
                txtEmail.Text = leverancier.Email;
                txtWebsite.Text = leverancier.Website;

                // Fix: Land en Gemeente laden op basis van GemeenteId
                if (leverancier.GemeenteId > 0)
                {
                    gemeente gem = LeverancierManager.GetGemeenteById(leverancier.GemeenteId);
                    if (gem != null)
                    {
                        // Eerst het land selecteren
                        ddlLand.SelectedValue = gem.LandId;

                        // Dan de gemeente selecteren (ddlPostcodeGemeente wordt gevuld door ddlLand_SelectedIndexChanged)
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

            leverancier.Leverancier = txtLeverancier.Text;
            leverancier.Email = txtEmail.Text;
            leverancier.Adres = txtAdres.Text;
            leverancier.Website = txtWebsite.Text;

            if (ddlPostcodeGemeente.SelectedItem != null)
            {
                gemeente gem = (gemeente)ddlPostcodeGemeente.SelectedItem;
                leverancier.GemeenteId = gem.Id;
            }
            else
            {
                MessageBox.Show("Selecteer een gemeente.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            leverancier.Id = LeverancierManager.SaveLeverancier(leverancier, IsNew);

            BindLstLeveranciers();
            LstLeveranciers.SelectedValue = leverancier.Id;
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BindLanden()
        {
            List<Land> landen = LeverancierManager.GetAllLanden();

            ddlLand.DataSource = landen;
            ddlLand.DisplayMember = "Naam";
            ddlLand.ValueMember = "Id";
            ddlLand.SelectedIndex = -1;
        }

        private void ddlLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlLand.SelectedItem == null)
            {
                return;
            }

            Land l = (Land)ddlLand.SelectedItem;

            ddlPostcodeGemeente.DataSource =
                LeverancierManager.GetGemeentenByLandId(l.Id);

            ddlPostcodeGemeente.DisplayMember = "PostcodeNaam";
            ddlPostcodeGemeente.ValueMember = "Id";
            ddlPostcodeGemeente.SelectedIndex = -1;
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (LstLeveranciers.SelectedItem == null)
            {
                MessageBox.Show("Selecteer een leverancier.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            leverancier leverancier = (leverancier)LstLeveranciers.SelectedItem;

            DialogResult res = MessageBox.Show( $"Ben je zeker dat je leverancier '{leverancier.Leverancier}' wil verwijderen?",  "Bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
            {
                return;
            }

            try
            {
                LeverancierManager.DeleteLeverancier(leverancier.Id);

                BindLstLeveranciers();
                ClearFields();

                MessageBox.Show("Leverancier werd verwijderd.", "MIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show( "Deze leverancier kan niet verwijderd worden omdat hij nog gebruikt wordt.", "Fout",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

