﻿using System;
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
        public string Planningsdatum { get; set; }
        public string StatusAanvraag { get; set; }
        public string Bedrag { get; set; }
        public string Kostenplaats { get; set; }
    }
}
