using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class RolManager
    {
        public static string ConnectionString { get; set; } // Connection met databank leggen

        public static List<Rol> GetRollen()
        {
            List<Rol> rollen = new List<Rol>();//List om de rollen op te slaan

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;//Leg de connection string

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    objcmd.CommandText = "Select * from Rol;";//Een query dat alle rollen ophaald

                    objcn.Open(); //Open de verbinding met de databank

                    SqlDataReader reader = objcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Rol rol = new Rol();
                        rol.Id = Convert.ToInt32(reader["Id"]);
                        rol.Naam = reader["Naam"].ToString();
                        rollen.Add(rol); //Voeg de rollen to aan de lijst
                    }
                }
            }
            return rollen; // Returnt de list met rollen
        }

        public static List<Rol> GetRollenByUser(Gebruiker gebruiker)
        {
            List<Rol> rollen = new List<Rol>(); //List om de rollen van een specifieke gebruiker op te slaan

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString; //Leg de connectionstring

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    //query om rollen voor een specifieke gebruiker op te halen op basis van gebruikers-id
                    objcmd.CommandText = "select * from Rol r" + " inner join GebruikerRol Gr on r.Id = Gr.RolId" + " where Gr.gebruikerId = @gebruikerId;";
                    objcmd.Parameters.AddWithValue("@gebruikerId", gebruiker.Id);

                    objcn.Open(); //Open de connectie met de databank

                    SqlDataReader reader = objcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Rol rol = new Rol();
                        rol.Id = Convert.ToInt32(reader["Id"]);
                        rol.Naam = reader["Naam"].ToString();
                        rollen.Add(rol); //Voeg rollen toe aan de lijst voor de specifieke gebruiker
                    }
                }
                return rollen; //returnt de rollen
            }
        }

        public static void SaveRolToGebruiker(Rol rol, Gebruiker gebruiker)
        {
            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString; //Initialiseer de connectionstring

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    //query om een rol voor een specifieke gebruiker in de GebruikerRol-tabel in te voegen
                    objcmd.CommandText = "insert into GebruikerRol (GebruikerId, RolId) values(@gebruikerId, @rolId); ";
                    objcmd.Parameters.AddWithValue("@gebruikerId", gebruiker.Id);
                    objcmd.Parameters.AddWithValue("@rolId", rol.Id);

                    objcn.Open();//Open de connectie met de databank
                    objcmd.ExecuteNonQuery();//Voer de query uit
                }
            }



        }

    }
}
