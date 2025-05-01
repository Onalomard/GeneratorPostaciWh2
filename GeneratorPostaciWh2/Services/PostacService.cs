using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneratorPostaciWh2.Encje;
using Microsoft.EntityFrameworkCore;

namespace GeneratorPostaciWh2.Services
{
    public  class PostacService
    {
        private readonly GeneratorContext _context;
        Random rand = new Random();

        
        public PostacService(GeneratorContext context)
        {
            _context = context;
        }
        public async Task<Postac> StworzPostacAsync(int rasaId, int profesjaId, string imie)
        {
            Random rand = new Random();
            var rasa = await _context.Rasy
                 .Include(r => r.Umiejetnosci)
                .Include(r => r.Zdolnosci)
                .FirstOrDefaultAsync(r => r.Id == rasaId);

            var profesja = await _context.Profesje
                .Include(p => p.Umiejetnosci)
                .Include(p => p.Zdolnosci)
                .Include(p => p.Wyposazenie)
                .FirstOrDefaultAsync(p => p.Id == profesjaId);
            var postac = new Postac
            {
                Imie = imie,
                Rasa = rasa,
                Profesja = profesja,
                WW = Losuj(rand,rasa.Ww),
                US = Losuj(rand,rasa.Us),
                K = Losuj(rand,rasa.K),
                Odp = Losuj(rand,rasa.Odp),
                Zr = Losuj(rand,rasa.Zr),
                Int = Losuj(rand,rasa.Int),
                Sw = Losuj(rand,rasa.Sw),
                Ogd = Losuj(rand, rasa.Ogd),
                Pp = LosujPunktyPrzeznaczenia(rand,rasa.Name),
                A = 1,

                Hp = LosujHp(rasa.Hp),
                Umiejetnosci = new List<Umiejetnosc>(),
                Zdolnosci = new List<Zdolnosc>(),
                Wyposazenie = new List<Wyposazenie>()
            };
            postac.Umiejetnosci.AddRange(rasa.Umiejetnosci);
            postac.Umiejetnosci.AddRange(profesja.Umiejetnosci);

            postac.Zdolnosci.AddRange(rasa.Zdolnosci);
            postac.Zdolnosci.AddRange(profesja.Zdolnosci);

            postac.Wyposazenie.AddRange(profesja.Wyposazenie);
            return postac;
        }

        private int LosujHp(int hp)
        {
            int rzut = rand.Next(1, 11);
            if (rzut >= 1 && rzut <= 3)
            {
                return hp;
            }
            else if (rzut >= 4 && rzut <= 6)
            {
                return hp + 1;
            }
            else if (rzut >= 7 && rzut <= 9)
            {
                return hp + 2;
            }
            else 
            {
                return hp + 3;
            }
        }

        private int Losuj(Random rand,int statysytkaPoczatkowa)
        {
            // Rzut 2k10 - dwa razy losowanie liczby od 1 do 10
            int rzut1 = rand.Next(1, 11); 
            int rzut2 = rand.Next(1, 11); 
            return statysytkaPoczatkowa + rzut1 + rzut2;
        }

        private int LosujPunktyPrzeznaczenia(Random rand,string name)
        {
        
                var rzut = rand.Next(1, 11); // k10
                return name.ToLower() switch
                {
                    "czlowiek" => rzut <= 4 ? 2 : 3,
                    "elf" => rzut <= 4 ? 1 : 2,
                    "krasnolud" => rzut <= 4 ? 1 : rzut <= 7 ? 2 : 3,
                    "niziolek" => rzut <= 7 ? 2 : 3,
                    
                };
            
        }
    }
}
