namespace GeneratorPostaciWh2.Encje
{
    public abstract class Wyposazenie
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string? Opis { get; set; }
        public List<Postac> Postacie { get; set; } = new List<Postac>();
        public List<Profesja> Profesje { get; set; } = new();

        public abstract string TypWyposazenia();  // Metoda abstrakcyjna do rozróżniania typów
    }
}