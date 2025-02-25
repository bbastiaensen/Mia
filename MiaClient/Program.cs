using MiaLogic.Manager;
using MiaLogic.Object;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiaClient
{
    internal static class Program
    {
        //De globale variabelen
        public static string Gebruiker { get; set; }
        public static bool IsAanvrager { get; set; }
        public static bool IsAankoper { get; set; }
        public static bool IsGoedkeurder { get; set; }
        public static bool IsSysteem { get; set; }

        [STAThread]
        static void Main()
        {
            try
            {
                InitializeConnections();
                AuthenticateUser();
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
                System.Windows.Forms.Application.Run(new mdiMia());

            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "Main");
            }
        }
        private static void InitializeConnections()
        {
            try
            {
                //Leg de connectie met de databank, dit deelprobleem wordt in de main opnieuw opgeroepen
                GebruikerManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                RolManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                GebruiksLogManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                ParameterManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                PrioriteitManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                FinancieringenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                FinancieringsjaarManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                DienstenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                AfdelingenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                InvesteringenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                AanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                AankoperManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                KostenplaatsManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                LinkManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                OfferteManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                FotoManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                StatusAanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                ParameterManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                RichtperiodeManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                AankoopManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            }

            catch (SqlException ex)
            {

                ErrorHandler(ex, "InitializeConnections");
            }
        }
        private static void ErrorHandler(Exception ex, string location)
        {
            MessageBox.Show($"Error: {ex.Message} in {location}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool IsGeldigBedrag(char c)
        {
            bool isValid = true;

            if ((int)c < 48 || (int)c > 57)
            {
                if ((int)c != 8 && (int)c != 44)
                {
                    isValid = false;
                }
            }

            return isValid;
        }
        public static string IsMaxBedragStuk(string p, decimal x)
        {
            decimal MaxBedragStuk = Convert.ToDecimal(ParameterManager.GetParameterByCode("MaxBedragStuk").Waarde);
            if (decimal.TryParse(p, out x) && x != 0 && x <= MaxBedragStuk)
            {
                return p;
            }
            else 
            {
                return p = MaxBedragStuk.ToString();
            }
        }
        private static void AuthenticateUser()
        {
            try
            {
                string gebruikersnaam = Environment.UserName;//Haalt de windows gebruikersnaam op
                Gebruiker gebruiker = GebruikerManager.GetGebruikerByGebruikersnaam(gebruikersnaam);

                if (gebruiker != null)//Zoekt of de gebruiker bestaat
                {
                    Gebruiker = gebruiker.Gebruikersnaam;

                    if (gebruiker.IsActief == true)//als de gebruiker al bestaat : kijk volgende comment
                    {
                        SetUserRoles(gebruiker);//legt de rollen van de gebruiker
                    }
                    else
                    {
                        HandleInactiveUser(gebruikersnaam);//Als deze inactief roept het het deelprobleem op voor inactieve gebruikers
                    }
                }
                else
                {
                    CreateNewUser(gebruikersnaam);//Als de gebruiker nog niet bestaat roept het het deelprobleem op om een nieuwe gebruiker aan te maken
                }
            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "AuthenticateUser");

            }
        }
        private static void SetUserRoles(Gebruiker gebruiker)
        {
            try
            {
                List<Rol> rollenVanGebruiker = RolManager.GetRollenByUser(gebruiker);

                if (rollenVanGebruiker.Count > 0)//Als de gebruiker meer als 0 rollen heeft
                {
                    foreach (var rol in rollenVanGebruiker)
                    {
                        switch (rol.Naam)//Deze cycled door de rollen en kijkt of de gebruiker ze heeft, als dat zo is wordt de rol op true gezet
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

            }
            catch (Exception ex)
            { ErrorHandler(ex, "SetUserRoles"); }
        }
        private static void HandleInactiveUser(string gebruikersnaam)
        {
            try
            {
                MessageBox.Show("U bent niet gerechtigd voor deze toepassing !", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GebruiksLogManager.SaveGebruiksLog(new GebruiksLog //er wordt een log aangemaakt wanneer de gebruiker probeert in te loggen
                {
                    Gebruiker = Program.Gebruiker,
                    TijdstipActie = DateTime.Now,
                    OmschrijvingActie = $"De niet-actieve gebruiker: {Gebruiker} probeerde aan te melden."
                }, true);
                Environment.Exit(0);//het programma wordt afgesloten
            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "HandleInactiveUser");

            }
        }
        private static void CreateNewUser(string gebruikersnaam)
        {
            try
            {
                Gebruiker nieuweGebruiker = new Gebruiker { Gebruikersnaam = gebruikersnaam }; //De naam van de nnieuwe gebruiker wordt de windows naam
                GebruikerManager.SaveGebruiker(nieuweGebruiker, true); //de gebruiker wordt aangemaakt en IsActive wordt op true gezet

                Gebruiker = nieuweGebruiker.Gebruikersnaam; //De gebruikersnaam wordt in een nieuwe variable gezet

                nieuweGebruiker = GebruikerManager.GetGebruikerByGebruikersnaam(nieuweGebruiker.Gebruikersnaam); //De gebruiker wordt gezocht in de databank

                Rol aanvragerRol = RolManager.GetRolByName("Aanvrager"); //De rol wordt uit de databank gezocht

                if (aanvragerRol != null)
                {
                    IsAanvrager = true;

                    //Het deelprobleem wordt opgeroepen om de rol aan de gebruiker te geven
                    RolManager.SaveRolToGebruiker(aanvragerRol, nieuweGebruiker);
                }
                Rol SysteemRol = RolManager.GetRolByName("Systeem");
                GebruiksLogManager.SaveGebruiksLog(new GebruiksLog //er wordt een log aangemaakt wanneer de gebruiker probeert in te loggen
                {
                    Gebruiker = Program.Gebruiker,
                    TijdstipActie = DateTime.Now,
                    OmschrijvingActie = $"Gebruiker {Gebruiker} werd aangemaakt door het Systeem."

                }, true);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in CreateNewUser : {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
