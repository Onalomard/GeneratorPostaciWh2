using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorPostaciWh2.Encje
{
    public class Specjalizacja
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public Umiejetnosc Umiejetnosc { get; set; }
        public int UmiejetnoscId { get; set; }
    }
}
