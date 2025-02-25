using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class StatusAanvraagManager
    {
        public static string ConnectionString { get; set; }

        //Geeft een StatusAanvraag terug op basis van een Id
        public static StatusAanvraag GetStatusAanvraagById(int id)
        {
            StatusAanvraag Statusaanvraag = new StatusAanvraag();

            using (SqlConnection objCn = new SqlConnection())
            {

                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {

                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from StatusAanvraag where Id = @Id;";
                    objCmd.Parameters.AddWithValue("@Id", id);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();




                    if (objRea.Read())
                    {
                        if (objRea["Id"] != DBNull.Value )
                        {
                            Statusaanvraag.Id = Convert.ToInt32(objRea["Id"]);
                        }

                        if (objRea["Naam"] != DBNull.Value )
                        {
                            Statusaanvraag.Naam = objRea["Naam"].ToString();
                        }

                    }

                }
            }

            return Statusaanvraag;
        }

        //Geeft een StatusAanvraag terug op basis van een Id
        public static StatusAanvraag GetStatusAanvraagByName(string name)
        {
            StatusAanvraag Statusaanvraag = new StatusAanvraag();

            using (SqlConnection objCn = new SqlConnection())
            {

                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {

                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from StatusAanvraag where Naam = @Naam;";
                    objCmd.Parameters.AddWithValue("@Naam", name);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    if (objRea.Read())
                    {
                        if (objRea["Id"] != DBNull.Value)
                        {
                            Statusaanvraag.Id = Convert.ToInt32(objRea["Id"]);
                        }

                        if (objRea["Naam"] != DBNull.Value)
                        {
                            Statusaanvraag.Naam = objRea["Naam"].ToString();
                        }

                    }

                }
            }

            return Statusaanvraag;
        }

        //geeft alle statussen terug in een list
        public static List<StatusAanvraag> GetStatusAanvragen()
        {
            StatusAanvraag Status = new StatusAanvraag();

            using (SqlConnection objCn = new SqlConnection())
            {

                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {

                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from StatusAanvraag";

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();
                    //nieuwe lege list
                    List<StatusAanvraag> list = null;

                    while (objRea.Read())
                    {
                        // als de lijst niet bestaat, maken we het aan
                        if (list == null)
                        {
                            list = new List<StatusAanvraag>();
                        }
                        StatusAanvraag s = new StatusAanvraag();
                        s.Id = Convert.ToInt32(objRea["Id"]);
                        s.Naam = objRea["Naam"].ToString();

                        list.Add(s);
                    }
                    return list;

                }
            }
        }
    }
}
