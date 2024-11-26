using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public static class RichtperiodeManager
    {
        public static string ConnectionString { get; set; }

        public static Richtperiode GetRichtperiodeById(int id)
        {
            Richtperiode periode = null;

            using (SqlConnection objCn = new SqlConnection())
            {

                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {

                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from Richtperiode where Id = @Id;";
                    objCmd.Parameters.AddWithValue("@Id", id);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();




                    if (objRea.Read())
                    {

                        periode = new Richtperiode();
                        periode.Id = Convert.ToInt32(objRea["Id"]);
                        periode.Naam = objRea["Naam"].ToString();

                    }

                }
            }
            return periode;
        }
        public static List<Richtperiode> GetRichtperiodes()
        {
            List<Richtperiode> periodes = null;

            using (SqlConnection objCn = new SqlConnection())
            {

                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {

                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select id, naam from Richtperiode order by Sorteervolgorde asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Richtperiode p;

                    while (objRea.Read())
                    {
                        if(periodes == null)
                        {
                            periodes = new List<Richtperiode>();
                        }
                        p = new Richtperiode();
                        p.Id = Convert.ToInt32(objRea["Id"]);
                        p.Naam = objRea["Naam"].ToString();

                        periodes.Add(p);
                    }

                }
            }
            return periodes;
        }
    }
}
