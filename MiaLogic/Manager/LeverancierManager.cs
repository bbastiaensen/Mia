using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class LeverancierManager
    {
        public static string ConnectionString { get; set; }

        public static List<leverancier> GetAllLeveranciers()
        {
            List<leverancier> returnlist = new List<leverancier>();

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = @"SELECT Id, Leverancier, Adres, Website, EMail, GemeenteId FROM Leverancier";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    while (objRea.Read())
                    {
                        leverancier le = new leverancier();
                        le.Id = Convert.ToInt32(objRea["Id"]);
                        le.Leverancier = objRea["Leverancier"].ToString();
                        le.Email = objRea["Email"]?.ToString() ?? string.Empty;
                        le.Adres = objRea["Adres"]?.ToString() ?? string.Empty;
                        le.GemeenteId = Convert.ToInt32(objRea["GemeenteId"]);
                        le.Website = objRea["Website"]?.ToString() ?? string.Empty;

                        returnlist.Add(le);
                    }
                }
            }
            return returnlist;
        }


        public static int SaveLeverancier(leverancier leverancier, bool isnew)
        {
            using (SqlConnection objCn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    if (isnew)
                    {
                        //Nieuw
                        objCmd.CommandText = @"INSERT INTO Leverancier (Leverancier, EMail, Website, Adres, GemeenteId) 
                       VALUES (@Leverancier, @EMail, @Website, @Adres, @GemeenteId)";

                    }
                    else
                    {
                        objCmd.CommandText = "update Leverancier set Leverancier = @Leverancier, EMail = @EMail, Website = @Website, Adres = @Adres, GemeenteId = @GemeenteId WHERE Id = @Id";
                        objCmd.Parameters.AddWithValue("@Id", leverancier.Id);
                    }
                    objCmd.Parameters.AddWithValue("@Leverancier", leverancier.Leverancier);
                    objCmd.Parameters.AddWithValue("@EMail", leverancier.Email);
                    objCmd.Parameters.AddWithValue("@Website", leverancier.Website);
                    objCmd.Parameters.AddWithValue("@Adres", leverancier.Adres);
                    objCmd.Parameters.AddWithValue("@GemeenteId", leverancier.GemeenteId);


                    objCn.Open();
                    objCmd.ExecuteNonQuery();
                    if (isnew)
                    {
                        return GetHighestLeverancierID();
                    }
                    else
                    {
                        return leverancier.Id;
                    }

                }
            }
        }

        private static int GetHighestLeverancierID()
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select max(Id) as Highest from Leverancier";


                    objCn.Open();

                    SqlDataReader ObjRea = objCmd.ExecuteReader();
                    if (ObjRea.Read())
                    {

                        return Convert.ToInt32(ObjRea["Highest"]);

                    }
                    else
                    {
                        return 0;
                    }
                }

            }
        }

        public static List<Land> GetAllLanden()
        {
            List<Land> lijst = new List<Land>();

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Naam FROM Land";

                cn.Open();
                SqlDataReader ObjRea = cmd.ExecuteReader();

                while (ObjRea.Read())
                {
                    Land l = new Land();
                    l.Id = Convert.ToInt32(ObjRea["Id"]);
                    l.Naam = ObjRea["Naam"].ToString();
                    lijst.Add(l);
                }
            }

            return lijst;
        }

        public static List<gemeente> GetGemeentenByLandId(int landId)
        {
            List<gemeente> lijst = new List<gemeente>();

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
                    gemeente g = new gemeente();
                    g.Id = Convert.ToInt32(ObjRea["Id"]);
                    g.Postcode = ObjRea["Postcode"].ToString();
                    g.Naam = ObjRea["Naam"].ToString();
                    g.LandId = Convert.ToInt32(ObjRea["LandId"]);
                    lijst.Add(g);
                }
            }

            return lijst;
        }


        public static void DeleteLeverancier(int leverancierId)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cn;
                cmd.CommandText = "DELETE FROM Leverancier WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", leverancierId);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static gemeente GetGemeenteById(int gemeenteId)
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
                    gemeente g = new gemeente();
                    g.Id = Convert.ToInt32(ObjRea["Id"]);
                    g.Postcode = ObjRea["Postcode"].ToString();
                    g.Naam = ObjRea["Naam"].ToString();
                    g.LandId = Convert.ToInt32(ObjRea["LandId"]);
                    return g;
                }
            }
            return null;
        }




    }
}