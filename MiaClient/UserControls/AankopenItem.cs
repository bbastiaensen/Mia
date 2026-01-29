using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    public partial class AankopenItem : UserControl
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public decimal Totaal { get; set; }
        public string Gebruiker { get; set; }
        public decimal PrijsIndicatieStuk { get; set; }
        public int AantalStuk { get; set; }
        public int RichtperiodeId { get; set; }
        public string Financieringsjaar { get; set; }

        private Label lblBudgetToegekend;


        private Aanvraag _aanvraag;

        public Boolean Even { get; set; }
        public Richtperiode R { get; set; }

        public event EventHandler AanvraagDeleted;

        public event EventHandler AanvraagItemSelected;

        public event EventHandler AanvraagItemChanged;
        //frmAankoop frmAankoop;
        public AankopenItem()
        {
            InitializeComponent();

         
          
        }
        public void BindAanvraag(Aanvraag aanvraag, bool evenRow = false)
        {
            if (aanvraag == null)
                throw new ArgumentNullException(nameof(aanvraag));

            _aanvraag = aanvraag;
            Even = evenRow;

            // Vul de properties van de control (optioneel, kan ook alleen in SetItemValue)
            Id = aanvraag.Id;
            Titel = aanvraag.Titel;
            Gebruiker = aanvraag.Gebruiker;
            PrijsIndicatieStuk = aanvraag.PrijsIndicatieStuk;
            AantalStuk = aanvraag.AantalStuk;
            Totaal = PrijsIndicatieStuk * AantalStuk;
            Financieringsjaar = aanvraag.Financieringsjaar;

            R = RichtperiodeManager.GetRichtperiodeById(aanvraag.RichtperiodeId);

            // Update de UI
            SetItemValue();
        }
        public AankopenItem(int id, string titel, string gebruiker, string financieringsjaar, decimal p_ind_stuk, int aantals, Boolean even, int richtId)
        {
            InitializeComponent();
            Id = id;
            Titel = titel;
            PrijsIndicatieStuk = p_ind_stuk;
            AantalStuk = aantals;
            Totaal = PrijsIndicatieStuk * AantalStuk;
            Gebruiker = gebruiker;
            Financieringsjaar = financieringsjaar;
            Even = even;
            RichtperiodeId = richtId;

            


            Richtperiode r = RichtperiodeManager.GetRichtperiodeById(richtId);
            R = r;
            R.Naam = r.Naam;
            R.Sorteervolgorde = r.Sorteervolgorde;
            SetItemValue();
        }



       

        private void SetItemValue()
        {
            lblAanvrager.Text = Gebruiker.ToString();

            //Limiteren van het aantal characters er in de titel komen te staan

      
            var characters = Titel.ToCharArray();
            if (characters.Length > 20)
            {
                string chars = "";
                string combochars = "";

                for (int i = 0; i < 17; i++)
                {
                    chars = characters[i].ToString();
                    combochars = combochars + chars;
                }
                combochars = combochars + "...";
                lblTitel.Text = combochars;
            }
            else
            {
                lblTitel.Text = Titel.ToString();
            }

            lblTotaalBedrag.Text = Totaal.ToString("c", CultureInfo.CurrentCulture);
            lblRichtperiode.Text = R.Naam;
            if (Even)
            {
                this.BackColor = StyleParameters.ListItemColor;
            }
            else
            {
                this.BackColor = StyleParameters.AltListItemColor;
            }

            // --- LOCATIES PER REGEL INSTELLEN (vanaf X = 0) ---
            int startX = 0;       // begin links
            int yPos = 2;         // hoogte van de regel
            int step = 150;       // afstand tussen velden (pas aan afhankelijk van breedte)

            lblTitel.Location = new Point(startX, yPos);

            lblTotaalBedrag.Location = new Point(140, yPos);

            lblAanvrager.Location = new Point(300, yPos);
            //lblFinancieringsjaar.Location = new Point(startX + step * 2, yPos);



            lblRichtperiode.Location = new Point(500, yPos);
            lblFinancieringsjaar.Text = Financieringsjaar; 
            lblFinancieringsjaar.Location = new Point(630, yPos);


            //if (aanvraag == null) throw new ArgumentNullException(nameof(aanvraag));

            //_aanvraag = aanvraag;


            //lblAanvraagStatus.Text = aanvraag.StatusAanvraag;


            //lblAanvraagStatus.Text = AanvraagManager.GetStatusAanvraagDesc() + "";


            if (_aanvraag != null)
            {
                lblAanvraagStatus.Text = _aanvraag.StatusAanvraag;
                lblAanvraagStatus.Location = new Point(830, yPos);
                lblBudgetToegekend.Text = _aanvraag.BudgetToegekend.ToString("c", CultureInfo.CurrentCulture);
                lblBudgetToegekend.Location = new Point( 930 , yPos);
            }
  
        




        }
    }
}
