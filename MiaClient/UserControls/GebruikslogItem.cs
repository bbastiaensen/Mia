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
    public partial class GebruikslogItem : UserControl
    {
        public int Id { get; set; }
        public DateTime TijdstipActie { get; set; }
        public string Gebruiker { get; set; }
        public string OmschrijvingActie { get; set; }

        public Boolean Even { get; set; }

        public event EventHandler GebruiksLogItemSelected;

        public GebruikslogItem()
        {
            InitializeComponent();
        }

        public GebruikslogItem(int id, DateTime tijdstipActie, string gebruiker, string omschrijvingActie, Boolean even)
        {
            InitializeComponent();
            Id = id;
            TijdstipActie = tijdstipActie;
            Gebruiker = gebruiker;
            OmschrijvingActie = omschrijvingActie;
            Even = even;
            SetGebruiksLogItemWaarden();
        }

        private void SetGebruiksLogItemWaarden()
        {
            lblId.Text = Id.ToString();
            lblTijdstipActie.Text = TijdstipActie.ToString();
            lblGebruiker.Text = Gebruiker;
            if (OmschrijvingActie.Length >= 47)
            {
                lblOmschrijvingActieKort.Text = OmschrijvingActie.Substring(0,47) + "...";
            }
            else
            {
                lblOmschrijvingActieKort.Text = OmschrijvingActie.ToString();   
            }
            if (Even)
            {
                this.BackColor = Color.White;
            }
        }

        private void llblDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GebruiksLogItemSelected != null)
            {
                GebruiksLogItemSelected(this, null);
            }
        }
    }
}
