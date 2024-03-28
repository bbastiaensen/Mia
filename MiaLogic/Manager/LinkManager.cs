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
    public class LinkManager
    {
        public static string ConnectionString { get; set; }

        public static List<Link> GetLinken()
        {
            List<Link> linken = new List<Link>();

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    objcmd.CommandText = "Select * from Linken order by Id asc;";

                    objcn.Open();

                    SqlDataReader reader = objcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Link link = new Link();
                        link.Id = Convert.ToInt32(reader["Id"]);
                        link.Titel = reader["Titel"].ToString();
                        link.AanvraagId = Convert.ToInt32(reader["AanvraagID"]);
                        link.Url = reader["Url"].ToString();
                        linken.Add(link);
                    }
                }
            }
            return linken;
        }
        public static void SaveLinken(Link link, bool insert)
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
                            objcmd.CommandText = "insert into Linken (AanvraagID, Url, Titel) VALUES (@AanvraagID, @Url, @Titel)";
                        }
                        else
                        {
                            objcmd.CommandText = "Update Linken set AanvraagID = @AanvraagID, Url = @Url, Titel = @Titel where Id = @Id";
                        }


                        objcmd.Parameters.AddWithValue("@AanvraagID", link.AanvraagId);
                        objcmd.Parameters.AddWithValue("@Url", link.Url);
                        objcmd.Parameters.AddWithValue("@Titel", link.Titel);
                        objcmd.Parameters.AddWithValue("@Id", link.Id);

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



        public static List<Link> GetLinkenById(int id)
        {
            List<Link> linken = new List<Link>();

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;

                    objcmd.CommandText = "select Id, AanvraagID, Url, Titel from Linken WHERE Id = @Id;";
                    objcmd.Parameters.AddWithValue("@Id", id);

                    objcn.Open(); //Open de connectie met de databank

                    SqlDataReader reader = objcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Link link = new Link();
                        link.Id = Convert.ToInt32(reader["Id"]);
                        link.Titel = reader["Titel"].ToString();
                        link.AanvraagId = Convert.ToInt32(reader["AanvraagID"]);
                        link.Url = reader["Url"].ToString();
                        linken.Add(link); //Voeg rollen toe aan de lijst voor de specifieke gebruiker
                    }
                }
                return linken;
            }
        }
        public static void DeleteLink(Link link)
        {
            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;

                    objcmd.CommandText = "delete from Linken WHERE Id = @Id;";
                    objcmd.Parameters.AddWithValue("@Id", link.Id);

                    objcn.Open();
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public static int GetHighestLinkId()
        {
            int highestLinkId = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT MAX(Id) AS highest FROM Linken;";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            highestLinkId = Convert.ToInt32(reader["highest"]);
                        }
                    }
                }
            }
            return highestLinkId;
        }

        public static Link GetLinkById(int id)
        {
            Link linken = null;

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;

                    objcmd.CommandText = "select Id, AanvraagID, Url, Titel from Linken WHERE Id = @Id;";
                    objcmd.Parameters.AddWithValue("@Id", id);

                    objcn.Open(); //Open de connectie met de databank

                    SqlDataReader reader = objcmd.ExecuteReader();
                    if (reader.Read())
                    {
                        linken = new Link();
                        linken.Id = Convert.ToInt32(reader["Id"]);
                        linken.Titel = reader["Titel"].ToString();
                        linken.AanvraagId = Convert.ToInt32(reader["AanvraagID"]);
                        linken.Url = reader["Url"].ToString();
                    }
                }
                return linken;
            }
        }
    }
}
