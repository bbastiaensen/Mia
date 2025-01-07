using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Object
{
    public class Goedkeuring : StatusAanvraag
    {
        public int Id { get; set; }
        public string Gebruiker { get; set; }
        public int AfdelingId { get; set; }
        public int DienstId { get; set; }
        public DateTime Aanvraagmoment { get; set; }
        public string Titel { get; set; }
        public string Omschrijving { get; set; }
        public int FinancieringsTypeId { get; set; }
        public string Financieringsjaar { get; set; }
        public int StatusAanvraagId { get; set; }
        public decimal PrijsIndicatieStuk { get; set; }
        public int AantalStuk { get; set; }
        public decimal Bedrag { get; set; }
    }
}
