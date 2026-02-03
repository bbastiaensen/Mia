using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Object
{
    public class Gemeente
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int LandId { get; set; }
        public int Postcode { get; set; }

        public string PostcodeNaam
        {
            get { return Postcode + " - " + Naam; }
        }
    }
}
