using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class GemeenteManager
    {
        public static string ConnectionString { get; set; }

        public static List<Gemeente> GetGemeentenByLandId(int landId)
        {
            List<Gemeente> lijst = new List<Gemeente>();

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Postcode, Naam, LandId FROM Gemeente WHERE LandId = @LandId ORDER BY Postcode";

                cmd.Parameters.AddWithValue("@LandId", landId);

                cn.Open();
                SqlDataReader ObjRea = cmd.ExecuteReader();

                while (ObjRea.Read())
                {
                    Gemeente g = new Gemeente();
                    g.Id = Convert.ToInt32(ObjRea["Id"]);
                    g.Postcode = Convert.ToInt32(ObjRea["Postcode"].ToString());
                    g.Naam = ObjRea["Naam"].ToString();
                    g.LandId = Convert.ToInt32(ObjRea["LandId"]);
                    lijst.Add(g);
                }
            }

            return lijst;
        }

        public static Gemeente GetGemeenteById(int gemeenteId)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Postcode, Naam, LandId FROM Gemeente WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", gemeenteId);

                cn.Open();
                SqlDataReader ObjRea = cmd.ExecuteReader();

                if (ObjRea.Read())
                {
                    Gemeente g = new Gemeente();
                    g.Id = Convert.ToInt32(ObjRea["Id"]);
                    g.Postcode = Convert.ToInt32(ObjRea["Postcode"].ToString());
                    g.Naam = ObjRea["Naam"].ToString();
                    g.LandId = Convert.ToInt32(ObjRea["LandId"]);
                    return g;
                }
            }
            return null;
        }
    }
}
