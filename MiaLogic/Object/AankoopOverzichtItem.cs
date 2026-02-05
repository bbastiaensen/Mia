using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Object
{
    public class AankoopOverzichtItem
    {

        public int AankoopId { get; set; }

        public string Omschrijving { get; set; }
        public string Titel { get; set; }

        public string StatusAankoop { get; set; }

        public string Aankoper { get; set; }
        public string Aanvrager { get; set; }
        public DateTime Aanvraagmoment { get; set; }
        public int Id { get; set; }
        public string Financieringsjaar { get; set; }
        public string Richtperiode { get; set; }
        public decimal GoedgekeurdBedrag { get; set; }
        public decimal Saldo { get; set; }
        public decimal BudgetToegekend { get; set; }

    }
}
