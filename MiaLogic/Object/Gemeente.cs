using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        public string LandNaam { get; set; }

    }
}
