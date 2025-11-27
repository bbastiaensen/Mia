using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class AankoperManager
    {
        public static string ConnectionString { get; set; }
        public static List<Aankoper> GetAankoper()
        {
            List<Aankoper> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT Id,Voornaam, Achternaam, Actief, Voornaam + ' ' + Achternaam AS FullName FROM Aankoper ORDER BY FullName ASC";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aankoper ak;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aankoper>();
                        }

                        ak = new Aankoper();
                        ak.Id = Convert.ToInt32(objRea["Id"]);
                        ak.Voornaam = objRea["Voornaam"].ToString();
                        ak.Achternaam = objRea["Achternaam"].ToString();
                        ak.FullName = objRea["FullName"].ToString();
                        ak.actief = Convert.ToBoolean(objRea["Actief"]);

                        returnlist.Add(ak);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aankoper> GetActiveAankopers()
        {
            List<Aankoper> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT Id,Voornaam, Achternaam, Voornaam + ' ' + Achternaam AS FullName FROM Aankoper WHERE actief = 1 ORDER BY FullName ASC";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aankoper ak;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aankoper>();
                        }

                        ak = new Aankoper();
                        ak.Id = Convert.ToInt32(objRea["Id"]);
                        ak.Voornaam = objRea["Voornaam"].ToString();
                        ak.Achternaam = objRea["Achternaam"].ToString();
                        ak.FullName = objRea["FullName"].ToString();


                        returnlist.Add(ak);
                    }
                }
            }
            return returnlist;
        }
        // Get...ById
        public static Aankoper GetAankoperById(int id)
        {
            Aankoper aankoper = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Id, Voornaam, Achternaam FROM Aankoper WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                aankoper = new Aankoper
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
        public static int SaveAankoper(Aankoper aankoper, bool isnew)
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
                        objCmd.CommandText = "insert into Aankoper(Voornaam, Achternaam, Actief)";
                        objCmd.CommandText += "values(@Voornaam, @Achternaam , @Actief);";

                    }
                    else
                    {

                        objCmd.CommandText = "update Aankoper set Voornaam = @Voornaam, ";
                        objCmd.CommandText += "Achternaam = @Achternaam , Actief = @Actief where Id = @Id";
                        objCmd.Parameters.AddWithValue("@Id", aankoper.Id);
                    }
                    objCmd.Parameters.AddWithValue("@Voornaam", aankoper.Voornaam);
                    objCmd.Parameters.AddWithValue("@Achternaam", aankoper.Achternaam);
                    objCmd.Parameters.AddWithValue("@Actief", aankoper.actief);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                    if (isnew)
                    {
                        return GetHighestAankoperID();
                    }
                    else
                    {
                        return aankoper.Id;
                    }

                }
            }
        }
        private static int GetHighestAankoperID()
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select max(Id) as Highest from Aankoper";


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
        public static void DeleteAankoper(Aankoper aankoper)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    objCmd.CommandText = "delete from Aankoper ";
                    objCmd.CommandText += "where Id = @Id;";

                    objCmd.Parameters.AddWithValue("@Id", aankoper.Id);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public static void 
    }
}
