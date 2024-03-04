using MiaLogic.Object;
using System;
using System.Collections.Generic;
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
                        link.AanvraagId = Convert.ToInt32(reader["AanvraagID"]);
                        link.Url = reader["Url"].ToString();
                        linken.Add(link);
                    }
                }
            }
            return linken;
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

                    objcmd.CommandText = "select Id, AanvraagID, Url from Linken WHERE Id = @Id;";
                    objcmd.Parameters.AddWithValue("@Id", id);

                    objcn.Open(); //Open de connectie met de databank

                    SqlDataReader reader = objcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Link link = new Link();
                        link.Id = Convert.ToInt32(reader["Id"]);
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



    }
}
