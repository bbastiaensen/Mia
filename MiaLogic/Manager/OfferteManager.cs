using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class OfferteManager
    {
        public static string ConnectionString { get; set; }

        public static List<Offerte> GetOffertes()
        {
            List<Offerte> offertes = new List<Offerte>();

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    objcmd.CommandText = "Select * from Offerte order by Id asc;";

                    objcn.Open();

                    SqlDataReader reader = objcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Offerte offerte = new Offerte();
                        offerte.Id = Convert.ToInt32(reader["Id"]);
                        offerte.Titel = reader["Titel"].ToString();
                        offerte.AanvraagId = Convert.ToInt32(reader["AanvraagID"]);
                        offerte.Url = reader["Url"].ToString();
                        offertes.Add(offerte);
                    }
                }
            }
            return offertes;
        }


        public static List<Offerte> GetOfferteById(int id)
        {
            List<Offerte> offertes = new List<Offerte>();

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;

                    objcmd.CommandText = "select Id,Titel ,AanvraagID, Url from Offerte WHERE Id = @Id;";
                    objcmd.Parameters.AddWithValue("@Id", id);

                    objcn.Open(); //Open de connectie met de databank

                    SqlDataReader reader = objcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Offerte offerte = new Offerte();
                        offerte.Id = Convert.ToInt32(reader["Id"]);
                        offerte.Titel = reader["Titel"].ToString();
                        offerte.AanvraagId = Convert.ToInt32(reader["AanvraagID"]);
                        offerte.Url = reader["Url"].ToString();
                        offertes.Add(offerte); //Voeg rollen toe aan de lijst voor de specifieke gebruiker
                    }
                }
                return offertes;
            }
        }
        public static void SaveOfferte(Offerte offerte, bool insert)
        {
            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;
                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    objcmd.CommandType = CommandType.Text;
                    if (insert)
                    {
                        objcmd.CommandText = "insert into Offerte (AanvraagID, Url, Titel) VALUES (@AanvraagId, @Url,@Titel)";
                    }
                    else
                    {
                        objcmd.CommandText = "UPDATE Offerte SET Url = @Url, Titel = @Titel WHERE AanvraagID = @AanvraagId";
                    }


                    objcmd.Parameters.AddWithValue("@AanvraagId", offerte.AanvraagId);
                    objcmd.Parameters.AddWithValue("@Url", offerte.Url);
                    objcmd.Parameters.AddWithValue("@Titel", offerte.Titel);
                    try
                    {
                        objcn.Open();
                        objcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {


                    }
                }
            }
        }

        public static void DeleteOfferte(Offerte offerte)
        {
            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;

                    objcmd.CommandText = "delete from Offerte WHERE Id = @Id;";
                    objcmd.Parameters.AddWithValue("@Id", offerte.Id);

                    objcn.Open();
                    objcmd.ExecuteNonQuery();
                }
            }
        }
    }
}
