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
        public decimal PrijsIndicatieStuk { get; set; }
        public int AantalStuk { get; set; }
        public double Bedrag { get; set; }
        public AanvraagItem()
        {
            InitializeComponent();
        }

        public AanvraagItem(int aantalstuk, DateTime planingsdatum, string gebruiker, string aanvraagmoment, string titel, string financieringsjaar, string statuaaanvraag, string kostenplaats, decimal prijsindicatiestuk)
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

            SetAanvraagLogItemWaarden();
        }

        private void SetAanvraagLogItemWaarden()
        {
            //lblId.Text = Id.ToString();
            //lblTijdstipActie.Text = TijdstipActie.ToString();
            //lblGebruiker.Text = Gebruiker;
            //if (OmschrijvingActie.Length >= 47)
            //{
            //    lblOmschrijvingActieKort.Text = OmschrijvingActie.Substring(0, 47) + "...";
            //}
            //else
            //{
            //    lblOmschrijvingActieKort.Text = OmschrijvingActie.ToString();
            //}
            //if (Even)
            //{
            //    this.BackColor = Color.White;
            //}
        }

        private void llblDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (AanvraagLogItemSelected != null)
            //{
            //    Aanvraag6LogItemSelected(this, null);
            //}
        }

        private void AanvraagItem_Load(object sender, EventArgs e)
        {

        }
    }
}
