using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MiaLogic.Manager
{
    public static class RolManager
    {
        public static string ConnectionString { get; set; }

        public static List<Rol> GetRollenByGebruiker(Rol rol)
        {

            // List om de rol van een gebruiker op te slaan
            List<Rol> RollenByGebruiker = new List<Rol>();


            using (SqlConnection objCn = new SqlConnection())
            {
                try
                {
                    // Hier leg ik de connection string
                    objCn.ConnectionString = ConnectionString;

                    // Hier implementeer ik de commands om mijn querry's uit te voeren ,
                    //Deze moet wrsch nog aangepast worden
                    using (SqlCommand objCmd = new SqlCommand())
                    {
                        objCmd.Connection = objCn;
                        objCmd.CommandText = "SELECT * FROM Rol";

                        // Open Connection
                        objCn.Open();

                        // SqlDataReader om de gegevens uit de database te lezen
                        SqlDataReader reader = objCmd.ExecuteReader();

                        // Lezen van de resultaten en toevoegen aan de lijst van rollen
                        while (reader.Read())
                        {
                            Rol newRol = new Rol
                            {
                                id = Convert.ToInt32(reader["ID"]),
                                Naam = reader["Naam"].ToString()
                            };

                            RollenByGebruiker.Add(newRol);
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

            // return de lijst van de rollen van de gebruiker
            return RollenByGebruiker;
        }
    }
}
