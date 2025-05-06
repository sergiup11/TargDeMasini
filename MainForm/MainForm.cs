
using System;
using System.Windows.Forms;
using TargDeMasini;

namespace TargDeMasini
{
    public partial class MainForm : Form
    {
        private TargAuto targAuto = new TargAuto();
        //private const string filePath = @"C:\Users\sergi\Desktop\test\1\PIU\mx\date.txt";
        private const string filePath = @"C:\Users\Lenovo\Desktop\a\date.txt";


        public MainForm()
        {
            InitializeComponent();

            // butoane
            btnAdaugaMasina.Click += BtnAdaugaMasina_Click;
            btnAfiseazaMasini.Click += BtnAfiseazaMasini_Click;
            btnCautaMasina.Click += BtnCautaMasina_Click;
            btnStergeMasina.Click += BtnStergeMasina_Click;
            btnSalveazaFisier.Click += BtnSalveazaFisier_Click;
            btnCitesteFisier.Click += BtnCitesteFisier_Click;
        }

        private void BtnAdaugaMasina_Click(object sender, EventArgs e)
        {
            try
            {
                string marca = Prompt("Marca:");
                if (string.IsNullOrWhiteSpace(marca)) return;

                string model = Prompt("Model:");
                if (string.IsNullOrWhiteSpace(model)) return;

                string anText = Prompt("An fabricatie:");
                if (!int.TryParse(anText, out int an)) { MessageBox.Show("An invalid!"); return; }

                string pretText = Prompt("Pret:");
                if (!decimal.TryParse(pretText, out decimal pret)) { MessageBox.Show("Pret invalid!"); return; }

                string combustibilText = Prompt("Combustibil (0:Benzina, 1:Motorina, 2:Electric, 3:Hibrid):");
                if (!Enum.TryParse(combustibilText, out TipCombustibil combustibil)) { MessageBox.Show("Combustibil invalid!"); return; }

                var masina = new Masina(marca, model, an, pret, combustibil);
                targAuto.AdaugaMasina(masina);
                MessageBox.Show("Mașina a fost adăugată.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}");
            }
        }

        private void BtnAfiseazaMasini_Click(object sender, EventArgs e)
        {
            targAuto.AfiseazaMasini();
        }

        private void BtnCautaMasina_Click(object sender, EventArgs e)
        {
            string marca = Prompt("Marca pentru căutare:");
            if (!string.IsNullOrWhiteSpace(marca))
                targAuto.CautaMasina(marca);
        }

        private void BtnStergeMasina_Click(object sender, EventArgs e)
        {
            try
            {
                string marca = Prompt("Marca mașinii de șters:");
                if (string.IsNullOrWhiteSpace(marca)) return;

                string model = Prompt("Modelul mașinii de șters:");
                if (string.IsNullOrWhiteSpace(model)) return;

                string pretText = Prompt("Prețul mașinii de șters:");
                if (!decimal.TryParse(pretText, out decimal pret)) { MessageBox.Show("Preț invalid!"); return; }

                string combustibilText = Prompt("Combustibilul mașinii de șters (0:Benzina, 1:Motorina, 2:Electric, 3:Hibrid):");
                if (!Enum.TryParse(combustibilText, out TipCombustibil combustibil)) { MessageBox.Show("Combustibil invalid!"); return; }

                targAuto.StergeMasina(marca, model, pret, combustibil);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}");
            }
        }


        private void BtnSalveazaFisier_Click(object sender, EventArgs e)
        {
            targAuto.SalveazaInFisier();
        }

        private void BtnCitesteFisier_Click(object sender, EventArgs e)
        {
            targAuto.CitesteDinFisier();
        }

        
        private string Prompt(string text)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(text, "Input", "");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                targAuto.CitesteDinFisier();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la citirea datelor din fișier: {ex.Message}");
            }
        }
    }
}
