using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public static class GoedkeuringManager
    {
        public static string ConnectionString { get; set; }

        public static Goedkeuring GetGoedkeuringById(int id)
        {
            Goedkeuring goedkeuring = null;

            using (SqlConnection objCn = new SqlConnection())
            {

                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {

                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select * from Aanvraag where Id = @Id;";
                    objCmd.Parameters.AddWithValue("@Id", id);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();


                    if (objRea.Read())
                    {

                        goedkeuring = new Goedkeuring();
                        goedkeuring.Id = Convert.ToInt32(objRea["Id"]);
                        goedkeuring.Gebruiker = objRea["Gebruiker"].ToString();
                        goedkeuring.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
                        goedkeuring.Titel = objRea["Titel"].ToString();
                        if (objRea["Financieringsjaar"] != DBNull.Value)
                        {
                            goedkeuring.Financieringsjaar = objRea["Financieringsjaar"].ToString();
                        }

                        goedkeuring.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        goedkeuring.StatusAanvraag = StatusAanvraagManager.GetStatusAanvraagById(goedkeuring.StatusAanvraagId).Naam;
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            goedkeuring.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            goedkeuring.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        if (objRea["Omschrijving"] != DBNull.Value)
                        {
                            goedkeuring.Omschrijving = objRea["Omschrijving"].ToString();
                        }

                        goedkeuring.KostenplaatsId = Convert.ToInt32(objRea["KostenplaatsId"]);
                        goedkeuring.Kostenplaats = KostenplaatsManager.GetKostenplaatsById(goedkeuring.KostenplaatsId).Naam;
                        goedkeuring.AfdelingId = Convert.ToInt32(objRea["AfdelingId"]);
                        goedkeuring.DienstId = Convert.ToInt32(objRea["DienstId"]);
                        goedkeuring.PrioriteitId = Convert.ToInt32(objRea["PrioriteitId"]);
                        goedkeuring.FinancieringsTypeId = Convert.ToInt32(objRea["FinancieringsTypeId"]);
                        goedkeuring.InvesteringsTypeId = Convert.ToInt32(objRea["InvesteringsTypeId"]);
                        goedkeuring.AankoperId = Convert.ToInt32(objRea["AankoperId"]);

                    }

                }
            }

            return goedkeuring;
        }
        public static List<Goedkeuring> GetGoedkeuringen()
        {
            List<Goedkeuring> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Aanvraagmoment desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Goedkeuring g;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Goedkeuring>();
                        }

                        g = new Goedkeuring();
                        g.Gebruiker = objRea["Gebruiker"].ToString();
                        g.Titel = objRea["Titel"].ToString();
                        g.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);

                        if (objRea["Financieringsjaar"] != DBNull.Value)
                        {
                            g.Financieringsjaar = objRea["Financieringsjaar"].ToString();
                        }

                        g.Kostenplaats = objRea["Kostenplaats"].ToString();

                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            g.Bedrag = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(g);
                    }
                }
            }
            return returnlist;
        }
    }
}
