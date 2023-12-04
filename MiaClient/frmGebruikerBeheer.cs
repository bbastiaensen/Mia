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

namespace MiaClient
{
    public partial class frmGebruikerBeheer : Form
    {
        List<Gebruiker> gebruikers;


        public frmGebruikerBeheer()
        {
            InitializeComponent();
        }

        private void LstGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmGebruikerBeheer_Load(object sender, EventArgs e)
        {
            gebruikers = GebruikerManager.GetGebruikers();
            
            LstGebruikers.DisplayMember = "Gebruikersnaam";
            LstGebruikers.ValueMember = "Id";
            LstGebruikers.DataSource = gebruikers;
           




        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadNonActief_CheckedChanged(object sender, EventArgs e)
        {
            if (RadNonActief.Checked == true)
            {
                LstGebruikers.DataSource = gebruikers.Where(g => g.Actief == false).ToList();
            }
        }

        private void RadActief_CheckedChanged(object sender, EventArgs e)
        {
            if (RadActief.Checked == true)
            {
                LstGebruikers.DataSource = gebruikers.Where(g => g.Actief == true).ToList();
            }
        }

        private void RadAlle_CheckedChanged(object sender, EventArgs e)
        {
            if (RadAlle.Checked == true)
            {
                LstGebruikers.DataSource = gebruikers;
            }
        }

        private void BtnPasaan_Click(object sender, EventArgs e)
        {
            BtnOpslaan.Visible = true;
            TxtGebruikersnaam.Text = LstGebruikers.SelectedIndex.ToString();
           Gebruiker gebruiker1 = GebruikerManager.GetGebruikerByGebruikersnaam(TxtGebruikersnaam.Text);
           bool actief = gebruiker1.Actief;
            if (actief == true)
            {
                
            }
        }
    }
}
