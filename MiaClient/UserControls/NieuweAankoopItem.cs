using ProofOfConceptDesign;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    public partial class NieuweAankoopItem : UserControl
    {
        public int AanvraagId { get; set; }
        public string Omschrijving { get; set; }
        public string Aanvrager { get; set; }
        public string StatusAanvraag { get; set; }
        public string Financieringsjaar { get; set; }
        public string Richtperiode { get; set; }
        public bool Even { get; set; }

        public event EventHandler EuroClicked;

        public NieuweAankoopItem()
        {
            InitializeComponent();
        }

        public NieuweAankoopItem(int aanvraagId, string omschrijving, string aanvrager, string statusAanvraag, string financieringsjaar, string richtperiode, bool even)
        {
            InitializeComponent();
            AanvraagId = aanvraagId;
            Aanvrager = aanvrager ?? "";
            StatusAanvraag = statusAanvraag ?? "";
            Financieringsjaar = financieringsjaar ?? "";
            Omschrijving = omschrijving ?? "";
            Richtperiode = richtperiode ?? "";
            Even = even;
            SetItemValue();
            LoadEuroIcon();
        }
        public void AdjustLabelHeights(int height)
        {
            lblOmschrijving.Height = height;
            lblAanvrager.Height = height;
            lblStatusAanvraag.Height = height;
            lblFinancieringsjaar.Height = height;
            lblRichtperiode.Height = height;

            // Optioneel: centreren van de tekst verticaal
            lblOmschrijving.TextAlign = ContentAlignment.MiddleLeft;
            lblAanvrager.TextAlign = ContentAlignment.MiddleLeft;
            lblStatusAanvraag.TextAlign = ContentAlignment.MiddleLeft;
            lblFinancieringsjaar.TextAlign = ContentAlignment.MiddleLeft;
            lblRichtperiode.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void LoadEuroIcon()
        {
            var euroIconPath = Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-euro-50.png");
            if (File.Exists(euroIconPath))
            {
                btnEuro.Image = Image.FromFile(euroIconPath);
                btnEuro.ImageAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                btnEuro.Text = "€";
            }
            btnEuro.Size = new Size(20, 20);
            btnEuro.ImageAlign = ContentAlignment.MiddleCenter;
            btnEuro.Text = "";

        }

        private void SetItemValue()
        {
            lblOmschrijving.Text = TruncateText(Omschrijving, 25);
            lblAanvrager.Text = Aanvrager;
            lblStatusAanvraag.Text = StatusAanvraag;
            lblFinancieringsjaar.Text = Financieringsjaar;
            lblRichtperiode.Text = Richtperiode;

            if (Even)
            {
                this.BackColor = StyleParameters.ListItemColor;
            }
            else
            {
                this.BackColor = StyleParameters.AltListItemColor;
            }
        }

        private static string TruncateText(string text, int maxLength)
        {
            if (string.IsNullOrEmpty(text)) return "";
            if (text.Length <= maxLength) return text;
            return text.Substring(0, maxLength - 3) + "...";
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            EuroClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
