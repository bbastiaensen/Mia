using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MiaClient.UserControls
{
    public partial class AanvraagItem : UserControl
    {
        public int Id { get; set; }
        public string Gebruiker { get; set; }
        public DateTime Aanvraagmoment { get; set; }
        public string Titel { get; set; }
        public string Financieringsjaar { get; set; }
        public DateTime Planningsdatum { get; set; }
        public string StatusAanvraag { get; set; }
        public string Kostenplaats { get; set; }
        public decimal PrijsIndicatieStuk { get; set; }
        public int AantalStuk { get; set; }
        public decimal Bedrag { get; set; }
        public Boolean Even { get; set; }

        public event EventHandler AanvraagDeleted;
        public event EventHandler AanvraagItemSelected;
        public AanvraagItem()
        {
            InitializeComponent();
        }
        public AanvraagItem(int id,string gebruiker, DateTime aanvraagmoment, string titel, string financieringsjaar,DateTime planingsdatum, string statuaaanvraag, string kostenplaats, decimal prijsindicatiestuk, int aantalstuk, Boolean even)
        {
            InitializeComponent();
            Id = id;    
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
            
            SetAanvraagItemWaarden();
        }
        private void SetAanvraagItemWaarden()
        {
            DateTime Datum = new DateTime(2000, 1, 1);

            lblId.Text = Id.ToString();
            lblGebruiker.Text = Gebruiker.ToString();
            lblAanvraagmoment.Text = Aanvraagmoment.ToString();
            if(Financieringsjaar != null)
            {
                lblFinancieringsjaar.Text = Financieringsjaar.ToString();
            }
            lblKostenplaats.Text = Kostenplaats.ToString();
            lblAanvraagmoment.Text = Aanvraagmoment.ToString();
            lblStatusAanvraag.Text = StatusAanvraag.ToString();
            if (Planningsdatum > Datum)
            {
                lblPlaningsDatum.Text = Planningsdatum.ToString();
            }
            if (Titel.Length >= 20)
            {
                lblTitel.Text = Titel.Substring(0, 20) + "...";
            }
            else
            {
                lblTitel.Text = Titel.ToString();
            }
            lblBedrag.Text = "\u20AC " + Bedrag.ToString("c", CultureInfo.CurrentCulture);
            //lblBedrag.Text = Bedrag.ToString();
            if (Even)
            {
                this.BackColor = Color.White;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (AanvraagItemSelected != null)
            {
                AanvraagItemSelected(this, null);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ben je zeker dat je deze Aanvraag wilt verwijderen?", "Aanvragen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (AanvraagDeleted != null)
                {
                    if (lblGebruiker.Text == Program.Gebruiker || Program.IsSysteem && lblStatusAanvraag.Text == "In aanvraag")
                    {
                        Aanvraag aanvraag = new Aanvraag();
                        aanvraag.Id = Convert.ToInt32(lblId.Text);
                        AanvraagManager.DeleteAanvraag(aanvraag);
                        AanvraagDeleted(this, null);
                        MessageBox.Show("De aanvraag is succesvol verwijderd.","Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Aanvraag aanvraag1 = new Aanvraag();
                    aanvraag1.Id = Convert.ToInt32(lblId.Text);
                    GebruiksLog gebruiksLog1 = new GebruiksLog();
                    gebruiksLog1.Gebruiker = Program.Gebruiker;
                    gebruiksLog1.TijdstipActie = DateTime.Now;
                    gebruiksLog1.OmschrijvingActie = "Aanvraag " + aanvraag1.Id + " werd verwijderd door Gebruiker " + Program.Gebruiker.ToString();
              
                    GebruiksLogManager.SaveGebruiksLog(gebruiksLog1, true);
                }
                else
                {
                    MessageBox.Show("Je kunt deze aanvraag niet verwijderen.", "Geen Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void lblFinancieringsjaar_Click(object sender, EventArgs e)
        {
        }
        private void lblTitel_Click(object sender, EventArgs e)
        {
        }
        private void lblStatusAanvraag_Click(object sender, EventArgs e)
        {
        }
        private void lblPlaningsDatum_Click(object sender, EventArgs e)
        {
        }
        private void lblKostenplaats_Click(object sender, EventArgs e)
        {
        }
        private void lblAanvraagmoment_Click(object sender, EventArgs e)
        {
        }
    }
}
