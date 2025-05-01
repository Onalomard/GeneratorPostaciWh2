using System.Diagnostics;
using GeneratorPostaciWh2.Encje;
using GeneratorPostaciWh2.Services;
using Microsoft.EntityFrameworkCore;

namespace GeneratorPostaciWh2
{
    public partial class Form1 : Form
    {
        private GeneratorContext _context;
        private PostacService _postacService;
        private List<Rasa> _rasy;
        private List<Profesja> _profesje;

        public Form1()
        {
            InitializeComponent();
            InitDatabase();
        }

        private async void InitDatabase()
        {
            
            _context = new GeneratorContext();
            _postacService = new PostacService(_context);

            _rasy = await _context.Rasy.OrderBy(r => r.Name).ToListAsync();
            _profesje = await _context.Profesje.OrderBy(p => p.Name).ToListAsync();

            comboRasa.DataSource = _rasy;
            comboRasa.DisplayMember = "Name";
            comboRasa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboRasa.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboProfesja.DataSource = _profesje;
            comboProfesja.DisplayMember = "Name";
            comboProfesja.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboProfesja.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private async void buttonGeneruj_Click(object sender, EventArgs e)
        {
            if (comboRasa.SelectedItem is not Rasa rasa || comboProfesja.SelectedItem is not Profesja profesja)
            {
                MessageBox.Show("Wybierz rasę i profesję.");
                return;
            }

            string imie = txtImie.Text.Trim();
            if (string.IsNullOrWhiteSpace(imie))
            {
                MessageBox.Show("Podaj imię postaci.");
                return;
            }

            using SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Plik PDF|*.pdf",
                FileName = $"Karta_{imie}.pdf"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var postac = await _postacService.StworzPostacAsync(rasa.Id, profesja.Id, imie);
                var pdfService = new PdfService(Path.Combine(Application.StartupPath, "Resources", "wfrp2_edytowalna (1).pdf"));
                pdfService.WypelnijKartePostaci(postac, saveDialog.FileName);
                MessageBox.Show("Postać wygenerowana i zapisana jako PDF!");

                Process.Start("explorer", $"\"{saveDialog.FileName}\"");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtImie_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
