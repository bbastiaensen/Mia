using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class FinancieringenManager
    {
        public static string ConnectionString { get; set; }
        public static List<Financiering> GetFinancieringen()
        {
            List<Financiering> financieringen = new List<Financiering>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Actief, Naam FROM FinancieringsType ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Financiering financiering = new Financiering
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString(),
                                Actief = Convert.ToBoolean(reader["Actief"])
                            };

                            financieringen.Add(financiering);
                        }
                    }
                }
            }
            return financieringen;
        }

        public static void DeactiveerFinanciering(int id)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE FinancieringsType SET Actief = 0 WHERE Id = @Id", cn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }


       

        public static List<Financiering> GetActieveFinancieringen()
        {
            List<Financiering> financieringen = new List<Financiering>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Naam, Actief FROM FinancieringsType WHERE Actief = 1 ORDER BY Naam";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        financieringen.Add(new Financiering
                        {
                            Id = (int)reader["Id"],
                            Naam = reader["Naam"].ToString(),
                            Actief = (bool)reader["Actief"]
                        });
                    }
                }
            }
            return financieringen;
        }

        public static int SaveFinancieringType(Financiering financiering, bool isnew)
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
                        objCmd.CommandText = "insert into FinancieringsType(naam, Actief)";
                        objCmd.CommandText += "values(@Naam , @Actief);";

                    }
                    else
                    {

                        objCmd.CommandText = "update FinancieringsType set naam = @Naam, ";
                        objCmd.CommandText += "Actief = @Actief where Id = @Id";
                        objCmd.Parameters.AddWithValue("@Id", financiering.Id);
                    }
                    objCmd.Parameters.AddWithValue("@Naam", financiering.Naam);

                    objCmd.Parameters.AddWithValue("@Actief", financiering.Actief);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                    if (isnew)
                    {
                        return GetHighestFinancierID();
                    }
                    else
                    {
                        return financiering.Id;
                    }

                }
            }
        }

        private static int GetHighestFinancierID()
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select max(Id) as Highest from FinancieringsType";


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

        public static bool IsFinancieringGebruikt(int financieringsTypeId)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM Aanvraag WHERE FinancieringsTypeId = @Id", cn))
            {
                cmd.Parameters.AddWithValue("@Id", financieringsTypeId);
                cn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }


        public static void DeleteFinancier(Financiering financiering)
        {
            using (SqlConnection objCn = new SqlConnection(ConnectionString))
            using (SqlCommand objCmd = new SqlCommand(
                "UPDATE FinancieringsType SET Actief = 0 WHERE Id = @Id", objCn))
            {
                objCmd.Parameters.AddWithValue("@Id", financiering.Id);
                objCn.Open();
                objCmd.ExecuteNonQuery();
            }
            //    using (SqlConnection objCn = new SqlConnection())
            //    {
            //        objCn.ConnectionString = ConnectionString;

            //        using (SqlCommand objCmd = new SqlCommand())
            //        {
            //            objCmd.Connection = objCn;

            //            objCmd.CommandText = "UPDATE FinancieringsType SET Actief = 0 WHERE Id = @Id";

            //            objCmd.CommandText += "where Id = @Id;";

            //            objCmd.Parameters.AddWithValue("@Id", financiering.Id);

            //            objCn.Open();

            //            objCmd.ExecuteNonQuery();
            //        }
            //    }
            //}
        }
    }
}
