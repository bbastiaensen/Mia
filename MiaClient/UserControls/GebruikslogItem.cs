﻿using ProofOfConceptDesign;
using System;
using System.Drawing;
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
            if (OmschrijvingActie.Length >= 50)
            {
                lblOmschrijvingActieKort.Text = OmschrijvingActie.Substring(0,50) + "...";
            }
            else
            {
                lblOmschrijvingActieKort.Text = OmschrijvingActie.ToString();   
            }
            if (Even)
            {
                this.BackColor = StyleParameters.ListItemColor;
            }
            else
            {
                this.BackColor = StyleParameters.AltListItemColor;
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
