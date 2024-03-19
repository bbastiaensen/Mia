using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public class FinancieringsjaarManager
    {
        public static string ConnectionString { get; set; }
        public static List<string> GetFinancieringsjaren()
        {
            List<string> financieringsjaren = new List<string>();

            // Adding financial years based on the current year
            int currentYear = DateTime.Now.Year;
            for (int i = 0; i < 5; i++)
            {
                string startingYear = (currentYear + i).ToString();
                financieringsjaren.Add(startingYear);
            }

            return financieringsjaren;
        }
    }
}
