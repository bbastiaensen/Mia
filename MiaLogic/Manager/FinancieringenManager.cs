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

                string query = "SELECT Id, Naam FROM FinancieringsType ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Financiering financiering = new Financiering
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString()
                            };

                            financieringen.Add(financiering);
                        }
                    }
                }
            }
            return financieringen;
        }
        public static Financiering GetFinancieringById(int id)
        {
            Financiering financieringsType = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Naam FROM FinancieringsType WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                financieringsType = new Financiering
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Naam = reader["Naam"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Het systeem kon de Financiering niet vinden, probeer het nog eens.");
                throw;
            }
            return financieringsType;
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
                
                    objCmd.Parameters.AddWithValue("@Actief", financiering.actief);

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

        public static void DeleteAankoper(Financiering financiering)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    objCmd.CommandText = "delete from FinancieringsType ";
                    objCmd.CommandText += "where Id = @Id;";

                    objCmd.Parameters.AddWithValue("@Id", financiering.Id);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
