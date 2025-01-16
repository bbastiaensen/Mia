using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class BudgetManager
    {
        public static string ConnectionString { get; set; }
        public static Budget GetBudget(int maand, int jaar)
        {
            Budget budget = null;
            using (SqlConnection objCn = new SqlConnection())
            {

                objCn.ConnectionString = ConnectionString;

                using (SqlCommand objCmd = new SqlCommand())
                {

                    objCmd.Connection = objCn;
                    objCmd.CommandText = "select sum(Prijsindicatie * AantalStuk) as Totaal from Aanvraag where Financieringsjaar = @Jaar AND RichtperiodeId = @Maand AND StatusAanvraagId = 4;";
                    objCmd.Parameters.AddWithValue("@Jaar", jaar);
                    objCmd.Parameters.AddWithValue("@Maand", maand);

                    objCn.Open();

                    SqlDataReader objRea = objCmd.ExecuteReader();
                    if (objRea.Read()) 
                    {
                        budget = new Budget();
                        budget.MaandId = Convert.ToInt32(objRea["RichtPeriodeId"]);
                        budget.JaarId = Convert.ToInt32(objRea["FinancieringsJaar"]);
                        budget.Totaal = Convert.ToInt32(objRea["Totaal"]);
                    }
                }
                
            }
            return budget;
        }
    }
}
