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
        public static List<Aanvraag> GetAanvragen()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Aanvraagmoment asc";
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
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
                        a.Titel = objRea["Titel"].ToString();
                        if (objRea["Financieringsjaar"] != DBNull.Value)
                        {
                            a.Financieringsjaar = objRea["Financieringsjaar"].ToString();
                        }
                        if (objRea["Planningsdatum"] != DBNull.Value)
                        {
                            a.Planningsdatum = Convert.ToDateTime(objRea["Planningsdatum"]);
                        }
                        a.StatusAanvraag = objRea["StatusAanvraag"].ToString();
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
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
                        FinancieringsTypeId, InvesteringsTypeId, PrioriteitId, Financieringsjaar,
                        StatusAanvraagId, Kostenplaats, KostenplaatsId, PrijsIndicatieStuk, AantalStuk, AankoperId, PlanningsDatum)
                    VALUES (@Gebruiker, @AfdelingId, @DienstId, @Aanvraagmoment, @Titel, @Omschrijving,
                        @FinancieringsTypeId, @InvesteringsTypeId, @PrioriteitId, @Financieringsjaar,
                        @StatusAanvraagId, @Kostenplaats, @KostenplaatsId, @PrijsIndicatieStuk, @AantalStuk, @AankoperId, @PlanningsDatum);";
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
                        StatusAanvraagId = @StatusAanvraagId,
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
                        command.Parameters.AddWithValue("@StatusAanvraagId", aanvraag.StatusAanvraag);
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
