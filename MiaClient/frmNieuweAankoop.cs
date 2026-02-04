using MiaLogic.Manager;
using MiaLogic.Object;
using MiaClient.UserControls;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmNieuweAankoop : Form
    {
        private List<Aanvraag> _bekrachtigdeAanvragen;
        public event EventHandler AankoopToegevoegd;

        public frmNieuweAankoop()
        {
            InitializeComponent();

            pnlBekrachtigdeAanvragen.AutoScroll = true;
            pnlBekrachtigdeAanvragen.HorizontalScroll.Enabled = false;
            pnlBekrachtigdeAanvragen.HorizontalScroll.Visible = false;

            pnlBekrachtigdeAanvragen.Resize += pnlAanvragen_Resize;
        }

        private void frmNieuweAankoop_Load(object sender, EventArgs e)
        {
            CreateUI();
            LaadBekrachtigdeAanvragen();
        }
        public void LaadtAanvraag(Aanvraag aanvraag)
        {
            if (aanvraag == null) return;

            // ⬇️ VERVANG door jouw echte controls
            lblOmschrijving.Text = aanvraag.Omschrijving;
            lblAanvrager.Text = aanvraag.Gebruiker;
            lblFinancieringsjaar.Text = aanvraag.Financieringsjaar;
            lblRichtperiode.Text = aanvraag.RichtperiodeNaam;
            lblStatusAanvraag.Text = aanvraag.StatusAanvraag;
        }


        public void RefreshBekrachtigdeAanvragen()
        {
            LaadBekrachtigdeAanvragen();
        }

        private void LaadBekrachtigdeAanvragen()
        {
            _bekrachtigdeAanvragen =
                AanvraagManager.GetBekrachtigdeAanvragenZonderAankoop();

            BindAanvragen(_bekrachtigdeAanvragen);
        }

        public void BindAanvragen(List<Aanvraag> items)
        {
            pnlBekrachtigdeAanvragen.SuspendLayout();
            pnlBekrachtigdeAanvragen.Controls.Clear();

            if (items == null) return;

            int yPos = 0;
            int rowHeight = 33;
            int n = 0;

            foreach (var aanvraag in items)
            {
                var item = new NieuweAankoopItem(
                    aanvraag,
                    n % 2 == 0
                );

                item.Location = new Point(0, yPos);
                item.Width = pnlBekrachtigdeAanvragen.ClientSize.Width;
                item.Height = rowHeight;

                item.EuroClicked += NieuweAankoopItem_EuroClicked;

                pnlBekrachtigdeAanvragen.Controls.Add(item);

                yPos += rowHeight;
                n++;
            }

            pnlBekrachtigdeAanvragen.ResumeLayout();
        }

        private void pnlAanvragen_Resize(object sender, EventArgs e)
        {
            foreach (NieuweAankoopItem item in pnlBekrachtigdeAanvragen.Controls)
            {
                item.Width = pnlBekrachtigdeAanvragen.ClientSize.Width;
            }
        }

        private void NieuweAankoopItem_EuroClicked(object sender, EventArgs e)
        {
            var item = (NieuweAankoopItem)sender;

            if (item.Aanvraag != null)
            {
                VoegAanvraagToeAanAankopen(item.Aanvraag);
            }
        }

        private void VoegAanvraagToeAanAankopen(Aanvraag aanvraag)
        {
            try
            {
                var aankoop = new Aankoop
                {
                    Omschrijving = aanvraag.Omschrijving ?? "",
                    BTWPercentage = 21,
                    BedragExBtw = 0,
                    StatusAankoopId = 1,
                    LeverancierId = 1,
                    AanvraagId = aanvraag.Id
                };

                AankoopManager.CreateAankoop(aankoop);

                LaadBekrachtigdeAanvragen();
                AankoopToegevoegd?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Fout bij toevoegen aankoop",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
            Hide();
        }
    }
}
