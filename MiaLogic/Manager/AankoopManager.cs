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
                        aankoop.BudgetToegekend = Convert.ToInt32(objRea["BudgetToegekend"]);
                        aankoop.BTWPercentage = Convert.ToInt32(objRea["BTWPercentage"]);
                        aankoop.BedragExBtw = Convert.ToDecimal(objRea["BedragExBTW"]);
                        aankoop.StatusAankoopId = Convert.ToInt32(objRea["StatusAankoopId"]);
                        aankoop.BestelbonNummer = objRea["BestelbonNummer"].ToString();
                        aankoop.Factuur = Convert.ToBoolean(objRea["Factuur"]);
                        aankoop.FactuurNummer = objRea["FactuurNummer"].ToString();
                        aankoop.InternNummer = objRea["InternNummer"].ToString();
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
                        aankoop.BedragExBtw = Convert.ToDecimal(objRea["BedragExBTW"]);
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
        public static void UpdateAankoop(Aankoop aankoop)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand ObjCmd = new SqlCommand())
                {
                    ObjCmd.Connection = objCn;
                    ObjCmd.CommandText = @"UPDATE Aankoop SET
                Omschrijving = @Omschrijving,
                StatusAankoopId = @StatusAankoopId,
                BedragExBTW = @BedragExBTW,
                BTWPercentage = @BTWPercentage,
                BedragTransfer = @BedragTransfer,
                BestellingsDatum = @BestellingsDatum,
                VerwachteLeveringsDatum = @VerwachteLeveringsDatum,
                EffectieveLeveringsDatum = @EffectieveLeveringsDatum,
                LeverancierId = @LeverancierId,
                BestelbonNummer = @BestelbonNummer,
                Factuur = @Factuur,
                FactuurNummer = @FactuurNummer,
                InternNummer = @InternNummer
                WHERE Id = @Id";
                    objCn.Open();

                    ObjCmd.Parameters.AddWithValue("@Id", aankoop.Id);
                    ObjCmd.Parameters.AddWithValue("@Omschrijving", aankoop.Omschrijving);
                    ObjCmd.Parameters.AddWithValue("@StatusAankoopId", aankoop.StatusAankoopId);
                    ObjCmd.Parameters.AddWithValue("@BedragExBTW", aankoop.BedragExBtw);
                    ObjCmd.Parameters.AddWithValue("@BTWPercentage", aankoop.BTWPercentage);
                    ObjCmd.Parameters.AddWithValue("@BedragTransfer", aankoop.BedragTransfer);
                    ObjCmd.Parameters.AddWithValue("@BestellingsDatum", (object)aankoop.BestellingsDatum ?? DBNull.Value);
                    ObjCmd.Parameters.AddWithValue("@VerwachteLeveringsDatum", (object)aankoop.VerwachteLeveringsDatum ?? DBNull.Value);
                    ObjCmd.Parameters.AddWithValue("@EffectieveLeveringsDatum", (object)aankoop.EffectieveLeveringsDatum ?? DBNull.Value);
                    ObjCmd.Parameters.AddWithValue("@LeverancierId", aankoop.LeverancierId);
                    ObjCmd.Parameters.AddWithValue("@BestelbonNummer", aankoop.BestelbonNummer);
                    ObjCmd.Parameters.AddWithValue("@Factuur", aankoop.Factuur);
                    ObjCmd.Parameters.AddWithValue("@FactuurNummer", aankoop.FactuurNummer);
                    ObjCmd.Parameters.AddWithValue("@InternNummer", aankoop.InternNummer);

                    ObjCmd.ExecuteNonQuery();
                }
            }
            
        }
        public static void DeleteAankoop(int aankoopId)
        {
            using (SqlConnection ObjCn = new SqlConnection())
            {
                ObjCn.ConnectionString = ConnectionString;

                using (SqlCommand ObjCmd = new SqlCommand())
                {
                    ObjCmd.Connection = ObjCn;
                    ObjCmd.CommandText = "DELETE FROM Aankoop WHERE Id = @Id";
                    ObjCmd.Parameters.AddWithValue("@Id", aankoopId);

                    ObjCn.Open();
                    ObjCmd.ExecuteNonQuery();
                }
            }
            
        }

    }
}
