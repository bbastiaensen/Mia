using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MiaLogic.Manager
{
    public class InvesteringenManager
    {
        public static string ConnectionString { get; set; }

        public static List<Investering> GetInvesteringen()
        {
            List<Investering> list = new List<Investering>();

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT Id, Naam, Actief FROM InvesteringsType ORDER BY Naam", cn))
            {
                cn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new Investering
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            Naam = r["Naam"].ToString(),
                            Actief = Convert.ToBoolean(r["Actief"])
                        });
                    }
                }
            }
            return list;
        }

        public static List<Investering> GetActiveInvesteringen()
        {
            List<Investering> list = new List<Investering>();

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT Id, Naam, Actief FROM InvesteringsType WHERE Actief = 1 ORDER BY Naam", cn))
            {
                cn.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new Investering
                        {
                            Id = Convert.ToInt32(r["Id"]),
                            Naam = r["Naam"].ToString(),
                            Actief = Convert.ToBoolean(r["Actief"])
                        });
                    }
                }
            }
            return list;
        }

        public static int SaveInvestering(Investering investering, bool isNew)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = cn;

                if (isNew)
                {
                    cmd.CommandText =
                        @"INSERT INTO InvesteringsType (Naam, Actief)
                          OUTPUT INSERTED.Id
                          VALUES (@Naam, @Actief)";
                }
                else
                {
                    cmd.CommandText =
                        @"UPDATE InvesteringsType
                          SET Naam = @Naam,
                              Actief = @Actief
                          WHERE Id = @Id";

                    cmd.Parameters.AddWithValue("@Id", investering.Id);
                }

                cmd.Parameters.AddWithValue("@Naam", investering.Naam);
                cmd.Parameters.AddWithValue("@Actief", investering.Actief);

                cn.Open();

                if (isNew)
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    return investering.Id;
                }
            }
        }

        public static void DeleteInvestering(Investering investering)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM InvesteringsType WHERE Id = @Id", cn))
            {
                cmd.Parameters.AddWithValue("@Id", investering.Id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
