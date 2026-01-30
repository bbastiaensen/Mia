using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class AankoopManager
    {
        public static string ConnectionString { get; set; }

        public static Aankoop GetAankoopById(int id)
        {
            Aankoop aankoop = null;

            using (SqlConnection objCn = new SqlConnection())
            {

                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {

                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from Aankoop where Id = @Id;";
                    objCmd.Parameters.AddWithValue("@Id", id);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    if (objRea.Read())
                    {

                        aankoop = new Aankoop();
                        aankoop.Id = Convert.ToInt32(objRea["Id"]);
                        aankoop.Omschrijving = objRea["Omschrijving"].ToString();
                        aankoop.BTWPercentage = Convert.ToInt32(objRea["BTWPercentage"]);
                        aankoop.BedragExBtw = Convert.ToInt32(objRea["BedragExBTW"]);
                        aankoop.StatusAankoopId = Convert.ToInt32(objRea["StatusAankoopId"]);
                        if (objRea["BestellingsDatum"] != DBNull.Value)
                        {
                            aankoop.BestellingsDatum = Convert.ToDateTime(objRea["BestellingsDatum"].ToString());
                        }
                        if (objRea["VerwachteLeveringsDatum"] != DBNull.Value)
                        {
                            aankoop.VerwachteLeveringsDatum = Convert.ToDateTime(objRea["VerwachteLeveringsDatum"].ToString());
                        }
                        if (objRea["EffectieveLeveringsDatum"] != DBNull.Value)
                        {
                            aankoop.EffectieveLeveringsDatum = Convert.ToDateTime(objRea["EffectieveLeveringsDatum"].ToString());
                        }
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

            using (SqlConnection objCn = new SqlConnection())
            {

                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {

                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from Aankoop where AanvraagId = @Id;";
                    objCmd.Parameters.AddWithValue("@Id", id);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    if (objRea.Read())
                    {
                        aankoop = new Aankoop();

                        aankoop.Id = Convert.ToInt32(objRea["Id"]);
                        aankoop.Omschrijving = objRea["Omschrijving"].ToString();
                        aankoop.BTWPercentage = Convert.ToInt32(objRea["BTWPercentage"]);
                        aankoop.BedragExBtw = Convert.ToInt32(objRea["BedragExBTW"]);
                        aankoop.StatusAankoopId = Convert.ToInt32(objRea["StatusAankoopId"]);
                        if (objRea["BestellingsDatum"] != DBNull.Value)
                        {
                            aankoop.BestellingsDatum = Convert.ToDateTime(objRea["BestellingsDatum"].ToString());
                        }
                        if (objRea["VerwachteLeveringsDatum"] != DBNull.Value)
                        {
                            aankoop.VerwachteLeveringsDatum = Convert.ToDateTime(objRea["VerwachteLeveringsDatum"].ToString());
                        }
                        if (objRea["EffectieveLeveringsDatum"] != DBNull.Value)
                        {
                            aankoop.EffectieveLeveringsDatum = Convert.ToDateTime(objRea["EffectieveLeveringsDatum"].ToString());
                        }
                        aankoop.LeverancierId = Convert.ToInt32(objRea["LeverancierId"]);
                    }
                }
            }

            return aankoop;
        }

        public static List<AankoopOverzichtItem> GetAllAankopen()
        {
            List<AankoopOverzichtItem> returnlist = new List<AankoopOverzichtItem>();

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = @"
                        SELECT 
                            a.Id AS AankoopId,
                            a.Omschrijving,
                            av.Titel,
                            sa.Naam AS StatusAankoop,
                            CASE 
                                WHEN ak.Id IS NOT NULL THEN ak.Voornaam + ' ' + ak.Achternaam 
                                ELSE '' 
                            END AS Aankoper,
                            av.Gebruiker AS Aanvrager,
                            av.Financieringsjaar,
                            r.Naam AS Richtperiode,
                            av.BudgetToegekend AS GoedgekeurdBedrag,
                            av.BudgetToegekend - (a.BedragExBTW * (1 + a.BTWPercentage / 100.0)) AS Saldo
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
                        item.Omschrijving = objRea["Omschrijving"] != DBNull.Value ? objRea["Omschrijving"].ToString() : "";
                        item.Titel = objRea["Titel"] != DBNull.Value ? objRea["Titel"].ToString() : "";
                        item.StatusAankoop = objRea["StatusAankoop"] != DBNull.Value ? objRea["StatusAankoop"].ToString() : "";
                        item.Aankoper = objRea["Aankoper"] != DBNull.Value ? objRea["Aankoper"].ToString() : "";
                        item.Aanvrager = objRea["Aanvrager"] != DBNull.Value ? objRea["Aanvrager"].ToString() : "";
                        item.Financieringsjaar = objRea["Financieringsjaar"] != DBNull.Value ? objRea["Financieringsjaar"].ToString() : "";
                        item.Richtperiode = objRea["Richtperiode"] != DBNull.Value ? objRea["Richtperiode"].ToString() : "";
                        item.GoedgekeurdBedrag = objRea["GoedgekeurdBedrag"] != DBNull.Value ? Convert.ToDecimal(objRea["GoedgekeurdBedrag"]) : 0;
                        item.Saldo = objRea["Saldo"] != DBNull.Value ? Convert.ToDecimal(objRea["Saldo"]) : 0;

                        returnlist.Add(item);
                    }
                }
            }

            return returnlist;
        }

        public static void DeleteAankoop(int aankoopId)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

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
