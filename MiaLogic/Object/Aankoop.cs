using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaLogic.Object
{
    public class Aankoop
    {
        public int Id {  get; set; }
        public  string Titel { get; set; }
        public int BTWPercentage { get; set; }
        public int BedragExBtw { get; set; }
        public int StatusAankoopId { get; set; }
        public DateTime BestellingsDatum { get; set; }
        public DateTime VerwachteLeveringsDatum { get; set; }
        public DateTime EffectieveLeveringsDatum { get; set; }
        public int LeverancierId { get; set; }
        public int AanvraagId { get; set; }
    }
}
