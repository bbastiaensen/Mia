using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiaClient
{
    internal static class Program
    {
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
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mdiMia());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void InitializeConnections()
        {
            try
            {


                GebruikerManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                RolManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
                GebruiksLogManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            }

            catch (SqlException ex)
            {

                MessageBox.Show($"Error, {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void AuthenticateUser()
        {
            try
            {



                string gebruikersnaam = Environment.UserName;
                Gebruiker gebruiker = GebruikerManager.GetGebruikerByGebruikersnaam(gebruikersnaam);

                if (gebruiker != null)
                {
                    Gebruiker = gebruiker.Gebruikersnaam;

                    if (gebruiker.IsActief)
                    {
                        SetUserRoles(gebruiker);
                    }
                    else
                    {
                        HandleInactiveUser(gebruikersnaam);
                    }
                }
                else
                {
                    CreateNewUser(gebruikersnaam);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout gebeurt in Authenticate user :{ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private static void SetUserRoles(Gebruiker gebruiker)
        {
            try
            {
                List<Rol> rollenVanGebruiker = RolManager.GetRollenByUser(gebruiker);

                if (rollenVanGebruiker.Count > 0)
                {
                    foreach (var rol in rollenVanGebruiker)
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
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Error in SetuserRoles : {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private static void HandleInactiveUser(string gebruikersnaam)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error in HandleInactiveUser : {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private static void CreateNewUser(string gebruikersnaam)
        {
            try
            {
                Gebruiker nieuweGebruiker = new Gebruiker { Gebruikersnaam = gebruikersnaam };
                GebruikerManager.SaveGebruiker(nieuweGebruiker, true);

                Gebruiker = nieuweGebruiker.Gebruikersnaam;

                Rol aanvragerRol = RolManager.GetRolByName("Aanvrager");

                if (aanvragerRol != null)
                {
                    IsAanvrager = true;

                    // Use SaveRolToGebruiker to associate the role with the new user
                    RolManager.SaveRolToGebruiker(aanvragerRol, nieuweGebruiker);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in CreateNewUser : {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
