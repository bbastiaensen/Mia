using MiaLogic.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Object
{
    public class Aanvraag : StatusAanvraag
    {
        public int Id { get; set; }
        public string Gebruiker { get; set; }
        public int AfdelingId { get; set; }
        public int DienstId { get; set; }
        public DateTime Aanvraagmoment { get; set; }
        public string Titel { get; set; }
        public string Omschrijving { get; set; }
        public int FinancieringsTypeId { get; set; }
        public int InvesteringsTypeId { get; set; }
        public int PrioriteitId { get; set; }
        public string Financieringsjaar { get; set; }
        public DateTime Planningsdatum { get; set; }
        public int StatusAanvraagId { get; set; }
        public string StatusAanvraag { get; set; }
        public string Kostenplaats { get; set; }
        public int KostenplaatsId { get; set; }
        public decimal PrijsIndicatieStuk { get; set; }
        public int AantalStuk { get; set; } //saldo
        public int AankoperId { get; set; }
        public decimal BudgetToegekend { get; set; }
        public decimal ExtraBedrag { get; set; }
        public string OpmerkingenResultaat { get; set; }

        public int RichtperiodeId { get; set; }
        public decimal ExtraBudget { get; set; }



   






    }
}

