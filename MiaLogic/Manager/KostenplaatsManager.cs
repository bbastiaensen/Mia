using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class KostenplaatsManager
    {
        public static string ConnectionString { get; set; }
        public static List<Kostenplaats> GetKostenplaatsen()
        {
            List<Kostenplaats> kostenplaatsen = new List<Kostenplaats>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Naam FROM Kostenplaats ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kostenplaats kostenplaats = new Kostenplaats
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString()
                            };

                            kostenplaatsen.Add(kostenplaats);
                        }
                    }
                }
            }
            return kostenplaatsen;
        }
        public static Kostenplaats GetKostenplaatsById(int id)
        {
            Kostenplaats kostenplaats = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Naam FROM Kostenplaats WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                kostenplaats = new Kostenplaats
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
                Console.WriteLine("Het systeem kon de Kostenplaats niet vinden, probeer het nog eens.");
                throw;
            }

            return kostenplaats;
        }
    }
}
