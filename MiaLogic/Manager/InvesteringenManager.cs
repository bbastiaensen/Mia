using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MiaLogic.Manager
{
    public class InvesteringenManager
    {
        public static string ConnectionString { get; set; }

        public static List<Investering> GetInvesteringen()
        {
            List<Investering> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT Id, Naam, Actief FROM InvesteringsType ORDER BY Naam";

                    objCn.Open();
                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Investering inv;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Investering>();
                        }

                        inv = new Investering();
                        inv.Id = Convert.ToInt32(objRea["Id"]);
                        inv.Naam = objRea["Naam"].ToString();
                        inv.Actief = Convert.ToBoolean(objRea["Actief"]);

                        returnlist.Add(inv);
                    }
                }
            }
            return returnlist;
        }

        public static List<Investering> GetActiveInvesteringen()
        {
            List<Investering> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT Id, Naam, Actief FROM InvesteringsType WHERE Actief = 1 ORDER BY Naam";

                    objCn.Open();
                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Investering inv;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Investering>();
                        }

                        inv = new Investering();
                        inv.Id = Convert.ToInt32(objRea["Id"]);
                        inv.Naam = objRea["Naam"].ToString();
                        inv.Actief = Convert.ToBoolean(objRea["Actief"]);

                        returnlist.Add(inv);
                    }
                }
            }
            return returnlist;
        }

        public static int SaveInvestering(Investering investering, bool isnew)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    if (isnew)
                    {
                        objCmd.CommandText = "insert into InvesteringsType(Naam, Actief) ";
                        objCmd.CommandText += "values(@Naam, @Actief);";
                    }
                    else
                    {
                        objCmd.CommandText = "update InvesteringsType set Naam = @Naam, ";
                        objCmd.CommandText += "Actief = @Actief where Id = @Id";
                        objCmd.Parameters.AddWithValue("@Id", investering.Id);
                    }

                    objCmd.Parameters.AddWithValue("@Naam", investering.Naam);
                    objCmd.Parameters.AddWithValue("@Actief", investering.Actief);

                    objCn.Open();
                    objCmd.ExecuteNonQuery();

                    if (isnew)
                    {
                        return GetHighestId();
                    }
                    else
                    {
                        return investering.Id;
                    }
                }
            }
        }

        public static void DeleteInvestering(Investering investering)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    objCmd.CommandText = "delete from InvesteringsType ";
                    objCmd.CommandText += "where Id = @Id;";

                    objCmd.Parameters.AddWithValue("@Id", investering.Id);

                    objCn.Open();
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        private static int GetHighestId()
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select max(Id) as Highest from InvesteringsType";

                    objCn.Open();
                    SqlDataReader objRea = objCmd.ExecuteReader();

                    if (objRea.Read())
                    {
                        return Convert.ToInt32(objRea["Highest"]);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
