using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class InvesteringenManager
    {
        public static string ConnectionString { get; set; }
        public static List<Investering> GetInvesteringen()
        {
            List<Investering> investeringen = new List<Investering>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Naam FROM InvesteringsType ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Investering investering = new Investering
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString()
                            };

                            investeringen.Add(investering);
                        }
                    }
                }
            }

            return investeringen;
        }
        public static Investering GetInvesteringById(int id)
        {
            Investering investeringsType = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Naam FROM InvesteringsType WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                investeringsType = new Investering
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
                Console.WriteLine("Het systeem kon de Investering niet vinden, probeer het nog eens.");
                throw;
            }

            return investeringsType;
        }
    }
}
