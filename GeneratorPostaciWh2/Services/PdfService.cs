using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorPostaciWh2.Encje;
using iTextSharp.text.pdf;

namespace GeneratorPostaciWh2.Services
{
    public class PdfService
    {
        private readonly string _sciezkaSzablonu;

        public PdfService(string sciezkaSzablonu)
        {
            _sciezkaSzablonu = sciezkaSzablonu;
        }

        public void WypelnijKartePostaci(Postac postac, string sciezkaDocelowa)
        {

            using (var reader = new PdfReader(_sciezkaSzablonu))
            using (var fs = new FileStream(sciezkaDocelowa, FileMode.Create, FileAccess.Write))
            using (var stamper = new PdfStamper(reader, fs))
            {
                var form = stamper.AcroFields;

                // Informacje ogólne
                form.SetField("Imię", postac.Imie);
                form.SetField("Rasa", postac.Rasa.Name);
                form.SetField("Obecna profesja", postac.Profesja.Name);

                // Statystyki
                form.SetField("Cechy.0.0.0", postac.WW.ToString());
                form.SetField("Cechy.0.1.0", postac.US.ToString());
                form.SetField("Cechy.0.2.0", postac.K.ToString());
                form.SetField("Cechy.0.3.0", postac.Odp.ToString());
                form.SetField("Cechy.0.4.0", postac.Zr.ToString());
                form.SetField("Cechy.0.5.0", postac.Int.ToString());
                form.SetField("Cechy.0.6.0", postac.Sw.ToString());
                form.SetField("Cechy.0.7.0", postac.Ogd.ToString());
                form.SetField("Cechy.0.2.1", (postac.K / 10).ToString());
                form.SetField("Cechy.0.3.1", (postac.Odp / 10).ToString());

                //Schemat rozwoju
                if (postac.Profesja.Ww.HasValue)
                    form.SetField("Cechy.1.0.0", "+" + postac.Profesja.Ww.Value.ToString());

                if (postac.Profesja.Us.HasValue)
                    form.SetField("Cechy.1.1.0", "+" + postac.Profesja.Us.Value.ToString());

                if (postac.Profesja.K.HasValue)
                    form.SetField("Cechy.1.2.0", "+" + postac.Profesja.K.Value.ToString());

                if (postac.Profesja.Odp.HasValue)
                    form.SetField("Cechy.1.3.0", "+" + postac.Profesja.Odp.Value.ToString());

                if (postac.Profesja.Zr.HasValue)
                    form.SetField("Cechy.1.4.0", "+" + postac.Profesja.Zr.Value.ToString());

                if (postac.Profesja.Int.HasValue)
                    form.SetField("Cechy.1.5.0", "+" + postac.Profesja.Int.Value.ToString());

                if (postac.Profesja.Sw.HasValue)
                    form.SetField("Cechy.1.6.0", "+" + postac.Profesja.Sw.Value.ToString());

                if (postac.Profesja.Ogd.HasValue)
                    form.SetField("Cechy.1.7.0", "+" + postac.Profesja.Ogd.Value.ToString());


                form.SetField("Cechy.0.7.1", postac.Pp.ToString());
                form.SetField("Cechy.0.0.1", (postac.A + postac.Profesja.A).ToString());
                form.SetField("Cechy.0.1.1", postac.Hp.ToString());
                form.SetField("Cechy.0.5.1", postac.Profesja.Mag.ToString());

                var umiejetnosciCheckBox = new Dictionary<string, string>
                {
                    { "Charakteryzacja", "Check Box12.0.0.0" },
                    { "Dowodzenie", "Check Box12.0.0.1" },
                    { "Hazard", "Check Box12.0.0.2" },
                    { "Jezdziectwo", "Check Box12.0.0.3" },
                    { "Mocna głowa", "Check Box12.0.0.4" },
                    { "Opieka nad zwierzetami", "Check Box12.0.0.5.0" },
                    { "Plotkowanie", "Check Box12.0.0.6.0" },
                    { "Plywanie", "Check Box12.0.0.7.0" },
                    { "Powozenie", "Check Box12.0.0.8.0" },
                    { "Przekonywanie", "Check Box12.0.0.9.0" },
                    { "Przeszukiwanie", "Check Box12.0.0.10.0" },
                    { "Skradanie sie", "Check Box12.0.0.11.0" },
                    { "Spostrzegawczosc", "Check Box12.0.0.12.0" },
                    { "Sztuka przetrwania", "Check Box12.0.0.13.0" },
                    { "Targowanie", "Check Box12.0.0.14.0" },
                    { "Ukrywanie sie", "Check Box12.0.0.15.0" },
                    { "Wioslarstwo", "Check Box12.0.0.16.0" },
                    { "Wspinaczka", "Check Box12.0.0.17.0" },
                    { "Wycena", "Check Box12.0.0.18.0" },
                    { "Zastraszanie", "Check Box12.0.0.19.0" }
                };


                // Umiejętności (np. wypisywane w wolnym polu tekstowym)
                int j = 1;

                for (int i = 0; i < postac.Umiejetnosci.Count; i++)
                {
                    var um = postac.Umiejetnosci[i];
                    var nazwaPola = um.Imie;
                    if (umiejetnosciCheckBox.ContainsKey(um.Imie))
                    {
                        // Jeśli pole o nazwie umiejętności istnieje — zaznacz je
                        form.SetField(umiejetnosciCheckBox[um.Imie], "Yes");

                    }
                    else
                    {
                        form.SetField($"zaawansowane {j}", um.Imie);
                        form.SetField($"Check Box12.0.0.{4 + j}.1", "Yes");
                        j++;

                    }
                }

                // Zdolności (np. wypisywane w wolnym polu tekstowym)
                for (int i = 0; i < postac.Zdolnosci.Count; i++)
                {
                    var zd = postac.Zdolnosci[i];
                    var zdolnoscNazwa = zd.Imie;
                    var zdolnoscOpis = zd.Opis;
                    form.SetField($"ZdolnoÊç {i + 1}", zdolnoscNazwa);
                    form.SetField($"Opis {i + 1}", zdolnoscOpis);
                }
                int b = 0;
                int o = 1;
                int p = 1;
                // Wyposażenie (np. wypisywane w wolnym polu tekstowym)
                for (int i = 0; i < postac.Wyposazenie.Count; i++)
                {
                    var wy = postac.Wyposazenie[i];
                    if (wy is Bron bron)
                    {
                        form.SetField($"Text9.{b}.0", bron.Imie);
                        form.SetField($"Broń.{b}.2", bron.Obrazenia);
                        form.SetField($"Text9.{b}.1", string.Join(',', bron.Cechy));
                        b++;
                    }
                    else if (wy is Pancerz pancerz)
                    {
                        var mapaPol = new Dictionary<LokalizacjaCiala, List<string>>
    {
        { LokalizacjaCiala.Glowa, new List<string> { "PZ.0.0" } },
        { LokalizacjaCiala.Tors, new List<string> { "PZ.0.1" } },
        { LokalizacjaCiala.Ramiona, new List<string> { "PZ.1.0", "PZ.1.1" } },
        { LokalizacjaCiala.Nogi, new List<string> { "PZ.2.1", "PZ.2.0" } }
    };

                        foreach (var para in mapaPol)
                        {
                            if (pancerz.Lokalizacje.HasFlag(para.Key))
                            {
                                foreach (var nazwaPola in para.Value)
                                {
                                    form.SetField(nazwaPola, pancerz.PunktyZbroji.ToString());
                                }
                            }
                        }
                        form.SetField($"Pancerz{p}.0", pancerz.Imie);
                        form.SetField($"Pancerz{p}.1", pancerz.Lokalizacje.ToString());
                        form.SetField($"Pobc{p}.1", pancerz.PunktyZbroji.ToString());
                        p++;
                    }
                    else
                    {
                        form.SetField($"Przedmiot{o}", wy.Imie);
                        form.SetField($"Opis {o}_2", wy.Opis);
                        o++;
                    }



                }
            }






        }
    }

}
