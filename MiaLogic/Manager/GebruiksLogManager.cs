using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Manager
{
    public static class GebruiksLogManager
    {
        public static string ConnectionString { get; set; }

        public static List<GebruiksLog> GetGebruiksLogs()
        {
            List<GebruiksLog> gebruiksLogs = null;

            throw new NotImplementedException();

            return gebruiksLogs;
        }

        public static GebruiksLog GetGebruiksLog(int gebruiksLogId)
        {
            GebruiksLog gebruiksLog = null;

            throw new NotImplementedException();

            return gebruiksLog;
        }

        public static void SaveGebruiksLog(GebruiksLog gebruiksLog, bool insert)
        {
            throw new NotImplementedException();
        }

        public static void DeleteGebruiksLog(GebruiksLog gebruiksLog)
        {
            throw new NotImplementedException();
        }
    }
}
