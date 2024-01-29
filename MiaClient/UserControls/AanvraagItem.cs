using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    public partial class AanvraagItem : UserControl
    {
        public string Gebruiker { get; set; }
        public string Aanvraagmoment { get; set; }
        public string Titel { get; set; }
        public string Financieringsjaar { get; set; }
        public DateTime Planningsdatum { get; set; }
        public string StatusAanvraag { get; set; }
        public string Kostenplaats { get; set; }
        public double PrijsIndicatieStuk { get; set; }
        public int AantalStuk { get; set; }
        public double Bedrag { get; set; }
        public Boolean Even { get; set; }

        public event EventHandler AanvraagItemSelected;

        public AanvraagItem()
        {
            InitializeComponent();
        }

        public AanvraagItem(int aantalstuk, DateTime planingsdatum, string gebruiker, string aanvraagmoment, string titel, string financieringsjaar, string statuaaanvraag, string kostenplaats, double prijsindicatiestuk, Boolean even)
        {
            InitializeComponent();
            Gebruiker = gebruiker;
            Aanvraagmoment = aanvraagmoment;
            Titel = titel;
            Financieringsjaar = financieringsjaar;
            Planningsdatum = planingsdatum;
            StatusAanvraag = statuaaanvraag;
            Kostenplaats = kostenplaats;
            PrijsIndicatieStuk = prijsindicatiestuk;
            AantalStuk = aantalstuk;
            Even = even;
            Bedrag = aantalstuk * prijsindicatiestuk;
            SetAanvraagLogItemWaarden();
        }

        private void SetAanvraagLogItemWaarden()
        {
            lblGebruiker.Text = Gebruiker.ToString();
            lblAanvraagmoment.Text = Aanvraagmoment.ToString();
            
            lblFinancieringsjaar.Text = Financieringsjaar.ToString();
            lblKostenplaats.Text = Kostenplaats.ToString();
            lblAanvraagmoment.Text = Aanvraagmoment.ToString();
            lblStatusAanvraag.Text = StatusAanvraag.ToString();
            lblPlaningsDatum.Text = lblPlaningsDatum.ToString();
            if (Titel.Length >= 20)
            {
                lblTitel.Text = Titel.Substring(0, 20) + "...";
            }
            else
            {
                lblTitel.Text = Titel.ToString();
            }
            if (Even)
            {
                this.BackColor = Color.White;
            }
        }

        private void llblDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AanvraagItemSelected != null)
            {
                AanvraagItemSelected(this, null);
            }
        }

        private void AanvraagItem_Load(object sender, EventArgs e)
        {

        }
    }
}
