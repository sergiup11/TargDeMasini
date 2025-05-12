using System;

namespace TargDeMasini

{
    public enum TipCombustibil
    {
        Benzina = 0,
        Motorina = 1,
        Electric = 2,
        Hibrid = 3
    }

    public class Masina
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public decimal Pret { get; set; }
        public TipCombustibil Combustibil { get; set; }
        public DateTime DataAdaugare { get; set; }

        public Masina(string marca, string model, int anFabricatie, decimal pret, TipCombustibil combustibil, DateTime dataAdaugare)
        {
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
            Pret = pret;
            Combustibil = combustibil;
            DataAdaugare = dataAdaugare;
        }
    }
}
