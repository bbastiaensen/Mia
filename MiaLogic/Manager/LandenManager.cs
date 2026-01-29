using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class LandenManager
    {
        public static string ConnectionString { get; set; }

        public static List<Land> GetLanden()
        {
            List<Land> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT Id,Naam FROM Land ORDER BY Naam ASC";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Land l;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Land>();
                        }

                        l = new Land();
                        l.Id = Convert.ToInt32(objRea["Id"]);
                        l.Naam = objRea["Naam"].ToString();
                     

                        returnlist.Add(l);
                    }
                }
            }
            return returnlist;
        }
        public static int SaveLanden(Land land, bool isnew)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    if (isnew)
                    {
                        //Nieuw
                        objCmd.CommandText = "insert into Land(Naam)";
                        objCmd.CommandText += "values(@Naam);";

                    }
                    else
                    {

                        objCmd.CommandText = "update Land set Naam = @Naam ";
                        objCmd.CommandText += "where Id = @Id";
                        objCmd.Parameters.AddWithValue("@Id", land.Id);
                    }
                    objCmd.Parameters.AddWithValue("@Naam", land.Naam);
             

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                    if (isnew)
                    {
                        return GetHighestLandID();
                    }
                    else
                    {
                        return land.Id;
                    }

                }
            }
        }
        private static int GetHighestLandID()
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select max(Id) as Highest from Land";


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
        public static void DeleteLand(Land land)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    objCmd.CommandText = "delete from Land ";
                    objCmd.CommandText += "where Id = @Id;";

                    objCmd.Parameters.AddWithValue("@Id", land.Id);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
