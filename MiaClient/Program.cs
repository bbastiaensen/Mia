using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    internal static class Program
    {
        //Globale variabelen die gebruikt worden in de volledige toepassing
        public static string Gebruiker { get; set; }
        public static bool IsAanvrager { get; set; }
        public static bool IsAankoper { get; set; }
        public static bool IsGoedkeurder { get; set; }
        public static bool IsSysteem { get; set; }



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mdiMia());
        }
    }
}
