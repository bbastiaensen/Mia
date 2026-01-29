using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmNieuweAankoop : Form
    {
        public frmNieuweAankoop()
        {
            InitializeComponent();
        }

        private void frmNieuweAankoop_Load(object sender, EventArgs e)
        {
            CreateUI();
            LaadBekrachtigdeAanvragen();
        }

        //private void LaadBekrachtigdeAanvragen()
        //{
        //    var aanvragen = AanvraagManager.GetBekrachtigdeAanvragenZonderAankoop();

        //    if (aanvragen != null && aanvragen.Any())
        //    {
        //        dgvAanvragen.DataSource = aanvragen;
        //    }
        //    else
        //    {
        //        dgvAanvragen.DataSource = null;
        //    }
        //}

        private void LaadBekrachtigdeAanvragen()
        {
            // Haal de lijst op uit de static class
            var aanvragen = AanvraagManager.GetBekrachtigdeAanvragenZonderAankoop();

            if (aanvragen != null && aanvragen.Any())
            {
                // Projecteer alleen de velden die je wilt tonen
                var dgvData = aanvragen.Select(a => new
                {
                    Omschrijving = a.Omschrijving,
                    Aanvrager = a.Id,
                    StatusAanvraag = a.StatusAanvraag,
                    Financieringsjaar = a.Financieringsjaar,
                    Richtperiode = a.RichtperiodeId
                }).ToList();

                dgvAanvragen.DataSource = dgvData;

                // Optioneel: kolomnamen mooi maken
                dgvAanvragen.Columns["StatusAanvraag"].HeaderText = "Status aanvraag";
                dgvAanvragen.Columns["Financieringsjaar"].HeaderText = "Financieringsjaar";
                dgvAanvragen.Columns["Richtperiode"].HeaderText = "Richtperiode";
            }
            else
            {
                dgvAanvragen.DataSource = null;
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

        private void frmNieuweAankoop_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

  
    }
}
