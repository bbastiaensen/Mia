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
        }
    }
}

