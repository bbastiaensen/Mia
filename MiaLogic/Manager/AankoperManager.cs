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
        //public static List<Aankoper> GetAankoper()
        //{
        //    List<Aankoper> aankoper = new List<Aankoper>();

        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        connection.Open();

        //        string query = "SELECT Voornaam + ' ' + Achternaam AS FullName FROM Aankoper ORDER BY FullName ASC";

        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    string fullName = reader["FullName"].ToString();
        //                    aankoper.Add(fullName);
        //                }
        //            }
        //        }
        //    }

        //    return aankoper;
        //}
        public static List<Aankoper> GetAankoper()
        {
            List<Aankoper> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT Id,Voornaam, Achternaam, Voornaam + ' ' + Achternaam AS FullName FROM Aankoper ORDER BY FullName ASC";
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
    }
}
