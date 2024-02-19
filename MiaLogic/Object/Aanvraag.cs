using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Object
{
    public class Aanvraag
    {
        public string Gebruiker { get; set; }
        public string Aanvraagmoment { get; set; }
        public string Titel { get; set; }
        public string Financieringsjaar { get; set; }
        public DateTime Planningsdatum { get; set; }
        public string StatusAanvraag { get; set; }
        public string Kostenplaats { get; set; }
        public decimal PrijsIndicatieStuk { get; set; }
        public int AantalStuk { get; set; }
    }

    public class Afdeling
    {
        public int Id { get; set; }
        public string Naam { get; set; }
    }

    public class Dienst
    {
        public int Id { get; set; }
        public string Naam { get; set; }
    }

    public class Prioriteit
    {
        public int Id { get; set; }
        public string Naam { get; set; }
    }
    public class Financiering
    {
        public int Id { get; set; }
        public string Naam { get; set; }
    }

    public class Investering
    {
        public int Id { get; set; }
        public string Naam { get; set; }
    }

    public class Kostenplaats
    {
        public int Id { get; set; }
        public string Naam { get; set; }
    }
    public class WieKooptHet
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
    }
}
