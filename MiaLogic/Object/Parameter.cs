using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Object
{
    public class Parameter
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Waarde { get; set; }
        public string Eenheid { get; set; }

        public string Verklaring { get; set; }
    }
}
