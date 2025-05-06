    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using TargDeMasini;


    namespace TargDeMasini
    {
        public class TargAuto
        {
            private List<Masina> masini = new List<Masina>();
            //private const string filePath = @"C:\Users\Lenovo\Desktop\a\date.txt";
            private const string filePath = @"C:\Users\sergi\Desktop\test\1\PIU\mx\date.txt";

        public void AdaugaMasina(Masina masina)
            {
                masini.Add(masina);
            }

            public void AfiseazaMasini()
            {
                if (masini.Count == 0)
                {
                    MessageBox.Show("Nu exista masini inregistrate.");
                    return;
                }

                string info = "Lista masini:\n";
                foreach (var m in masini)
                {
                    info += $"{m.Marca} {m.Model}, {m.AnFabricatie}, {m.Pret} EUR, {m.Combustibil}\n";
                }

                MessageBox.Show(info);
            }

            public void CautaMasina(string marca)
            {
                var rezultate = masini.FindAll(m => m.Marca.Equals(marca, StringComparison.OrdinalIgnoreCase));

                if (rezultate.Count == 0)
                {
                    MessageBox.Show("Nu a fost gasita nicio masina cu aceasta marca.");
                    return;
                }

                string info = "Rezultate gasite:\n";
                foreach (var m in rezultate)
                {
                    info += $"{m.Marca} {m.Model}, {m.AnFabricatie}, {m.Pret} EUR, {m.Combustibil}\n";
                }

                MessageBox.Show(info);
            }

            public void StergeMasina(string marca)
            {
                var masina = masini.Find(m => m.Marca.Equals(marca, StringComparison.OrdinalIgnoreCase));
                if (masina != null)
                {
                    masini.Remove(masina);
                    MessageBox.Show("Masina a fost stearsa.");
                }
                else
                {
                    MessageBox.Show("Masina nu a fost gasita.");
                }
            }

            public void SalveazaInFisier()
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var m in masini)
                    {
                        writer.WriteLine($"{m.Marca},{m.Model},{m.AnFabricatie},{m.Pret},{m.Combustibil}");
                    }
                }

                MessageBox.Show("Datele au fost salvate.");
            }

            public void CitesteDinFisier()
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Fisierul nu exista.");
                    return;
                }

                masini.Clear();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 5 &&
                            int.TryParse(parts[2], out int anFabricatie) &&
                            decimal.TryParse(parts[3], out decimal pret) &&
                            Enum.TryParse(parts[4], out TipCombustibil combustibil))
                        {
                            masini.Add(new Masina(parts[0], parts[1], anFabricatie, pret, combustibil));
                        }
                    }
                }

                MessageBox.Show("Datele au fost citite.");
            }
        }
    }
