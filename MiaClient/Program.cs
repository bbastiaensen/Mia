using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    internal static class Program
    {
        //Globale variabelen die gebruikt worden in de volledige toepassing
        public static string Gebruiker { get; set; }
        public static string Rol { get; set; }
        public static bool IsAanvrager { get; set; }
        public static bool IsAankoper { get; set; }
        public static bool IsGoedkeurder { get; set; }
        public static bool IsSysteem { get; set; }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            GebruikerManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            RolManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            GebruiksLogManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;

            string gebruikersnaam = Environment.UserName; //haalt de lokale gebruikersnaam op

            //Kijkt of de gebruiker bestaat in de gebruikermanager

            Gebruiker gebruiker = GebruikerManager.GetGebruikerByGebruikersnaam(gebruikersnaam);


            if (gebruiker != null)
            {

                Gebruiker = gebruiker.Gebruikersnaam; //als hij bestaat ( of != null is) slaagt het op in Gebruiker

                if (gebruiker.IsActief) //Als IsExisting==True && IsActief == True
                {
                    List<Rol> RollenVanGebruiker = RolManager.GetRollenByUser(gebruiker);

                    if (RollenVanGebruiker.Count > 0)
                    {
                        foreach (var rol in RollenVanGebruiker)
                        {
                            switch (rol.Naam)
                            {
                                case "Aanvrager":
                                    IsAanvrager = true;
                                    break;
                                case "Aankoper":
                                    IsAankoper = true;
                                    break;
                                case "Goedkeurder":
                                    IsGoedkeurder = true;
                                    break;
                                case "Systeem":
                                    IsSysteem = true;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Er is een fout in het behandelen van de rollen per gebruiker");
                    }
                }
                else
                {
                    MessageBox.Show("U bent niet gerechtigd voor deze toepassing !", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = gebruikersnaam,
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Deze niet-actieve gebruiker: {gebruikersnaam} probeerde aan te melden."
                    }, true);
                    Environment.Exit(0);
                }
            }
            else
            {//De nieuwe gebruiker moet nog toegevoegd worden als log
                Gebruiker NieuweGebruiker = new Gebruiker();
                NieuweGebruiker.Gebruikersnaam = gebruikersnaam; //Als die niet bestaat wordt die aangemaakt

                GebruikerManager.SaveGebruiker(NieuweGebruiker, true);

                Gebruiker = NieuweGebruiker.Gebruikersnaam;
                //maak in rolmanager getrolbyname
                Rol aanvragerRol = RolManager.GetRolByName("Aanvrager");

                if (aanvragerRol != null)
                {
                    RolManager.SaveRolToGebruiker(aanvragerRol, NieuweGebruiker);
                    IsAanvrager = true;
                }
                else
                {
                    MessageBox.Show("Er is een fout in het toewijzen van de rol 'Aanvrager' aan de nieuwe gebruiker.");
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mdiMia());
        }
    }
}
