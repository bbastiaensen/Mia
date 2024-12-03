using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Object
{
    public class Goedkeuring  
    {
        public string Gebruiker { get; set; }
        public DateTime Aanvraagmoment { get; set; }
        public string Titel { get; set; }
        public string Financieringsjaar { get; set; }
        public decimal Bedrag { get; set; }
    }
}
