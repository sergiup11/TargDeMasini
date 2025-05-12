
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

                // Selectează combustibilul din checkbox-uri
                TipCombustibil? combustibil = null;
                int checkedCount = 0;
                if (checkBoxBenzina.Checked) { combustibil = TipCombustibil.Benzina; checkedCount++; }
                if (checkBoxMotorina.Checked) { combustibil = TipCombustibil.Motorina; checkedCount++; }
                if (checkBoxElectric.Checked) { combustibil = TipCombustibil.Electric; checkedCount++; }
                if (checkBoxHibrid.Checked) { combustibil = TipCombustibil.Hibrid; checkedCount++; }

                if (checkedCount != 1)
                {
                    MessageBox.Show("Selectează un singur tip de combustibil!");
                    return;
                }

                var masina = new Masina(marca, model, an, pret, combustibil.Value, dateTimePickerDataAdaugare.Value);
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

                // Selectează combustibilul din checkbox-uri
                TipCombustibil? combustibil = null;
                int checkedCount = 0;
                if (checkBoxBenzina.Checked) { combustibil = TipCombustibil.Benzina; checkedCount++; }
                if (checkBoxMotorina.Checked) { combustibil = TipCombustibil.Motorina; checkedCount++; }
                if (checkBoxElectric.Checked) { combustibil = TipCombustibil.Electric; checkedCount++; }
                if (checkBoxHibrid.Checked) { combustibil = TipCombustibil.Hibrid; checkedCount++; }

                if (checkedCount != 1)
                {
                    MessageBox.Show("Selectează un singur tip de combustibil pentru ștergere!");
                    return;
                }

                targAuto.StergeMasina(marca, model, pret, combustibil.Value);
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
        private void CheckBoxCombustibil_CheckedChanged(object sender, EventArgs e)
        {
            // Permite selectarea unui singur tip de combustibil
            var changed = sender as CheckBox;
            if (changed.Checked)
            {
                // Debifează celelalte
                if (changed != checkBoxBenzina) checkBoxBenzina.Checked = false;
                if (changed != checkBoxMotorina) checkBoxMotorina.Checked = false;
                if (changed != checkBoxElectric) checkBoxElectric.Checked = false;
                if (changed != checkBoxHibrid) checkBoxHibrid.Checked = false;
            }

            // Determină tipul selectat
            TipCombustibil? combustibil = null;
            if (checkBoxBenzina.Checked) combustibil = TipCombustibil.Benzina;
            if (checkBoxMotorina.Checked) combustibil = TipCombustibil.Motorina;
            if (checkBoxElectric.Checked) combustibil = TipCombustibil.Electric;
            if (checkBoxHibrid.Checked) combustibil = TipCombustibil.Hibrid;

            // Filtrează și afișează
            AfiseazaMasiniFiltrate(combustibil);
        }

        private void AfiseazaMasiniFiltrate(TipCombustibil? combustibil)
        {
            var masini = targAuto.GetMasini();
            if (combustibil.HasValue)
                masini = masini.FindAll(m => m.Combustibil == combustibil.Value);

            dataGridViewMasini.DataSource = null;
            dataGridViewMasini.DataSource = masini;
        }
        private void RadioDisponibilitate_CheckedChanged(object sender, EventArgs e)
        {
            FiltreazaDupaDataSiDisponibilitate();
        }
        private void FiltreazaDupaDataSiDisponibilitate()
        {
            var masini = targAuto.GetMasini();
            DateTime dataSelectata = dateTimePickerDataAdaugare.Value;

            if (radioDisponibile.Checked)
            {
                // Asigură-te că Masina are proprietatea DataAdaugare!
                masini = masini.FindAll(m => m.DataAdaugare.Date == dataSelectata.Date);
            }
            // Dacă e bifat "Toate", nu filtrăm după dată

            dataGridViewMasini.DataSource = null;
            dataGridViewMasini.DataSource = masini;
        }

      
    }
}
