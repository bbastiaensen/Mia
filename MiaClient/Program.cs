using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    internal static class Program
    {
        //Globale variabelen die gebruikt worden in de volledige toepassing
        public static string Gebruiker { get; set; }
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

            string gebruikersnaam = Environment.UserName; //haalt de lokale gebruikersnaam op
            Gebruiker IsExisting = GebruikerManager.GetGebruikerByGebruikersnaam(gebruikersnaam);//Kijkt of de gebruiker bestaat in de gebruikermanager

            if (IsExisting != null)
            {
                Gebruiker = IsExisting.Gebruikersnaam; //als hij bestaat ( of != null is) slaagt het op in Gebruiker
            }

            else
            {
                Gebruiker NieuweGebruiker = new Gebruiker();
                NieuweGebruiker.Gebruikersnaam = gebruikersnaam; //Als die niet bestaat word die aangemaakt

                GebruikerManager.SaveGebruiker(NieuweGebruiker, true);

                Gebruiker = NieuweGebruiker.Gebruikersnaam;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mdiMia());
        }


    }
}
