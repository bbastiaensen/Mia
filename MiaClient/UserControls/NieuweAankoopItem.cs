using ProofOfConceptDesign;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MiaLogic.Object;

namespace MiaClient.UserControls
{
    public partial class NieuweAankoopItem : UserControl
    {
        // 👉 Belangrijk: volledige Aanvraag bewaren
        public Aanvraag Aanvraag { get; set; }

        public bool Even { get; set; }

        public event EventHandler EuroClicked;

        public NieuweAankoopItem()
        {
            InitializeComponent();
            SetupLabels();
        }

        public NieuweAankoopItem(
            Aanvraag aanvraag,
            bool even)
        {
            InitializeComponent();

            Aanvraag = aanvraag;
            Even = even;

            SetupLabels();
            SetItemValue();
            LoadEuroIcon();
        }

        private void SetupLabels()
        {
            lblOmschrijving.AutoSize = false;
            lblOmschrijving.AutoEllipsis = true;

            lblAanvrager.AutoSize = false;
            lblAanvrager.AutoEllipsis = true;

            lblStatusAanvraag.AutoSize = false;
            lblStatusAanvraag.AutoEllipsis = true;

            lblFinancieringsjaar.AutoSize = false;
            lblFinancieringsjaar.AutoEllipsis = true;

            lblRichtperiode.AutoSize = false;
            lblRichtperiode.AutoEllipsis = true;
        }
        private void lblOmschrijving_Paint(object sender, PaintEventArgs e)
        {
            var lbl = (Label)sender;

            TextFormatFlags flags =
                TextFormatFlags.Left |
                TextFormatFlags.Bottom |
                TextFormatFlags.EndEllipsis;

            e.Graphics.Clear(lbl.BackColor);

            TextRenderer.DrawText(
                e.Graphics,
                lbl.Text,
                lbl.Font,
                lbl.ClientRectangle,
                lbl.ForeColor,
                flags
            );
        }


        private void SetItemValue()
        {
            if (Aanvraag == null) return;

            lblOmschrijving.Text = Aanvraag.Omschrijving ?? "";
            lblAanvrager.Text = Aanvraag.Gebruiker ?? "";
            lblStatusAanvraag.Text = Aanvraag.StatusAanvraag ?? "";
            lblFinancieringsjaar.Text = Aanvraag.Financieringsjaar ?? "";
            lblRichtperiode.Text = Aanvraag.RichtperiodeNaam ?? "";

            BackColor = Even
                ? StyleParameters.ListItemColor
                : StyleParameters.AltListItemColor;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int padding = 10;
            int height = Height;

            lblOmschrijving.SetBounds(49, 0, 150, height);
            lblAanvrager.SetBounds(250, 0, 140, height);
            lblStatusAanvraag.SetBounds(415, 0, 120, height);
            lblFinancieringsjaar.SetBounds(615, 0, 120, height);
            lblRichtperiode.SetBounds(800, 0, Math.Max(0, Width - 845 - padding), height);
        }

        private void LoadEuroIcon()
        {
            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "icons",
                "icons8-euro-50.png"
            );

            if (File.Exists(path))
            {
                using (var img = Image.FromFile(path))
                    btnEuro.Image = new Bitmap(img, new Size(20, 20));
            }
            else
            {
                btnEuro.Text = "€";
                btnEuro.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            }
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            EuroClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
