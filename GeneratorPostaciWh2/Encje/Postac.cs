using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorPostaciWh2.Encje
{
    public class Postac
    {
        
        public int Id { get; set; }
        public string Imie { get; set; }
        public Rasa Rasa { get; set; }
        public int RasaId { get; set; }
        public Profesja Profesja { get; set; }
        public int ProfesjaId {  get; set; }
        // Statystyki
        public int WW { get; set; }
        public int US { get; set; }
        public int K { get; set; }
        public int Odp { get; set; }
        public int Zr { get; set; }
        public int Int { get; set; }
        public int Sw { get; set; }
        public int Ogd { get; set; }
        public int A { get; set; }
        public int Hp { get; set; }
        public int Pp { get; set; }
        public int Mag { get; set; }

        public List<Umiejetnosc> Umiejetnosci { get; set; } = new();
        public List<Zdolnosc> Zdolnosci { get; set; } = new();
        public List<Wyposazenie> Wyposazenie { get; set; } = new();

    }
}
