using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Object
{
    public class GebruiksLog
    {
        public int Id { get; set; }
        public string Gebruiker { get; set; }
        public string OmschrijvingActie { get; set; }
        public DateTime TijdstipActie { get; set; }
    }
}
