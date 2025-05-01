using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorPostaciWh2.Encje
{
    [Flags]
    public enum LokalizacjaCiala
    {
        Glowa = 1,
        Tors = 2,
        Ramiona = 4,
        Nogi = 8,
        Wszystko = Glowa | Tors | Ramiona | Nogi
    }
}
