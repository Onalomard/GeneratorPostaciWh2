using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorPostaciWh2.Encje
{
    public class Pancerz : Wyposazenie
    {
        public LokalizacjaCiala Lokalizacje { get; set; }
        public int PunktyZbroji{ get; set; }
        public override string TypWyposazenia()
        {
            return "Pancerz";
        }
    }
}
