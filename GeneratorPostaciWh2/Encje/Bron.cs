using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorPostaciWh2.Encje
{
    public class Bron : Wyposazenie
    {
        public List<string> Cechy { get; set; } = new List<string>();
        public string Obrazenia { get; set; }
        public override string TypWyposazenia()
        {
            return "Broń";
        }
    }
}
