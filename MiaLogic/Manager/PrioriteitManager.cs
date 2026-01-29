using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class PrioriteitManager
    {
        public static string ConnectionString { get; set; }
        public static List<Prioriteit>  GetPrioriteiten()
        {
            List<Prioriteit> prioriteiten = new List<Prioriteit>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Actief, Naam FROM Prioriteit ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Prioriteit prioriteit = new Prioriteit
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString(),
                                actief = Convert.ToBoolean(reader["Actief"])
                               
                            };

                            prioriteiten.Add(prioriteit);
                        }
                    }
                }
            }

            return prioriteiten;
        }
        public static List<Prioriteit> GetActivePrioriteiten()
        {
            List<Prioriteit> prioriteiten = new List<Prioriteit>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id,Actief, Naam FROM Prioriteit where actief = 1 ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Prioriteit prioriteit = new Prioriteit
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString(),
                                actief = Convert.ToBoolean(reader["Actief"])
                            };

                            prioriteiten.Add(prioriteit);
                        }
                    }
                }
            }

            return prioriteiten;
        }
        public static Prioriteit GetPrioriteitById(int id)
        {
            Prioriteit prioriteit = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Naam FROM Prioriteit WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                prioriteit = new Prioriteit
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
                Console.WriteLine("Het systeem kon de Prioriteit niet vinden, probeer het nog eens.");
                throw;
            }

            return prioriteit;
        }
    
        public static int SavePrioriteit(Prioriteit prioriteit, bool isnew)
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
                        objCmd.CommandText = "insert into Prioriteit(Naam, Actief)";
                        objCmd.CommandText += "values( @Naam , @Actief);";

                    }
                    else
                    {

                        objCmd.CommandText = "update Prioriteit set Naam = @Naam, ";
                        objCmd.CommandText += " Actief = @Actief where Id = @Id";
                        objCmd.Parameters.AddWithValue("@Id", prioriteit.Id);
                    }
                    objCmd.Parameters.AddWithValue("@Naam", prioriteit.Naam);
                    
                    objCmd.Parameters.AddWithValue("@Actief", prioriteit.actief);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                    if (isnew)
                    {
                        return GetHighestPrioriteitID();
                    }
                    else
                    {
                        return prioriteit.Id;
                    }

                }
            }
        }
        private static int GetHighestPrioriteitID()
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select max(Id) as Highest from Prioriteit";


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
        public static void DeletePrioriteit(Prioriteit prioriteit)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    objCmd.CommandText = "delete from Prioriteit ";
                    objCmd.CommandText += "where Id = @Id;";

                    objCmd.Parameters.AddWithValue("@Id", prioriteit.Id);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }
        }   
        public static bool CheckPrioriteitInUse(int  PrioriteitId)
        {
            using (SqlConnection objCn = new SqlConnection(ConnectionString))
            using (SqlCommand objCmd = new SqlCommand(
                "SELECT COUNT(*) FROM Aanvraag WHERE PrioriteitId = @Id", objCn))
            {
                objCmd.Parameters.AddWithValue("@Id", PrioriteitId);
                objCn.Open();
                return (int)objCmd.ExecuteScalar() > 0;
            }
        }
        public static void DeactivatePrioriteit(Prioriteit prioriteit) 
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;
                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "update Prioriteit set Actief = 0 ";
                    objCmd.CommandText += "where Id = @Id;";
                    objCmd.Parameters.AddWithValue("@Id", prioriteit.Id);
                    objCn.Open();
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        
    }
}
