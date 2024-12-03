using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    internal class Goedkeuringmanager
    {
        public static string connectionstring { get; set; }

        public static List<Goedkeuring> GetGoedkeuringen()
        {
            List<Goedkeuring> returnlist = null;
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = connectionstring;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select  a.Gebruiker, a.Aanvraagmoment, a.Titel order by a.Aanvraagmoment desc\"";
                    objCn.Open();

                }
            }

            return returnlist;
        }
    }
}
