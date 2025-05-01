namespace GeneratorPostaciWh2.Encje
{
    public class Profesja
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Ww { get; set; }
        public int? Us { get; set; }
        public int? K { get; set; }
        public int? Odp { get; set; }
        public int? Zr { get; set; }
        public int? Int { get; set; }
        public int? Sw { get; set; }
        public int? Ogd { get; set; }
        public int? Hp { get; set; }
        public int? A {  get; set; }
        public int? Mag { get; set; }
        public List<Postac> Postacie { get; set; } = new List<Postac>();
        public List<Umiejetnosc> Umiejetnosci { get; set; } = new();
        public List<Zdolnosc> Zdolnosci { get; set; } = new();
        public List<Wyposazenie> Wyposazenie { get; set; } = new();

    }
}