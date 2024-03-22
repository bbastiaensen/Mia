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
            List<Foto> fotos = new List<Foto>();

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    objcmd.CommandText = "Select * from Foto order by Id asc;";

                    objcn.Open();

                    SqlDataReader reader = objcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Foto foto = new Foto();
                        foto.Id = Convert.ToInt32(reader["Id"]);
                        foto.AanvraagId = Convert.ToInt32(reader["AanvraagID"]);
                        foto.Url = reader["Url"].ToString();
                        fotos.Add(foto);
                    }
                }
            }
            return fotos;
        }


        public static List<Foto> GetFotoById(int id)
        {
            List<Foto> fotos = new List<Foto>();

            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;

                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;

                    objcmd.CommandText = "select Id, AanvraagID, Url from Foto WHERE Id = @Id;";
                    objcmd.Parameters.AddWithValue("@Id", id);

                    objcn.Open(); //Open de connectie met de databank

                    SqlDataReader reader = objcmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Foto foto = new Foto();
                        foto.Id = Convert.ToInt32(reader["Id"]);
                        foto.AanvraagId = Convert.ToInt32(reader["AanvraagID"]);
                        foto.Url = reader["Url"].ToString();
                        fotos.Add(foto); //Voeg rollen toe aan de lijst voor de specifieke gebruiker
                    }
                }
                return fotos;
            }
        }

        public static void SaveFoto(Foto foto)
        {
            using (SqlConnection objcn = new SqlConnection())
            {
                objcn.ConnectionString = ConnectionString;
                using (SqlCommand objcmd = new SqlCommand())
                {
                    objcmd.Connection = objcn;
                    objcmd.CommandType = CommandType.Text;

                    objcmd.CommandText = "insert into Foto (AanvraagID, Url) VALUES (@AanvraagId, @Url)";


                    objcmd.Parameters.AddWithValue("@AanvraagId", foto.AanvraagId);
                    objcmd.Parameters.AddWithValue("@Url", foto.Url);

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
    }
}
