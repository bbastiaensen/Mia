using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class FotoManager
    {
        public static string ConnectionString { get; set; }

        public static List<Foto> GetFotos()
        {
            List<Foto> returnlist = null;

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    objcmd.CommandText = "Select * from Foto order by Id asc;";
                    objcn.Open();

                    SqlDataReader objRea = objcmd.ExecuteReader();
                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Foto>();
                        }
                        Foto foto = new Foto();
                        foto.Id = Convert.ToInt32(objRea["Id"]);
                        if (objRea["Titel"] != DBNull.Value)
                        {
                            foto.Titel = objRea["Titel"].ToString();
                        }
                        foto.AanvraagId = Convert.ToInt32(objRea["AanvraagID"]);
                        foto.Url = objRea["Url"].ToString();
                        returnlist.Add(foto);
                    }
                }
            }
            return returnlist;
        }

        public static Foto GetFotoById(int id)
        {
            Foto foto = new Foto();

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;

                    objcmd.CommandText = "select Id, AanvraagID, Url, Titel from Foto WHERE Id = @Id;";
                    objcmd.Parameters.AddWithValue("@Id", id);

                    objcn.Open(); //Open de connectie met de databank

                    SqlDataReader reader = objcmd.ExecuteReader();
                    if (reader.Read())
                    {
                        foto.Id = Convert.ToInt32(reader["Id"]);
                        foto.Titel = reader["Titel"].ToString();
                        foto.AanvraagId = Convert.ToInt32(reader["AanvraagID"]);
                        foto.Url = reader["Url"].ToString();
                    }
                    else
                    {
                        throw new Exception("Foto met id " + id + " werd niet gevonfen.");
                    }
                }
                return foto;
            }
        }

        public static void SaveFoto(Foto foto, bool insert)
        {
            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;
                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    objcmd.CommandType = CommandType.Text;
                    if (insert)
                    {
                        objcmd.CommandText = "insert into Foto (AanvraagID, Url, Titel) VALUES (@AanvraagId, @Url, @Titel)";
                        objcmd.Parameters.AddWithValue("@AanvraagId", foto.AanvraagId);
                    }
                    else
                    {
                        objcmd.CommandText = " update Foto set Url=@Url, Titel=@Titel where Id=@Id";
                        objcmd.Parameters.AddWithValue("@Id", foto.Id);
                    } 
                    objcmd.Parameters.AddWithValue("@Url", foto.Url);
                    objcmd.Parameters.AddWithValue("@Titel", foto.Titel);

                    try
                    {
                        objcn.Open();
                        objcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;

                    }
                }
            }

        }

        public static void DeleteFoto(Foto foto)
        {
            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;

                    objcmd.CommandText = "delete from Foto WHERE Id = @Id;";
                    objcmd.Parameters.AddWithValue("@Id", foto.Id);

                    objcn.Open();
                    objcmd.ExecuteNonQuery();
                }
            }
        }

        public static int GetHighestFotoId()
        {
            int hoogsteId = 0;

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;
                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    objcmd.CommandType = CommandType.Text;
                    objcmd.CommandText = "select max(Id) as hoogste from Foto;";

                    objcn.Open();
                    SqlDataReader reader = objcmd.ExecuteReader();

                    if (reader.Read())
                    {
                        hoogsteId = Convert.ToInt32(reader["hoogste"]);
                    }
                }
            }

            return hoogsteId;
        }
    }
}
