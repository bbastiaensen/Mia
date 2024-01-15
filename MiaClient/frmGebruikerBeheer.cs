using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiaLogic.Manager;
using MiaLogic.Object;
using System.Configuration;

namespace MiaClient
{
    public partial class frmGebruikerBeheer : Form
    {
        List<Gebruiker> gebruikers;


        public frmGebruikerBeheer()
        {
            InitializeComponent();
            GebruiksLogManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;

        }

        public void vullijst()
        {
            //vult de lijst van gebruikers
            gebruikers = GebruikerManager.GetGebruikers();
            LstGebruikers.DisplayMember = "Gebruikersnaam";
            LstGebruikers.ValueMember = "Id";
            LstGebruikers.DataSource = gebruikers;
        }

        private void LstGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gebruiker gebruiker1 = new Gebruiker();
            Gebruiker gebruiker2 = new Gebruiker();
            gebruiker1 = (Gebruiker)LstGebruikers.SelectedItem;

            
             gebruiker2 = GebruikerManager.GetGebruikerByGebruikersnaam(gebruiker1.Gebruikersnaam);//haalt de gebruiker op
             bool actief = gebruiker2.IsActief;
                if (actief == true) //checkt of de gebruiker actief is of niet en stelt de checkbox in op het resultaat
                {
                    checkActief.Checked = true;
                }

                else
                {
                    checkActief.Checked = false;
                }
             TxtGebruikersnaam.Text = gebruiker1.Gebruikersnaam;
        }

        private void frmGebruikerBeheer_Load(object sender, EventArgs e)
        {
            vullijst();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadNonActief_CheckedChanged(object sender, EventArgs e)
        {
            if (RadNonActief.Checked == true)
            {
                LstGebruikers.DataSource = gebruikers.Where(g => g.IsActief == false).ToList();
            }
        }

        private void RadActief_CheckedChanged(object sender, EventArgs e)
        {
            if (RadActief.Checked == true)
            {
                LstGebruikers.DataSource = gebruikers.Where(g => g.IsActief == true).ToList();
            }
        }

        private void RadAlle_CheckedChanged(object sender, EventArgs e)
        {
            if (RadAlle.Checked == true)
            {
                LstGebruikers.DataSource = gebruikers;
            }
        }
        private void BtnOpslaan_Click(object sender, EventArgs e)
        {
            Gebruiker gebruiker1 = new Gebruiker();
            gebruiker1.Id = Convert.ToInt32(LstGebruikers.SelectedValue);
            gebruiker1.Gebruikersnaam = TxtGebruikersnaam.Text;
            if (checkActief.Checked == true)
            {
                gebruiker1.IsActief = true;
            }

            else
            {
                gebruiker1.IsActief = false;
            }

            GebruikerManager.SaveGebruiker(gebruiker1, false);
            
            vullijst();
            RadAlle.Checked = true;
            MessageBox.Show("Succesvol Bewaart.");
            GebruiksLog gebruiksLog1 = new GebruiksLog();
            gebruiksLog1.Gebruiker = Program.Gebruiker;
            gebruiksLog1.TijdstipActie = DateTime.Now;
            if (gebruiker1.IsActief == true)
            {
                gebruiksLog1.OmschrijvingActie = "Gebruiker "+ gebruiker1.Gebruikersnaam.ToString() +" werd geactiveerd.";
            }

            if (gebruiker1.IsActief == false)
            {
                gebruiksLog1.OmschrijvingActie = "Gebruiker " + gebruiker1.Gebruikersnaam.ToString() + " werd gedeactiveerd.";
            }

            GebruiksLogManager.SaveGebruiksLog(gebruiksLog1, true);
        }

        private void frmGebruikerBeheer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

    }

}
