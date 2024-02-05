using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmGebruikerBeheer : Form
    {
        List<Gebruiker> gebruikers;

        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;

        public frmGebruikerBeheer()
        {
            InitializeComponent();
            GebruiksLogManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;

        }

        public void BindLstGebruikers()
        {
            //vult de lijst van gebruikers
            gebruikers = GebruikerManager.GetGebruikers();
            LstGebruikers.DisplayMember = "Gebruikersnaam";
            LstGebruikers.ValueMember = "Id";
            LstGebruikers.DataSource = gebruikers;
        }

        /// <summary>
        /// Haalt alle rollen uit de databank op en toont deze op het scherm.
        /// Het instellen van de juiste rollen voor de huidige gebruiker is de
        /// verantwoordelijkheid van een ander stuk code.
        /// </summary>
        private void BindRollen()
        {
            List<Rol> rollen = RolManager.GetRollen();

            Gebruiker gebruiker2 = GebruikerManager.GetGebruikerByGebruikersnaam(gebruiker1.Gebruikersnaam);//haalt de gebruiker op
            bool actief = gebruiker2.IsActief;
            if (actief == true) //checkt of de gebruiker actief is of niet en stelt de checkbox in op het resultaat
            {
                checkActief.Checked = true;
            }

            else
            {
                checkActief.Checked = false;
            }

            int t = 0;

            this.grpRollen.Controls.Clear();

            foreach (Rol rol in rollen)
            {
                CheckBox chk = new CheckBox();
                chk.Location = new System.Drawing.Point(xPos, yPos);
                chk.Name = "chkRol" + rol.Id;
                chk.Text = rol.Naam;
                chk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                chk.Size = new System.Drawing.Size(150, 33);
                chk.TabIndex = t + 8;
                this.grpRollen.Controls.Add(chk);

                //Voorbereiden voor de volgende control
                t++;
                yPos += 30;
                grpHeight += 30;
                this.grpRollen.Size = new System.Drawing.Size(528, grpHeight);

            }
        }


        private void CreateUI()
        {

            //Deel 1 is hard-coded
            //Deel 2 is het tonen van de rollen
            BindRollen();

            //Deel 3 is de "Bewaren" button positioneren en de finale grootte van het formulier instellen.
            int yPosBtn = grpRollen.Location.Y + grpHeight + 10;
            BtnOpslaan.Location = new System.Drawing.Point(177, yPosBtn);

            int frmHeight = yPosBtn + BtnOpslaan.Size.Height + 45;
            this.Size = new System.Drawing.Size(574, frmHeight);
        }

        private void BindRollenToGebruiker(Gebruiker gebruiker)
        {
            //Stap 1 - Eventueel geselecteerde rollen van vorige gebruiker wissen
            List<Rol> rollenlijst = RolManager.GetRollen();
            foreach (Rol rol in rollenlijst)
            {
                CheckBox chkRol = (CheckBox)this.Controls.Find("chkRol" + rol.Id, true).FirstOrDefault();
                chkRol.Checked = false;
                TxtGebruikersnaam.Text = gebruiker2.Gebruikersnaam;
            }
        }
        private void frmGebruikerBeheer_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstGebruikers();

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

            else
                {
                    gebruiker1.IsActief = false;
                }

                GebruikerManager.SaveGebruiker(gebruiker1, false);

                vullijst();
                RadAlle.Checked = true;
                MessageBox.Show($"De gebruiker {gebruiker1} is successvol opgeslagen.");
                GebruiksLog gebruiksLog1 = new GebruiksLog();
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
                GebruikerManager.SaveGebruiker(gebruiker, false);

                //Bewaren van de rollen voor deze gebruiker. In 2 stappen:
                //Eerst alle bestaande rollen verwijderen.
                RolManager.DeleteRollenFromGebruiker(gebruiker);
                //Nadien alle geselecteerde rollen (opnieuw) toevoegen.
                List<Rol> rollenlijst = RolManager.GetRollen();
                foreach (Rol rol in rollenlijst)
                {
                    CheckBox chkRol = (CheckBox)this.Controls.Find("chkRol" + rol.Id, true).FirstOrDefault();
                    if (chkRol.Checked)
                    {
                        RolManager.SaveRolToGebruiker(rol, gebruiker);
                    }
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
                    gebruiksLog1.OmschrijvingActie = "Gebruiker " + gebruiker1.Gebruikersnaam.ToString() + " werd geactiveerd.";
                }

                if (gebruiker.IsActief == false)
                {
                    gebruiksLog1.OmschrijvingActie = "Gebruiker " + gebruiker.Gebruikersnaam.ToString() + " werd gedeactiveerd en/of rollen geupdate.";
                }

                GebruiksLogManager.SaveGebruiksLog(gebruiksLog1, true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGebruikerBeheer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

    }

}

