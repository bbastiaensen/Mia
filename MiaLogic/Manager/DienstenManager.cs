using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class DienstenManager
    {
        public static string ConnectionString { get; set; }
        public static List<Dienst> GetDiensten()
        {
            List<Dienst> diensten = new List<Dienst>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Naam, actief FROM Dienst ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dienst dienst = new Dienst
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString(),
                                actief = Convert.ToBoolean(reader["actief"])
                            };

                            diensten.Add(dienst);
                        }
                    }
                }
            }
            return diensten;
        }
        public static List<Dienst> GetActiveDiensten()
        {
            List<Dienst> diensten = new List<Dienst>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Naam, actief FROM Dienst where Actief = 1 ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dienst dienst = new Dienst
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString(),
                                actief = Convert.ToBoolean(reader["actief"])
                            };

                            diensten.Add(dienst);
                        }
                    }
                }
            }
            return diensten;
        }
        public static Dienst GetDienstById(int id)
        {
            Dienst dienst = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Naam FROM Dienst WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                dienst = new Dienst
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
                Console.WriteLine("Het systeem kon de Dienst niet vinden, probeer het nog eens.");
                throw;
            }
            return dienst;
        }
        public static string GetDienstNaamById(int id) 
        {
            string naam = "Onbekend";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Naam FROM Dienst WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            naam = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fout bij het ophalen van de dienst naam" + ex.Message);
            }
            return naam;

        }
        public static int SaveDienst(Dienst dienst, bool isnew)
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
                        objCmd.CommandText = "insert into Dienst(Naam, Actief)";
                        objCmd.CommandText += "values(@Naam, @Actief);";

                    }
                    else
                    {

                        objCmd.CommandText = "update Dienst set Naam = @Naam, ";
                        objCmd.CommandText += " Actief = @Actief where Id = @Id";
                        objCmd.Parameters.AddWithValue("@Id", dienst.Id);
                    }
                    objCmd.Parameters.AddWithValue("@Naam", dienst.Naam);
                    
                    objCmd.Parameters.AddWithValue("@Actief", dienst.actief);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                    if (isnew)
                    {
                        return GetHighestAankoperID();
                    }
                    else
                    {
                        return dienst.Id;
                    }

                }
            }

        }
        private static int GetHighestAankoperID()
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select max(Id) as Highest from Dienst";


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
        public static void DeleteDienst(Dienst dienst)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    objCmd.CommandText = "delete from Dienst ";
                    objCmd.CommandText += "where Id = @Id;";

                    objCmd.Parameters.AddWithValue("@Id", dienst.Id);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
