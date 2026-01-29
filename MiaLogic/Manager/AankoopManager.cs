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

        public static void CreateAankoop(Aankoop aankoop)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = @"INSERT INTO Aankoop (Omschrijving, BTWPercentage, BedragExBTW, StatusAankoopId, LeverancierId, AanvraagId) 
                        VALUES (@Omschrijving, @BTWPercentage, @BedragExBTW, @StatusAankoopId, @LeverancierId, @AanvraagId);";
                    objCmd.Parameters.AddWithValue("@Omschrijving", aankoop.Omschrijving ?? (object)DBNull.Value);
                    objCmd.Parameters.AddWithValue("@BTWPercentage", aankoop.BTWPercentage);
                    objCmd.Parameters.AddWithValue("@BedragExBTW", aankoop.BedragExBtw);
                    objCmd.Parameters.AddWithValue("@StatusAankoopId", aankoop.StatusAankoopId);
                    objCmd.Parameters.AddWithValue("@LeverancierId", aankoop.LeverancierId);
                    objCmd.Parameters.AddWithValue("@AanvraagId", aankoop.AanvraagId);

                    objCn.Open();
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
