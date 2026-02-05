using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class GemeenteManager
    {
        public static string ConnectionString { get; set; }

        public static List<Gemeente> GetGemeentenByLandId(int landId)
        {
            List<Gemeente> lijst = new List<Gemeente>();

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Postcode, Naam, LandId FROM Gemeente WHERE LandId = @LandId ORDER BY Postcode";

                cmd.Parameters.AddWithValue("@LandId", landId);

                cn.Open();
                SqlDataReader ObjRea = cmd.ExecuteReader();

                while (ObjRea.Read())
                {
                    Gemeente g = new Gemeente();
                    g.Id = Convert.ToInt32(ObjRea["Id"]);
                    g.Postcode = Convert.ToInt32(ObjRea["Postcode"].ToString());
                    g.Naam = ObjRea["Naam"].ToString();
                    g.LandId = Convert.ToInt32(ObjRea["LandId"]);
                    lijst.Add(g);
                }
            }

            return lijst;
        }

        public static Gemeente GetGemeenteById(int gemeenteId)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Postcode, Naam, LandId FROM Gemeente WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", gemeenteId);

                cn.Open();
                SqlDataReader ObjRea = cmd.ExecuteReader();

                if (ObjRea.Read())
                {
                    Gemeente g = new Gemeente();
                    g.Id = Convert.ToInt32(ObjRea["Id"]);
                    g.Postcode = Convert.ToInt32(ObjRea["Postcode"].ToString());
                    g.Naam = ObjRea["Naam"].ToString();
                    g.LandId = Convert.ToInt32(ObjRea["LandId"]);
                    return g;
                }
            }
            return null;
        }
        public static List<Gemeente> GetGemeentes()
        {
            List<Gemeente> gemeentes = new List<Gemeente>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT Gemeente.Id, Gemeente.Naam,LandId,Postcode, Land.Naam as LandNaam FROM Gemeente inner join Land on Gemeente.LandId = Land.Id  ORDER BY Gemeente.Naam ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Gemeente gemeente = new Gemeente
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Naam = reader["Naam"].ToString(),
                                LandId = Convert.ToInt32(reader["LandId"]),
                                Postcode = Convert.ToInt32(reader["Postcode"]),
                                LandNaam = reader["LandNaam"].ToString()

                            };

                            gemeentes.Add(gemeente);
                        }
                    }
                }
            }
            return gemeentes;
        }
        public static int SaveGemeente(Gemeente gemeente, bool isnew)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    if (isnew)
                    {
                        //Nieuw
                        objCmd.CommandText = "INSERT INTO Gemeente (Naam, Postcode, LandId)";
                        objCmd.CommandText += "VALUES (@Naam, @Postcode,";
                        objCmd.CommandText += " (SELECT Id FROM Land WHERE Naam = @Land))";

                    }
                    else
                    {

                        objCmd.CommandText = "UPDATE g SET Naam = @Naam,   Postcode = @Postcode ";
                        objCmd.CommandText += "FROM Gemeente g JOIN Land l ON l.Id = g.LandId WHERE g.Id = @Id ";

                        objCmd.Parameters.AddWithValue("@Id", gemeente.Id);
                        objCmd.Parameters.AddWithValue("@LId", gemeente.LandId);
                    }
                    objCmd.Parameters.AddWithValue("@Naam", gemeente.Naam);
                    objCmd.Parameters.AddWithValue("@Postcode", gemeente.Postcode);
                    objCmd.Parameters.AddWithValue("@Land", gemeente.LandNaam);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                    if (isnew)
                    {
                        return GetHighestGemeenteID();
                    }
                    else
                    {
                        return gemeente.Id;
                    }

                }
            }
        }
        private static int GetHighestGemeenteID()
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select max(Id) as Highest from Gemeente";


                    objCn.Open();

                    SqlDataReader ObjRea = objCmd.ExecuteReader();
                    if (ObjRea.Read())
                    {

                        return Convert.ToInt32(ObjRea["Highest"]);

                    }
                    else
                    {
                        return 0;
                    }
                }

            }
        }
        public static void DeleteGemeente(Gemeente gemeente)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    objCmd.CommandText = "delete from Gemeente ";
                    objCmd.CommandText += "where Id = @Id;";

                    objCmd.Parameters.AddWithValue("@Id", gemeente.Id);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }
        }
       

    }
}
