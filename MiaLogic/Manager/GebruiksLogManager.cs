using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public static class GebruiksLogManager
    {
        public static string ConnectionString { get; set; }

        public static List<GebruiksLog> GetGebruiksLogs()
        {
            List<GebruiksLog> gebruiksLogs = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from GebruiksLog order by TijdstipActie desc;";

                    objCn.Open();

                    SqlDataReader reader = objCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (gebruiksLogs == null)
                        {
                            gebruiksLogs = new List<GebruiksLog>();
                        }

                        GebruiksLog gebruiksLog = new GebruiksLog();
                        gebruiksLog.Id = Convert.ToInt32(reader["Id"]);
                        gebruiksLog.Gebruiker = reader["Gebruiker"].ToString();
                        gebruiksLog.TijdstipActie = Convert.ToDateTime(reader["TijdstipActie"]);
                        gebruiksLog.OmschrijvingActie = reader["OmschrijvingActie"].ToString();

                        gebruiksLogs.Add(gebruiksLog);
                    }
                }
            }

            return gebruiksLogs;
        }

        public static GebruiksLog GetGebruiksLog(int gebruiksLogId)
        {
            GebruiksLog gebruiksLog = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from GebruiksLog where Id = @Id";
                    objCmd.Parameters.AddWithValue("@Id", gebruiksLogId);

                    objCn.Open();

                    SqlDataReader reader = objCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        gebruiksLog = new GebruiksLog();
                        gebruiksLog.Id = Convert.ToInt32(reader["Id"]);
                        gebruiksLog.Gebruiker = reader["Gebruiker"].ToString();
                        gebruiksLog.TijdstipActie = Convert.ToDateTime(reader["TijdstipActie"]);
                        gebruiksLog.OmschrijvingActie = reader["OmschrijvingActie"].ToString();
                    }
                }
            }
            return gebruiksLog;
        }

        public static void SaveGebruiksLog(GebruiksLog gebruiksLog, bool insert)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    string sql = string.Empty;
                    if (insert)
                    {
                        sql = "insert into GebruiksLog(Gebruiker, TijdstipActie, OmschrijvingActie) values(@Gebruiker, @TijdstipActie, @OmschrijvingActie);";
                    }
                    else
                    {
                        sql = "update GebruiksLog set Gebruiker=@Gebruiker, TijdstipActie=@TijdstipActie, OmschrijvingActie=@OmschrijvingActie where Id = @Id";
                    }

                    objCmd.Parameters.AddWithValue("@Gebruiker", gebruiksLog.Gebruiker);
                    objCmd.Parameters.AddWithValue("@TijdstipActie", gebruiksLog.TijdstipActie);
                    objCmd.Parameters.AddWithValue("@OmschrijvingActie", gebruiksLog.OmschrijvingActie);
                    if (!insert)
                    {
                        objCmd.Parameters.AddWithValue("@Id", gebruiksLog.Id);
                    }

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteGebruiksLog(GebruiksLog gebruiksLog)
        {
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "delete from GebruiksLog where Id = @Id";
                    objCmd.Parameters.AddWithValue("@Id", gebruiksLog.Id);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
