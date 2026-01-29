using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class StatusAankoopManager
    {
        public static string ConnectionString { get; set; }

        public static StatusAankoop GetStatusAankoopById(int id)
        {
            StatusAankoop Statusaankoop = new StatusAankoop();

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {

                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from StatusAankoop where Id = @Id;";
                    objCmd.Parameters.AddWithValue("@Id", id);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    if (objRea.Read())
                    {
                        if (objRea["Id"] != DBNull.Value)
                        {
                            Statusaankoop.Id = Convert.ToInt32(objRea["Id"]);
                        }

                        if (objRea["Naam"] != DBNull.Value)
                        {
                            Statusaankoop.Naam = objRea["Naam"].ToString();
                        }
                    }

                }
            }
            return Statusaankoop;
        }
    }
}
