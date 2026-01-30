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
            pnlAanvragen.Resize += pnlAanvragen_Resize;
            pnlAanvragen.AutoScrollMinSize = System.Drawing.Size.Empty;

            pnlAanvragen.Resize += pnlAanvragen_Resize;
        }

        private void frmNieuweAankoop_Load(object sender, EventArgs e)
        {
            CreateUI();
            LaadBekrachtigdeAanvragen();
        }

        public void RefreshBekrachtigdeAanvragen()
        {
            LaadBekrachtigdeAanvragen();
        }

        private void LaadBekrachtigdeAanvragen()
        {
            _bekrachtigdeAanvragen = AanvraagManager.GetBekrachtigdeAanvragenZonderAankoop();
            BindAanvragen(_bekrachtigdeAanvragen);
        }

        // Bind items
        public void BindAanvragen(List<Aanvraag> items)
        {
            pnlAanvragen.SuspendLayout();
            pnlAanvragen.Controls.Clear();

            if (items == null) return;

            int yPos = 0;
            int rowHeight = 23; // zelfde hoogte als header
            int n = 0;

            foreach (var av in items)
            {
                var item = new NieuweAankoopItem(
                    av.Id,
                    av.Omschrijving,
                    av.Gebruiker,
                    av.StatusAanvraag,
                    av.Financieringsjaar,
                    av.RichtperiodeNaam,
                    n % 2 == 0
                );

                item.Location = new Point(0, yPos);
                item.Width = pnlAanvragen.ClientSize.Width;
                item.Height = rowHeight;
                item.AdjustLabelHeights(rowHeight);

                item.EuroClicked += NieuweAankoopItem_EuroClicked;

                pnlAanvragen.Controls.Add(item);

                yPos += rowHeight;
                n++;
            }

            pnlAanvragen.ResumeLayout();
        }

        // resize handler
        private void pnlAanvragen_Resize(object sender, EventArgs e)
        {
            foreach (NieuweAankoopItem item in pnlAanvragen.Controls)
            {
                item.Width = pnlAanvragen.ClientSize.Width;
            }
        }




        private void NieuweAankoopItem_EuroClicked(object sender, EventArgs e)
        {
            var item = (NieuweAankoopItem)sender;
            var aanvraag = _bekrachtigdeAanvragen?.FirstOrDefault(a => a.Id == item.AanvraagId);
            if (aanvraag != null)
            {
                VoegAanvraagToeAanAankopen(aanvraag);
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
            ((Form)sender).Hide();
        }
    }
}
