using MiaLogic.Object;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class GebruikerManager
    {
        public static string ConnectionString { get; set; } //Hier wordt de connection met de databank gelegd

        public static List<Gebruiker> GetGebruikers()
        {
            List<Gebruiker> gebruikers = new List<Gebruiker>(); // Een lijst om gebruikersinformatie op te slaan

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString; //Instellen ConnectionString

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    objcmd.CommandText = "Select * from Gebruiker order by Gebruikersnaam asc;"; //Haal alle info van alle gebruikers op

                    objcn.Open(); //Open de connectie met de databank

                    SqlDataReader reader = objcmd.ExecuteReader(); //Lees alle gegevens uit de databank

                    while (reader.Read())
                    {
                        Gebruiker gebruiker = new Gebruiker();
                        gebruiker.Id = Convert.ToInt32(reader["Id"]);
                        gebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                        gebruiker.IsActief = Convert.ToBoolean(reader["Actief"]);
                        gebruikers.Add(gebruiker);//Alle gebruikers toevoegen aan de lijst

                    }

                }
            }
            return gebruikers; //returned de lijst met gebruikers
        }

        public static Gebruiker GetGebruikerByGebruikersnaam(string gebruikersnaam)
        {
            Gebruiker gevondenGebruiker = null; // Initialiseer een variabele voor de gevonden gebruiker

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString; //het leggen van de connectionstring

                using (SqlCommand objcmd = new SqlCommand())
                {

                    objcmd.Connection = objcn;
                    objcmd.CommandText = "select * from Gebruiker where Gebruikersnaam = @gebruikersnaam;"; //query om een gebruiker op te halen op basis van gebruikersnaam
                    objcmd.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);

                    objcn.Open(); //Open de verbinding met de databank

                    SqlDataReader reader = objcmd.ExecuteReader();//lees de gegevens uit de databank

                    while (reader.Read())
                    {
                        gevondenGebruiker = new Gebruiker();
                        gevondenGebruiker.Id = Convert.ToInt32(reader["Id"]);
                        gevondenGebruiker.Gebruikersnaam = reader["Gebruikersnaam"].ToString();
                        gevondenGebruiker.IsActief = Convert.ToBoolean(reader["Actief"]);

                    }
                }
            }
            return gevondenGebruiker; //returned de gevonden gebruiker
        }

        public static void SaveGebruiker(Gebruiker gebruiker, bool insert)
        {
            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString; // leg de connectionstring

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;

                    //OPGELET: momenteel kunnen gebruikersgegevens niet aangepast worden. Als dit wel moet kunnen
                    //moet deze code goed gereviseerd worden.
                    if (insert)
                    {
                        //Alle gebruikers worden nu automatish op actief gezet
                        gebruiker.IsActief = true;

                        objcmd.CommandText = "INSERT INTO Gebruiker (Gebruikersnaam, Actief) VALUES (@gebruikersnaam, @actief);"; // query voor het invoegen van een nieuwe gebruiker

                        objcmd.Parameters.AddWithValue("@gebruikersnaam", gebruiker.Gebruikersnaam);
                        objcmd.Parameters.AddWithValue("@actief", gebruiker.IsActief);

                        objcn.Open(); // open de connectie met de databank
                        objcmd.ExecuteNonQuery(); // Voer de query uit
                    }  
                }
            }
        }




    }
}
