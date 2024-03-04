using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public static class AanvraagManager
    {
        public static string ConnectionString { get; set; }
        public static List<Aanvraag> GetAanvraag()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Aanvraagmoment asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }

                        a = new Aanvraag();
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = objRea["Aanvraagmoment"].ToString();
                        a.Titel = objRea["Titel"].ToString();
                        a.Financieringsjaar = objRea["Financieringsjaar"].ToString();
                        a.Planningsdatum = Convert.ToDateTime(objRea["Planningsdatum"]);
                        a.StatusAanvraag = objRea["StatusAanvraag"].ToString();
                        a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();


                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }

        // Data uit databank halen

        public static int GetHighestAanvraagId()
        {
            int highestAanvraagId = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT MAX(Id) AS highest FROM Aanvraag;";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            highestAanvraagId = Convert.ToInt32(reader["highest"]);
                        }
                    }
                }
            }

            return highestAanvraagId;
        }
        public static List<Afdeling> GetAfdelingen()
        {
            List<Afdeling> afdelingen = new List<Afdeling>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Naam FROM Afdeling ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Afdeling afdeling = new Afdeling
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString()
                            };

                            afdelingen.Add(afdeling);
                        }
                    }
                }
            }

            return afdelingen;
        }
        public static List<Dienst> GetDiensten()
        {
            List<Dienst> diensten = new List<Dienst>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Id, Naam FROM Dienst ORDER BY Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dienst dienst = new Dienst
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString()
                            };

                            diensten.Add(dienst);
                        }
                    }
                }
            }

            return diensten;
        }
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
        public static List<string> GetFinancieringsjaren()
        {
            List<string> financieringsjaren = new List<string>();

            // Adding financial years based on the current year
            int currentYear = DateTime.Now.Year;
            for (int i = 0; i < 5; i++)
            {
                string startingYear = (currentYear + i).ToString();
                financieringsjaren.Add(startingYear);
            }

            return financieringsjaren;
        }
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
        public static List<string> GetWieKooptHet()
        {
            List<string> aankoper = new List<string>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Voornaam + ' ' + Achternaam AS FullName FROM Aankoper ORDER BY FullName ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullName = reader["FullName"].ToString();
                            aankoper.Add(fullName);
                        }
                    }
                }
            }

            return aankoper;
        }

        // Get...ById
        public static Afdeling GetAfdelingById(int id)
        {
            Afdeling afdeling = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Naam FROM Afdeling WHERE Id = @Id";

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
                                    Naam = reader["Naam"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Het systeem kon de Afdeling niet vinden, probeer het nog eens.");
                throw;
            }

            return afdeling;
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
        public static WieKooptHet GetAankoperByFullName(string fullName)
        {
            WieKooptHet aankoper = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Voornaam, Achternaam FROM Aankoper WHERE Voornaam + ' ' + Achternaam = @FullName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                aankoper = new WieKooptHet
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Voornaam = reader["Voornaam"].ToString(),
                                    Achternaam = reader["Achternaam"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Het systeem kon de Aankoper niet vinden, probeer het nog eens.");
                throw;
            }

            return aankoper;
        }

        // Aanvragen opslaan
        public static void SaveAanvraag(Aanvraag aanvraag, bool insert)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query;

                    if (insert)
                    {
                        // Insert query
                        query = @"
                    INSERT INTO Aanvraag (Gebruiker, AfdelingId, DienstId, Aanvraagmoment, Titel, Omschrijving,
                        FinancieringsTypeId, InvesteringsTypeId, PrioriteitId, Financieringsjaar, Planningsdatum,
                        StatusAanvraag, Kostenplaats, KostenplaatsId, PrijsIndicatieStuk, AantalStuk, AankoperId)
                    VALUES (@Gebruiker, @AfdelingId, @DienstId, @Aanvraagmoment, @Titel, @Omschrijving,
                        @FinancieringsTypeId, @InvesteringsTypeId, @PrioriteitId, @Financieringsjaar, @Planningsdatum,
                        @StatusAanvraag, @Kostenplaats, @KostenplaatsId, @PrijsIndicatieStuk, @AantalStuk, @AankoperId);"
                    }
                    else
                    {
                        // Update query
                        query = @"
                    UPDATE Aanvraag
                    SET Gebruiker = @Gebruiker, AfdelingId = @AfdelingId, DienstId = @DienstId,
                        Aanvraagmoment = @Aanvraagmoment, Titel = @Titel, Omschrijving = @Omschrijving,
                        FinancieringsTypeId = @FinancieringsTypeId, InvesteringsTypeId = @InvesteringsTypeId,
                        PrioriteitId = @PrioriteitId, Financieringsjaar = @Financieringsjaar,
                        Planningsdatum = @Planningsdatum, StatusAanvraag = @StatusAanvraag,
                        Kostenplaats = @Kostenplaats, KostenplaatsId = @KostenplaatsId,
                        PrijsIndicatieStuk = @PrijsIndicatieStuk, AantalStuk = @AantalStuk, AankoperId = @AankoperId
                    WHERE Id = @Id;";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Gebruiker", aanvraag.Gebruiker);
                        command.Parameters.AddWithValue("@AfdelingId", aanvraag.AfdelingId);
                        command.Parameters.AddWithValue("@DienstId", aanvraag.DienstId);
                        command.Parameters.AddWithValue("@Aanvraagmoment", aanvraag.Aanvraagmoment);
                        command.Parameters.AddWithValue("@Titel", aanvraag.Titel);
                        command.Parameters.AddWithValue("@Omschrijving", aanvraag.Omschrijving);
                        command.Parameters.AddWithValue("@FinancieringsTypeId", aanvraag.FinancieringsTypeId);
                        command.Parameters.AddWithValue("@InvesteringsTypeId", aanvraag.InvesteringsTypeId);
                        command.Parameters.AddWithValue("@PrioriteitId", aanvraag.PrioriteitId);
                        command.Parameters.AddWithValue("@Financieringsjaar", aanvraag.Financieringsjaar);
                        command.Parameters.AddWithValue("@Planningsdatum", aanvraag.Planningsdatum);
                        command.Parameters.AddWithValue("@StatusAanvraag", aanvraag.StatusAanvraag);
                        command.Parameters.AddWithValue("@Kostenplaats", aanvraag.Kostenplaats);
                        command.Parameters.AddWithValue("@KostenplaatsId", aanvraag.KostenplaatsId);
                        command.Parameters.AddWithValue("@PrijsIndicatieStuk", aanvraag.PrijsIndicatieStuk);
                        command.Parameters.AddWithValue("@AantalStuk", aanvraag.AantalStuk);
                        command.Parameters.AddWithValue("@AankoperId", aanvraag.AankoperId);

                        if (insert)
                        {
                            aanvraag.Id = Convert.ToInt32(command.ExecuteScalar());
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Id", aanvraag.Id);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Er is een fout opgetreden bij het opslaan van de Aanvraag, probeer het nog eens.");
                throw;
            }
        }
    }
}
