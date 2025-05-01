namespace GeneratorPostaciWh2.Encje
{
    public class Zdolnosc
    {
        //,prof
        public int Id { get; set; }
        public string Imie { get; set; }
        public string? Opis { get; set; }
        public List<Postac> Postacie { get; set; } = new List<Postac>();
        public List<Rasa> Rasy { get; set; } = new();
        public List<Profesja> Profesje { get; set; } = new();
    }
}