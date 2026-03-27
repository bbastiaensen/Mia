using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaLogic.Manager
{
    public class FinancieringsjaarManager
    {
        public static string ConnectionString { get; set; }
        public static List<string> GetFinancieringsjaren()
        {
            List<AankoopOverzichtItem> jaren2 = AankoopManager.GetAllAankopen();
            HashSet<string> jaren = new HashSet<string>();

            foreach (var z in jaren2)
            {
                if (z.Financieringsjaar != "")
                {
                    jaren.Add(z.Financieringsjaar);
                }
            }

            List<string> financieringsjaren = new List<string>(jaren);
            financieringsjaren.Sort();

            return financieringsjaren;
        }

    }
}
