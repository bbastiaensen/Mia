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
    public static class AanvraagManager
    {
        public static string ConnectionString { get; set; }
        public static Aanvraag GetAanvraagById(int id)
        {
            Aanvraag aanvraag = null;

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

                        aanvraag = new Aanvraag();
                        aanvraag.Id = Convert.ToInt32(objRea["Id"]);
                        aanvraag.Gebruiker = objRea["Gebruiker"].ToString();
                        aanvraag.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
                        aanvraag.Titel = objRea["Titel"].ToString();
                        if (objRea["Financieringsjaar"] != DBNull.Value)
                        {
                            aanvraag.Financieringsjaar = objRea["Financieringsjaar"].ToString();
                        }
                        if (objRea["Planningsdatum"] != DBNull.Value)
                        {
                            aanvraag.Planningsdatum = Convert.ToDateTime(objRea["Planningsdatum"]);
                        }
                        aanvraag.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        aanvraag.StatusAanvraag = StatusAanvraagManager.GetStatusAanvraagById(aanvraag.StatusAanvraagId).Naam;
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            aanvraag.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            aanvraag.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        if (objRea["Omschrijving"] != DBNull.Value)
                        {
                            aanvraag.Omschrijving = objRea["Omschrijving"].ToString();
                        }
                        if (objRea["OpmerkingenResultaat"] != DBNull.Value)
                        {
                            aanvraag.OpmerkingenResultaat = objRea["OpmerkingenResultaat"].ToString();
                        }
                        aanvraag.KostenplaatsId = Convert.ToInt32(objRea["KostenplaatsId"]);
                        aanvraag.Kostenplaats = KostenplaatsManager.GetKostenplaatsById(aanvraag.KostenplaatsId).Naam;
                        aanvraag.AfdelingId = Convert.ToInt32(objRea["AfdelingId"]);
                        aanvraag.DienstId = Convert.ToInt32(objRea["DienstId"]);
                        aanvraag.PrioriteitId = Convert.ToInt32(objRea["PrioriteitId"]);
                        aanvraag.FinancieringsTypeId = Convert.ToInt32(objRea["FinancieringsTypeId"]);
                        aanvraag.InvesteringsTypeId = Convert.ToInt32(objRea["InvesteringsTypeId"]);
                        aanvraag.AankoperId = Convert.ToInt32(objRea["AankoperId"]);
                        if (objRea["RichtperiodeId"] != DBNull.Value)
                        {
                            aanvraag.RichtperiodeId = Convert.ToInt32(objRea["RichtperiodeId"]);
                        }
                        if (objRea["BudgetToegekend"] != DBNull.Value)
                        {
                            aanvraag.BudgetToegekend = Convert.ToDecimal(objRea["BudgetToegekend"]);
                        }
                    }
                }
            }

            return aanvraag;
        }
        public static List<Aanvraag> Aankopen_sort_aanvrager_asc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats, a.OpmerkingenResultaat, a.RichtperiodeId, a.BudgetToegekend from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId inner join Richtperiode r on r.Id = a.RichtperiodeId where a.StatusAanvraagId = 4 order by a.Gebruiker asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["BudgetToegekend"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToDecimal(objRea["BudgetToegekend"]);
                        }
                        if (objRea["OpmerkingenResultaat"] != DBNull.Value)
                        {
                            a.OpmerkingenResultaat = objRea["OpmerkingenResultaat"].ToString();
                        }
                        a.RichtperiodeId = Convert.ToInt32(objRea["RichtperiodeId"]);
                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> Aankopen_sort_titel_asc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats, a.OpmerkingenResultaat, a.RichtperiodeId, a.BudgetToegekend from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId inner join Richtperiode r on r.Id = a.RichtperiodeId where a.StatusAanvraagId = 4 order by a.Titel asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["BudgetToegekend"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToDecimal(objRea["BudgetToegekend"]);
                        }
                        if (objRea["OpmerkingenResultaat"] != DBNull.Value)
                        {
                            a.OpmerkingenResultaat = objRea["OpmerkingenResultaat"].ToString();
                        }
                        a.RichtperiodeId = Convert.ToInt32(objRea["RichtperiodeId"]);
                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> Aankopen_sort_titel_desc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats, a.OpmerkingenResultaat, a.RichtperiodeId, a.BudgetToegekend from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId inner join Richtperiode r on r.Id = a.RichtperiodeId where a.StatusAanvraagId = 4 order by a.Titel desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["BudgetToegekend"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToDecimal(objRea["BudgetToegekend"]);
                        }
                        if (objRea["OpmerkingenResultaat"] != DBNull.Value)
                        {
                            a.OpmerkingenResultaat = objRea["OpmerkingenResultaat"].ToString();
                        }
                        a.RichtperiodeId = Convert.ToInt32(objRea["RichtperiodeId"]);
                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> Aankopen_sort_aanvrager_desc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats, a.OpmerkingenResultaat, a.RichtperiodeId, a.BudgetToegekend from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId inner join Richtperiode r on r.Id = a.RichtperiodeId where a.StatusAanvraagId = 4 order by a.Gebruiker desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["BudgetToegekend"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToDecimal(objRea["BudgetToegekend"]);
                        }
                        if (objRea["OpmerkingenResultaat"] != DBNull.Value)
                        {
                            a.OpmerkingenResultaat = objRea["OpmerkingenResultaat"].ToString();
                        }
                        a.RichtperiodeId = Convert.ToInt32(objRea["RichtperiodeId"]);
                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> Aankopen_sort_bedrag_asc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats, a.OpmerkingenResultaat, a.RichtperiodeId, a.BudgetToegekend from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId inner join Richtperiode r on r.Id = a.RichtperiodeId where a.StatusAanvraagId = 4 order by (a.AantalStuk * a.PrijsIndicatieStuk) asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["BudgetToegekend"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToDecimal(objRea["BudgetToegekend"]);
                        }
                        if (objRea["OpmerkingenResultaat"] != DBNull.Value)
                        {
                            a.OpmerkingenResultaat = objRea["OpmerkingenResultaat"].ToString();
                        }
                        a.RichtperiodeId = Convert.ToInt32(objRea["RichtperiodeId"]);
                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> Aankopen_sort_bedrag_desc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats, a.OpmerkingenResultaat, a.RichtperiodeId, a.BudgetToegekend from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId inner join Richtperiode r on r.Id = a.RichtperiodeId where a.StatusAanvraagId = 4 order by (a.AantalStuk * a.PrijsIndicatieStuk) desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["BudgetToegekend"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToDecimal(objRea["BudgetToegekend"]);
                        }
                        if (objRea["OpmerkingenResultaat"] != DBNull.Value)
                        {
                            a.OpmerkingenResultaat = objRea["OpmerkingenResultaat"].ToString();
                        }
                        a.RichtperiodeId = Convert.ToInt32(objRea["RichtperiodeId"]);
                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> Aanvraag_sort_sorteertvologorde_asc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats, a.OpmerkingenResultaat, a.RichtperiodeId, a.BudgetToegekend from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId inner join Richtperiode r on r.Id = a.RichtperiodeId where a.StatusAanvraagId = 4 order by (a.AantalStuk * a.PrijsIndicatieStuk) asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["BudgetToegekend"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToDecimal(objRea["BudgetToegekend"]);
                        }
                        if (objRea["OpmerkingenResultaat"] != DBNull.Value)
                        {
                            a.OpmerkingenResultaat = objRea["OpmerkingenResultaat"].ToString();
                        }
                        a.RichtperiodeId = Convert.ToInt32(objRea["RichtperiodeId"]);
                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> Aanvraag_sort_sorteertvologorde_desc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats, a.OpmerkingenResultaat, a.RichtperiodeId, a.BudgetToegekend from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId inner join Richtperiode r on r.Id = a.RichtperiodeId where a.StatusAanvraagId = 4 order by r.Sorteervolgorde desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["BudgetToegekend"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToDecimal(objRea["BudgetToegekend"]);
                        }
                        if (objRea["OpmerkingenResultaat"] != DBNull.Value)
                        {
                            a.OpmerkingenResultaat = objRea["OpmerkingenResultaat"].ToString();
                        }
                        a.RichtperiodeId = Convert.ToInt32(objRea["RichtperiodeId"]);
                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetAanvragen()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats, a.OpmerkingenResultaat, a.RichtperiodeId, a.BudgetToegekend from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Aanvraagmoment desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["BudgetToegekend"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToDecimal(objRea["BudgetToegekend"]);
                        }
                        if (objRea["OpmerkingenResultaat"] != DBNull.Value)
                        {
                            a.OpmerkingenResultaat = objRea["OpmerkingenResultaat"].ToString();
                        }
                        a.RichtperiodeId = Convert.ToInt32(objRea["RichtperiodeId"]);
                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        // Data uit databank halen
        public static int GetHighestAanvraagId()
        {
            int highestAanvraagId = 0;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT MAX(Id) AS highest FROM Aanvraag;";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            highestAanvraagId = Convert.ToInt32(reader["highest"]);
                        }
                    }
                }
            }
            return highestAanvraagId;
        }
        public static List<Aanvraag> GetGoedgekeurdeAanvragen()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.AantalStuk, a.PrijsIndicatieStuk from Aanvraag a WHERE StatusAanvraagId BETWEEN 2 AND 5";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag g;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }

                        g = new Aanvraag();
                        g.Id = Convert.ToInt32(objRea["Id"]);
                        g.Gebruiker = objRea["Gebruiker"].ToString();
                        g.Titel = objRea["Titel"].ToString();
                        g.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);

                        if (objRea["Financieringsjaar"] != DBNull.Value)
                        {
                            g.Financieringsjaar = objRea["Financieringsjaar"].ToString();
                        }

                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            g.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }

                        returnlist.Add(g);
                    }
                }
            }
            return returnlist;
        }
        // Aanvragen opslaan
        public static void SaveAanvraag(Aanvraag aanvraag, bool insert)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query;

                    if (insert)
                    {
                        // Insert query
                        query = @"
                    INSERT INTO Aanvraag (Gebruiker, AfdelingId, DienstId, Aanvraagmoment, Titel, Omschrijving,
                        FinancieringsTypeId, InvesteringsTypeId, PrioriteitId, Financieringsjaar,
                        StatusAanvraagId, KostenplaatsId, PrijsIndicatieStuk, AantalStuk, AankoperId, RichtperiodeId, 
                        BudgetToegekend, OpmerkingenResultaat)
                    VALUES (@Gebruiker, @AfdelingId, @DienstId, @Aanvraagmoment, @Titel, @Omschrijving,
                        @FinancieringsTypeId, @InvesteringsTypeId, @PrioriteitId, @Financieringsjaar,
                        @StatusAanvraagId,@KostenplaatsId, @PrijsIndicatieStuk, @AantalStuk, @AankoperId, @RichtperiodeId,
                        @BudgetToegekend, @OpmerkingenResultaat);";
                    }
                    else
                    {
                        // Update query
                        query = @"
                    UPDATE Aanvraag
                    SET Gebruiker = @Gebruiker, AfdelingId = @AfdelingId, DienstId = @DienstId,
                        Aanvraagmoment = @Aanvraagmoment, Titel = @Titel, Omschrijving = @Omschrijving,
                        FinancieringsTypeId = @FinancieringsTypeId, InvesteringsTypeId = @InvesteringsTypeId,
                        PrioriteitId = @PrioriteitId, Financieringsjaar = @Financieringsjaar,
                        StatusAanvraagId = @StatusAanvraagId,
                        KostenplaatsId = @KostenplaatsId,
                        PrijsIndicatieStuk = @PrijsIndicatieStuk, AantalStuk = @AantalStuk, AankoperId = @AankoperId,
                        RichtperiodeId = @RichtperiodeId,
                        BudgetToegekend = @BudgetToegekend,
                        OpmerkingenResultaat = @OpmerkingenResultaat
                    WHERE Id = @Id;";
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Gebruiker", aanvraag.Gebruiker);
                        command.Parameters.AddWithValue("@AfdelingId", aanvraag.AfdelingId);
                        command.Parameters.AddWithValue("@DienstId", aanvraag.DienstId);
                        command.Parameters.AddWithValue("@Aanvraagmoment", aanvraag.Aanvraagmoment);
                        command.Parameters.AddWithValue("@Titel", aanvraag.Titel);
                        command.Parameters.AddWithValue("@Omschrijving", aanvraag.Omschrijving);
                        command.Parameters.AddWithValue("@FinancieringsTypeId", aanvraag.FinancieringsTypeId);
                        command.Parameters.AddWithValue("@InvesteringsTypeId", aanvraag.InvesteringsTypeId);
                        command.Parameters.AddWithValue("@PrioriteitId", aanvraag.PrioriteitId);
                        command.Parameters.AddWithValue("@Financieringsjaar", aanvraag.Financieringsjaar);
                        command.Parameters.AddWithValue("@StatusAanvraagId", aanvraag.StatusAanvraagId);
                        command.Parameters.AddWithValue("@KostenplaatsId", aanvraag.KostenplaatsId);
                        command.Parameters.AddWithValue("@PrijsIndicatieStuk", aanvraag.PrijsIndicatieStuk);
                        command.Parameters.AddWithValue("@AantalStuk", aanvraag.AantalStuk);
                        command.Parameters.AddWithValue("@AankoperId", aanvraag.AankoperId);
                        command.Parameters.AddWithValue("@RichtperiodeId", aanvraag.RichtperiodeId);
                        command.Parameters.AddWithValue("@BudgetToegekend", aanvraag.BudgetToegekend);
                        command.Parameters.AddWithValue("@OpmerkingenResultaat", aanvraag.OpmerkingenResultaat);

                        if (insert)
                        {
                            aanvraag.Id = Convert.ToInt32(command.ExecuteScalar());

                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Id", aanvraag.Id);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Er is een fout opgetreden bij het opslaan van de Aanvraag, probeer het nog eens.");
                throw;
            }
        }
        public static void DeleteAanvraag(Aanvraag aanvraag)
        {
            if (aanvraag.Id == 0)
            {
                throw new ArgumentNullException("De aanvraag die je wil verwijderen is onbestaande.");
            }
            using (SqlConnection objCn = new SqlConnection())
            {

                objCn.ConnectionString = ConnectionString;

                using (SqlCommand ObjCmd = new SqlCommand())
                {
                    ObjCmd.Connection = objCn;
                    ObjCmd.CommandText = "delete from Aanvraag where Id = @Id";
                    ObjCmd.Parameters.AddWithValue("Id", aanvraag.Id);

                    objCn.Open();

                    ObjCmd.ExecuteNonQuery();
                }
            }
        }
        public static List<Aanvraag> GetGebruikerAsc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Gebruiker asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetGebruikerDesc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Gebruiker desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetTitelAsc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Titel asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetTitelDesc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Titel desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetStatusAanvraagAsc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by sa.Naam asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetStatusAanvraagDesc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by sa.Naam desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetAanvraagmomentAsc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Aanvraagmoment asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetAanvraagmomentDesc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Aanvraagmoment desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetPlanningsdatumAsc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.PlanningsDatum asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetPlanningsdatumDesc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.PlanningsDatum desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetFinancieringsjaarAsc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Financieringsjaar asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetFinancieringsjaarDesc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by a.Financieringsjaar desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetKostenplaatstAsc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by k.Naam asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetKostenplaatstDesc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by k.Naam desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetBedragAsc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, a.AantalStuk * a.PrijsIndicatieStuk as bedrag, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by bedrag asc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetBedragDesc()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, a.AantalStuk * a.PrijsIndicatieStuk as bedrag, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId order by bedrag desc";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }
        public static List<Aanvraag> GetAanvragenInaanvraagOfGoedgekeurd()
        {
            List<Aanvraag> returnlist = null;

            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select a.Id, a.Gebruiker, a.Aanvraagmoment, a.Titel, a.Financieringsjaar, a.PlanningsDatum, sa.Naam as StatusAanvraag, sa.Id as StatusAanvraagId, a.AantalStuk, a.PrijsIndicatieStuk, k.Naam as Kostenplaats from Aanvraag a inner join StatusAanvraag sa on sa.Id = a.StatusAanvraagId inner join Kostenplaats k on k.Id = a.KostenplaatsId where sa.Naam = 'In aanvraag' or sa.Naam = 'Goedgekeurd' order by a.Aanvraagmoment asc ";
                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();

                    Aanvraag a;

                    while (objRea.Read())
                    {
                        if (returnlist == null)
                        {
                            returnlist = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Id = Convert.ToInt32(objRea["Id"]);
                        a.Gebruiker = objRea["Gebruiker"].ToString();
                        a.Aanvraagmoment = Convert.ToDateTime(objRea["Aanvraagmoment"]);
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
                        a.StatusAanvraagId = Convert.ToInt32(objRea["StatusAanvraagId"]);
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        a.Kostenplaats = objRea["Kostenplaats"].ToString();
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value && objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.BudgetToegekend = Convert.ToInt32(objRea["PrijsIndicatieStuk"]) * Convert.ToInt32(objRea["AantalStuk"]);
                        }

                        returnlist.Add(a);
                    }
                }
            }
            return returnlist;
        }

        public static decimal GetTotaalPrijsPerRichtperiodeEnFinancieringsjaar(int richtperiodeId, string financieringsjaar)
        {
            decimal ret = 0;


            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT SUM(PrijsIndicatieStuk * AantalStuk) As TotaalBedrag from Aanvraag WHERE Financieringsjaar = @Jaar AND RichtperiodeId = @RichtperiodeId AND StatusAanvraagId = 4 group by RichtperiodeId order by RichtperiodeId asc";
                    objCmd.Parameters.AddWithValue("@Jaar", financieringsjaar);
                    objCmd.Parameters.AddWithValue("@RichtperiodeId", richtperiodeId);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();
                    if (objRea.Read())
                    {
                        ret = Convert.ToDecimal(objRea["TotaalBedrag"]);
                    }
                }

            }
            return ret;
        }
        public static List<Aanvraag> GetTitelEnTotaalprijsPerRichtperiodeEnFinancieringsjaar(int richtperiodeId, string financieringsjaar)
        {
           List<Aanvraag> smt = null;
            using (SqlConnection objCn = new SqlConnection())
            {
                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {
                    objCmd.Connection = objCn;
                    objCmd.CommandText = "SELECT (PrijsIndicatieStuk * Aantalstuk) as Totaal , Titel from Aanvraag WHERE Financieringsjaar = @Jaar AND RichtperiodeId = @RichtperiodeId AND StatusAanvraagId = 4";
                    objCmd.Parameters.AddWithValue("@Jaar", financieringsjaar);
                    objCmd.Parameters.AddWithValue("@RichtperiodeId", richtperiodeId);

                    objCn.Open();
                    Aanvraag a;
                   

                    SqlDataReader objRea = objCmd.ExecuteReader();
                   while(objRea.Read())
                    {
                        if (smt == null)
                        {
                            smt = new List<Aanvraag>();
                        }
                        a = new Aanvraag();
                        a.Titel = objRea["Titel"].ToString();
                        if (objRea["AantalStuk"] != DBNull.Value)
                        {
                            a.AantalStuk = Convert.ToInt32(objRea["AantalStuk"]);
                        }
                        if (objRea["PrijsIndicatieStuk"] != DBNull.Value)
                        {
                            a.PrijsIndicatieStuk = Convert.ToDecimal(objRea["PrijsIndicatieStuk"]);
                        }
                        smt.Add(a);
                    }
                   
                }
            }
            return smt;
        }

    }
}
