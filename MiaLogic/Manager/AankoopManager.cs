using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MiaLogic.Manager
{
    public class AankoopManager
    {
        public static string ConnectionString { get; set; }

        public static Aankoop GetAankoopById(int id)
        {
            Aankoop aankoop = null;

            using (SqlConnection objCn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT * FROM Aankoop WHERE Id = @Id;";
                    objCmd.Parameters.AddWithValue("@Id", id);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    if (objRea.Read())
                    {
                        aankoop = new Aankoop();

                        aankoop.Id = Convert.ToInt32(objRea["Id"]);
                        aankoop.Titel = objRea["Titel"].ToString();
                        aankoop.BTWPercentage = Convert.ToInt32(objRea["BTWPercentage"]);
                        aankoop.BedragExBtw = Convert.ToInt32(objRea["BedragExBTW"]);
                        aankoop.StatusAankoopId = Convert.ToInt32(objRea["StatusAankoopId"]);

                        if (objRea["BestellingsDatum"] != DBNull.Value)
                            aankoop.BestellingsDatum = Convert.ToDateTime(objRea["BestellingsDatum"]);

                        if (objRea["VerwachteLeveringsDatum"] != DBNull.Value)
                            aankoop.VerwachteLeveringsDatum = Convert.ToDateTime(objRea["VerwachteLeveringsDatum"]);

                        if (objRea["EffectieveLeveringsDatum"] != DBNull.Value)
                            aankoop.EffectieveLeveringsDatum = Convert.ToDateTime(objRea["EffectieveLeveringsDatum"]);

                        aankoop.LeverancierId = Convert.ToInt32(objRea["LeverancierId"]);
                        aankoop.AanvraagId = Convert.ToInt32(objRea["AanvraagId"]);
                    }
                }
            }

            return aankoop;
        }

        public static Aankoop GetAankoopByAanvraagId(int id)
        {
            Aankoop aankoop = null;

            using (SqlConnection objCn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT * FROM Aankoop WHERE AanvraagId = @Id;";
                    objCmd.Parameters.AddWithValue("@Id", id);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    if (objRea.Read())
                    {
                        aankoop = new Aankoop();

                        aankoop.Id = Convert.ToInt32(objRea["Id"]);
                        aankoop.Titel = objRea["Titel"].ToString();
                        aankoop.BTWPercentage = Convert.ToInt32(objRea["BTWPercentage"]);
                        aankoop.BedragExBtw = Convert.ToInt32(objRea["BedragExBTW"]);
                        aankoop.StatusAankoopId = Convert.ToInt32(objRea["StatusAankoopId"]);

                        if (objRea["BestellingsDatum"] != DBNull.Value)
                            aankoop.BestellingsDatum = Convert.ToDateTime(objRea["BestellingsDatum"]);

                        if (objRea["VerwachteLeveringsDatum"] != DBNull.Value)
                            aankoop.VerwachteLeveringsDatum = Convert.ToDateTime(objRea["VerwachteLeveringsDatum"]);

                        if (objRea["EffectieveLeveringsDatum"] != DBNull.Value)
                            aankoop.EffectieveLeveringsDatum = Convert.ToDateTime(objRea["EffectieveLeveringsDatum"]);

                        aankoop.LeverancierId = Convert.ToInt32(objRea["LeverancierId"]);
                        aankoop.AanvraagId = Convert.ToInt32(objRea["AanvraagId"]);
                    }
                }
            }

            return aankoop;
        }

        public static List<AankoopOverzichtItem> GetAllAankopen()
        {
            List<AankoopOverzichtItem> returnlist = new List<AankoopOverzichtItem>();

            using (SqlConnection objCn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    objCmd.CommandText = @"
                        SELECT 
                            a.Id AS AankoopId,
                            a.Titel,
                            sa.Naam AS StatusAankoop,
                            CASE 
                                WHEN ak.Id IS NOT NULL 
                                THEN ak.Voornaam + ' ' + ak.Achternaam 
                                ELSE '' 
                            END AS Aankoper,
                            av.Gebruiker AS Aanvrager,
                            av.Aanvraagmoment,
                            av.Financieringsjaar,
                            r.Naam AS Richtperiode,
                            av.BudgetToegekend AS GoedgekeurdBedrag,
                            av.BudgetToegekend - 
                            (a.BedragExBTW * (1 + a.BTWPercentage / 100.0) 
                            + ISNULL(a.BedragTransfer, 0)) AS Saldo
                        FROM Aankoop a
                        INNER JOIN Aanvraag av ON a.AanvraagId = av.Id
                        INNER JOIN StatusAankoop sa ON a.StatusAankoopId = sa.Id
                        LEFT JOIN Aankoper ak ON av.AankoperId = ak.Id
                        LEFT JOIN Richtperiode r ON av.RichtperiodeId = r.Id
                        ORDER BY a.Id DESC";

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    while (objRea.Read())
                    {
                        AankoopOverzichtItem item = new AankoopOverzichtItem();

                        item.AankoopId = Convert.ToInt32(objRea["AankoopId"]);
                        item.Titel = objRea["Titel"]?.ToString() ?? "";
                        item.StatusAankoop = objRea["StatusAankoop"]?.ToString() ?? "";
                        item.Aankoper = objRea["Aankoper"]?.ToString() ?? "";
                        item.Aanvrager = objRea["Aanvrager"]?.ToString() ?? "";

                        item.Aanvraagmoment = objRea["Aanvraagmoment"] != DBNull.Value
                            ? Convert.ToDateTime(objRea["Aanvraagmoment"])
                            : DateTime.MinValue;

                        item.Financieringsjaar = objRea["Financieringsjaar"]?.ToString() ?? "";
                        item.Richtperiode = objRea["Richtperiode"]?.ToString() ?? "";

                        item.GoedgekeurdBedrag = objRea["GoedgekeurdBedrag"] != DBNull.Value
                            ? Convert.ToDecimal(objRea["GoedgekeurdBedrag"])
                            : 0;

                        item.Saldo = objRea["Saldo"] != DBNull.Value
                            ? Convert.ToDecimal(objRea["Saldo"])
                            : 0;

                        returnlist.Add(item);
                    }
                }
            }

            return returnlist;
        }

        public static void CreateAankoop(Aankoop aankoop)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Aankoop 
                        (Titel, BTWPercentage, BedragExBTW, StatusAankoopId, LeverancierId, AanvraagId) 
                        VALUES 
                        (@Titel, @BTWPercentage, @BedragExBTW, @StatusAankoopId, @LeverancierId, @AanvraagId);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Titel", aankoop.Titel ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@BTWPercentage", aankoop.BTWPercentage);
                        command.Parameters.AddWithValue("@BedragExBTW", aankoop.BedragExBtw);
                        command.Parameters.AddWithValue("@StatusAankoopId", aankoop.StatusAankoopId);
                        command.Parameters.AddWithValue("@LeverancierId", aankoop.LeverancierId);
                        command.Parameters.AddWithValue("@AanvraagId", aankoop.AanvraagId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Er is een fout opgetreden bij het aanmaken van de Aankoop.");
                throw;
            }
        }

        public static void DeleteAankoop(int aankoopId)
        {
            using (SqlConnection objCn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "DELETE FROM Aankoop WHERE Id = @Id";
                    objCmd.Parameters.AddWithValue("@Id", aankoopId);

                    objCn.Open();
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}