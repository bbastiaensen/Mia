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
    }
}
