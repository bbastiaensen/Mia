using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MiaLogic.Manager
{
    public static class GebruikerManager
    {
        public static string ConnectionString { get; set; }

        public static List<Gebruiker> GetGebruikerByGebruikersnaam(string gebruikersnaam)
        {
            //List om gebruikers op te slaan die overeenkomen met de gebruikersnaam
            List<Gebruiker> GebruikerByGebruikersnaam = new List<Gebruiker>();

            using (SqlConnection objCn = new SqlConnection())
            {
                try
                {
                    // Hier leg ik de Connection
                    objCn.ConnectionString = ConnectionString;

                    // Hier implementeer ik de commands om mijn querry's uit te voeren.
                    using (SqlCommand objCmd = new SqlCommand())
                    {
                        objCmd.Connection = objCn;
                        objCmd.CommandText = "SELECT * FROM Gebruiker WHERE Gebruikersnaam = @Gebruikersnaam";

                        // Parameters toevoegen om SQL Injection te voorkomen
                        objCmd.Parameters.AddWithValue("@Gebruikersnaam", gebruikersnaam);

                        //Open de connection
                        objCn.Open();

                        // Gebruik van SqlDataReader om gegevens uit de database te lezen
                        SqlDataReader reader = objCmd.ExecuteReader();

                        // Lezen van de resultaten en toevoegen aan de lijst van gebruikers
                        while (reader.Read())
                        {
                            Gebruiker gebruiker = new Gebruiker
                            {
                                id = Convert.ToInt32(reader["ID"]),
                                Gebruikersnaam = reader["Gebruikersnaam"].ToString(),
                                Actief = Convert.ToBoolean(reader["Actief"])
                            };

                            GebruikerByGebruikersnaam.Add(gebruiker);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Moet nog een manier vinden om fouten op te slaan en op te roepen in het formulier
                    // zodat we deze fout kunnen weergeven aan de gebruiker.

                }
                catch (Exception ex)
                {


                }
            }

            // Retourneer de lijst van gebruikers die overeenkomen met de gebruikersnaam
            return GebruikerByGebruikersnaam;
        }
    }
}
