using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class ParameterManager
    {
        public static string ConnectionString { get; set; }

        public static List<Parameter> GetParameters()
        {
            List<Parameter> parameters = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from Parameter order by Code asc;";

                    objCn.Open();

                    SqlDataReader reader = objCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (parameters == null)
                        {
                            parameters = new List<Parameter>();
                        }

                        Parameter parameter = new Parameter();
                        parameter.Id = Convert.ToInt32(reader["Id"]);
                        parameter.Code = reader["Code"].ToString();
                        parameter.Waarde = reader["Waarde"].ToString();
                        parameter.Eenheid = reader["Eenheid"].ToString();

                        parameters.Add(parameter);
                    }
                }
            }

            return parameters;
        }

        public static Parameter GetParameter(int parameterId)
        {
            Parameter parameter = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from Parameter where Id = @Id";
                    objCmd.Parameters.AddWithValue("@Id", parameterId);

                    objCn.Open();

                    SqlDataReader reader = objCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        parameter = new Parameter();
                        parameter.Id = Convert.ToInt32(reader["Id"]);
                        parameter.Code = reader["Code"].ToString();
                        parameter.Waarde = reader["Waarde"].ToString();
                        parameter.Eenheid = reader["Eenheid"].ToString();
                    }
                }
            }
            return parameter;
        }

        public static int SaveParameter(Parameter parameter, bool insert)
        {
            if (parameter.Id == 0 && insert == false)
            {
                throw new ArgumentNullException("De parameter die je wil bewaren is onbestaande.");
            }

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;

                    string sql = string.Empty;
                    if (insert)
                    {
                        sql = "insert into Parameter(Code, Waarde, Eenheid) values(@Code, @Waarde, @Eenheid);";
                    }
                    else
                    {
                        sql = "update Parameter set Code=@Code, Waarde=@Waarde, Eenheid=@Eenheid where Id = @Id";
                    }

                    objCmd.CommandText = sql;
                    objCmd.Parameters.AddWithValue("@Code", parameter.Code);
                    objCmd.Parameters.AddWithValue("@Waarde", parameter.Waarde);
                    objCmd.Parameters.AddWithValue("@Eenheid", parameter.Eenheid);
                    if (!insert)
                    {
                        objCmd.Parameters.AddWithValue("@Id", parameter.Id);
                    }

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }

            if (insert)
            {
                return HoogsteId();
            }
            else
            {
                return parameter.Id;
            }
        }

        public static void DeleteParameter(Parameter parameter)
        {
            if (parameter.Id == 0)
            {
                throw new ArgumentNullException("De parameter die je wil verwijderen is onbestaande.");
            }

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "delete from Parameter where Id = @Id";
                    objCmd.Parameters.AddWithValue("@Id", parameter.Id);

                    objCn.Open();

                    objCmd.ExecuteNonQuery();
                }
            }
        }

        private static int HoogsteId()
        {
            int hoogste = 0;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select max(Id) as Hoogste from Parameter";

                    objCn.Open();

                    SqlDataReader reader = objCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        hoogste = Convert.ToInt32(reader["Hoogste"]);
                    }
                }
            }

            return hoogste;
        }
    }
}
