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
        public static List<Prioriteit> GetPrioriteiten()
        {
            List<Prioriteit> prioriteiten = new List<Prioriteit>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Naam FROM Prioriteit ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Prioriteit prioriteit = new Prioriteit
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString()
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
    }
}
