using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            //Connection object aanmaken
            using (SqlConnection objCn = new SqlConnection())
            {
                //Connectionstring instellen
                objCn.ConnectionString = ConnectionString;

                //Command object aanmaken
                using (SqlCommand objCmd = new SqlCommand())
                {
                    //Command object koppelen aan Connection object
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Aanvraagmoment asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    //Verwerken van Datareader
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


        // Data uit databank halen
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
    }
}
