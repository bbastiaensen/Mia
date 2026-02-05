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
        public static List<Kostenplaats> GetAllKostenplaatsen()
        {
            List<Kostenplaats> kostenplaatsen = new List<Kostenplaats>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Kostenplaats ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kostenplaats kostenplaats = new Kostenplaats
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString(),
                                Actief = Convert.ToBoolean(reader["Actief"])
                            };

                            if (reader["Code"] != System.DBNull.Value)
                            {
                                kostenplaats.Code = Convert.ToInt32(reader["Code"]);
                            }

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

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Kostenplaats WHERE Id = @Id";

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
                                Naam = reader["Naam"].ToString(),
                                Actief = Convert.ToBoolean(reader["Actief"])
                            };

                            if (reader["Code"] != System.DBNull.Value)
                            {
                                kostenplaats.Code = Convert.ToInt32(reader["Code"]);
                            }
                        }
                    }
                }
            }

            return kostenplaats;
        }

        public static Kostenplaats SaveKostenplaats(bool isNew, Kostenplaats kostenplaats)
        {
            string sql = string.Empty;

            if (isNew)
            {
                //INSERT
                sql = "insert into Kostenplaats(Naam, Code, Actief) values(@Naam, @Code, @Actief);";
            }
            else
            {
                //UPDATE
                sql = "update Kostenplaats set Naam = @Naam, Code = @Code, Actief = @Actief where Id = @Id;";
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = sql;
                    command.Parameters.AddWithValue("@Naam", kostenplaats.Naam);
                    command.Parameters.AddWithValue("@Code", kostenplaats.Code);
                    command.Parameters.AddWithValue("@Actief", kostenplaats.Actief);
                    if (!isNew)
                    {
                        command.Parameters.AddWithValue("@Id", kostenplaats.Id);
                    }

                    connection.Open();

                    command.ExecuteNonQuery();

                    if (isNew)
                    {
                        kostenplaats.Id = GetHighestId();
                    }
                }
            }

            return kostenplaats;
        }

        private static int GetHighestId()
        {
            int highestId = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT max(Id) as highest FROM Kostenplaats;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            highestId = Convert.ToInt32(reader["highest"]);
                        }
                    }
                }
            }
            return highestId;
        }

        public static void DeleteKostenplaats(Kostenplaats kostenplaats)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from Kostenplaats where Id = @Id";
                    command.Parameters.AddWithValue("@Id", kostenplaats.Id);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Kostenplaats> GetActiveKostenplaatsen()
        {
            var kostenplaatsen = new List<Kostenplaats>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                const string query = "SELECT Id, Naam, Code, Actief FROM Kostenplaats WHERE Actief = 1 ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var kostenplaats = new Kostenplaats
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString(),
                                Actief = Convert.ToBoolean(reader["Actief"])
                            };

                            if (reader["Code"] != DBNull.Value)
                            {
                                kostenplaats.Code = Convert.ToInt32(reader["Code"]);
                            }

                            kostenplaatsen.Add(kostenplaats);
                        }
                    }
                }
            }
            return kostenplaatsen;
        }
    }
}

