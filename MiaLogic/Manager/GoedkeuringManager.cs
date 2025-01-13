using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
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
                        goedkeuring.Naam = StatusAanvraagManager.GetStatusAanvraagById(goedkeuring.StatusAanvraagId).Naam;
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

                        goedkeuring.AfdelingId = Convert.ToInt32(objRea["AfdelingId"]);
                        goedkeuring.DienstId = Convert.ToInt32(objRea["DienstId"]);
                        goedkeuring.FinancieringsTypeId = Convert.ToInt32(objRea["FinancieringsTypeId"]);
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
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.AantalStuk, a.PrijsIndicatieStuk from Aanvraag a WHERE StatusAanvraagId BETWEEN 2 AND 5";
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
