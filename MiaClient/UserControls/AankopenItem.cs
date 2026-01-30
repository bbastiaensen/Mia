using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    public partial class AankopenItem : UserControl
    {
        public int AankoopId { get; set; }
        public string StatusAankoopNaam { get; set; }
        public Boolean Even { get; set; }

        private AankoopOverzichtItem _aankoopItem;
        private ToolTip _toolTip = new ToolTip();

        public event EventHandler AankoopDeleted;
        public event EventHandler AankoopItemSelected;
        public event EventHandler AankoopItemChanged;

        public AankopenItem()
        {
            InitializeComponent();
            _toolTip.ShowAlways = true;
            _toolTip.AutoPopDelay = 10000;
            _toolTip.InitialDelay = 300;
            _toolTip.ReshowDelay = 0;

           
        }
    

        public void BindAankoop(AankoopOverzichtItem aankoopItem, bool evenRow = false)
        {
            if (aankoopItem == null)
                throw new ArgumentNullException(nameof(aankoopItem));

            _aankoopItem = aankoopItem;
            Even = evenRow;
            AankoopId = aankoopItem.AankoopId;
            StatusAankoopNaam = aankoopItem.StatusAankoop;

            SetItemValue();
        }

        private void SetItemValue()
        {
            // Toon titel van aanvraag in het label (niet omschrijving)
            string titel = _aankoopItem.Titel ?? "";
            if (titel.Length > 25)
            {
                lblOmschrijving.Text = titel.Substring(0, 22) + "...";
            }
            else
            {
                lblOmschrijving.Text = titel;
            }

            // Tooltip: omschrijving tonen bij hover over titel (zoals in frmBeheerParameters)
            string omschrijving = _aankoopItem.Omschrijving ?? "";
            _toolTip.RemoveAll();
            _toolTip.Active = true;
            _toolTip.ShowAlways = true;
            if (!string.IsNullOrEmpty(omschrijving))
            {
                _toolTip.SetToolTip(lblOmschrijving, "Omschrijving: " + omschrijving);
            }
            else
            {
                _toolTip.SetToolTip(lblOmschrijving, null);
            }

            lblStatusAankoop.Text = _aankoopItem.StatusAankoop ?? "";
            lblAankoper.Text = _aankoopItem.Aankoper ?? "";
            lblAanvrager.Text = _aankoopItem.Aanvrager ?? "";
            lblFinancieringsjaar.Text = _aankoopItem.Financieringsjaar ?? "";
            lblRichtperiode.Text = _aankoopItem.Richtperiode ?? "";
            lblGoedgekeurdBedrag.Text = _aankoopItem.GoedgekeurdBedrag.ToString("c", CultureInfo.CurrentCulture);
            lblSaldo.Text = _aankoopItem.Saldo.ToString("c", CultureInfo.CurrentCulture);

            if (Even)
            {
                this.BackColor = StyleParameters.ListItemColor;
            }
            else
            {
                this.BackColor = StyleParameters.AltListItemColor;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (AankoopItemSelected != null)
            {
                AankoopItemSelected(this, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (AankoopDeleted != null)
            {
                AankoopDeleted(this, null);
            }
        }
    }
}
