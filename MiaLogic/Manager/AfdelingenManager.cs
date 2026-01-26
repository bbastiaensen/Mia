using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class AfdelingenManager
    {
        public static string ConnectionString { get; set; }
        public static List<Afdeling> GetAfdelingen()
        {
            List<Afdeling> afdelingen = new List<Afdeling>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Actief, Naam FROM Afdeling ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Afdeling afdeling = new Afdeling
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString(),
                                actief = Convert.ToBoolean(reader["Actief"])
                            };

                            afdelingen.Add(afdeling);
                        }
                    }
                }
            }
            return afdelingen;
        }
        public static Afdeling GetAfdelingById(int id)
        {
            Afdeling afdeling = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Actief, Naam FROM Afdeling WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                afdeling = new Afdeling
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Naam = reader["Naam"].ToString(),
                                    actief = Convert.ToBoolean(reader["Actief"])
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
            return afdeling;
        }

        public static string GetAfdelingNaamById(int id)
        {
            string naam = "Onbekend";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Naam FROM Afdeling WHERE Id = @Id";

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
            catch(Exception ex)
            {
                Console.WriteLine("Fout bij het ophalen van de Afdeling naam" + ex.Message);
            }
            return naam;
        }

        public static int SaveAfdeling(Afdeling afdeling, bool isnew)
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
                        objCmd.CommandText = "insert into Afdeling(Naam, Actief)";
                        objCmd.CommandText += "values(@Naam, @Actief);";

                    }
                    else
                    {

                        objCmd.CommandText = "update Afdeling set Naam = @Naam, Actief = @Actief WHERE Id = @Id";
                        objCmd.Parameters.AddWithValue("@Id", afdeling.Id);
                    }
                    objCmd.Parameters.AddWithValue("@Naam", afdeling.Naam);
                    objCmd.Parameters.AddWithValue("@Actief", afdeling.actief);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                    if (isnew)
                    {
                        return GetHighestAfdelingID();
                    }
                    else
                    {
                        return afdeling.Id;
                    }

                }
            }
        }

        private static int GetHighestAfdelingID()
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select max(Id) as Highest from Afdeling";


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

        public static void DeleteAfdeling(Afdeling afdeling)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    objCmd.CommandText = "delete from Afdeling ";
                    objCmd.CommandText += "where Id = @Id;";

                    objCmd.Parameters.AddWithValue("@Id", afdeling.Id);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
