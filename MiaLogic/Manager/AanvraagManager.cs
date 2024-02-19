using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public static class AanvraagManager
    {
        public static string ConnectionString { get; set; }
        public static List<Aanvraag> GetAanvragen()
        {
            List<Aanvraag> returnlist = null;
            //Connection object aanmaken
            using (SqlConnection objCn = new SqlConnection())
            {
                //Connectionstring instellen
                objCn.ConnectionString = ConnectionString;

                //Command object aanmaken
                using (SqlCommand objCmd = new SqlCommand())
                {
                    //Command object koppelen aan Connection object
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Aanvraagmoment asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    //Verwerken van Datareader
                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if(returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }

                        a = new Aanvraag();
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = objRea["Aanvraagmoment"].ToString();
                        a.Titel = objRea["Titel"].ToString();
                        if (objRea["Financieringsjaar"] != DBNull.Value)
                        {
                            a.Financieringsjaar = objRea["Financieringsjaar"].ToString();
                        }
                        if (objRea["Planningsdatum"] != DBNull.Value)
                        {
                            a.Planningsdatum = Convert.ToDateTime(objRea["Planningsdatum"]);
                        }
                        a.StatusAanvraag = objRea["StatusAanvraag"].ToString();
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();

                        
                        returnlist.Add(a);
                    }
                }
            }           
            return returnlist;
        }
    }
}
