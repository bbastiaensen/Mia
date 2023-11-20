using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public static class GebruikerManager
    {
        public static string ConnectionString { get; set; }

        public static List<Gebruiker> GetGebruikerByGebruikersnaam(string gebruikersnaam)
        {
            List<Gebruiker> GebruikerByGebruikersnaam = new List<Gebruiker>(); 

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT * FROM Gebruiker WHERE Gebruikersnaam = @Gebruikersnaam";
                    objCmd.Parameters.AddWithValue("@Gebruikersnaam", gebruikersnaam); 

                    objCn.Open();

                    SqlDataReader reader = objCmd.ExecuteReader();

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

            return GebruikerByGebruikersnaam; 
        }
    }
}
