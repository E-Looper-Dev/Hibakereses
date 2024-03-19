using System;
namespace HibasOOPDolgozat
{
    public class Kolcsonzes
    {
        public Konyv Konyv;
        public Tag Tag;
        public DateTime KolcsonzesDatuma;
        public DateTime? VisszavitelDatuma;

        public Kolcsonzes(Konyv konyv, Tag tag) {
            Konyv = konyv;
            Tag = tag;
            KolcsonzesDatuma = DateTime.Now;
            VisszavitelDatuma = null;
        }

        public void Visszavit() {
            VisszavitelDatuma = DateTime.Now;
            Konyv.Visszahoz(); 
        }

        public bool LejaratEllenorzes() {
            return (DateTime.Now > KolcsonzesDatuma.AddDays(30)); 
        }

        public void Kiir() {
            Console.WriteLine("Konyv: " + Konyv.Cim + ", Tag: " + Tag.Nev + ", Kolcsonzes datuma: " + KolcsonzesDatuma.ToString() + ", Visszavitel datuma: " + (VisszavitelDatuma.HasValue ? VisszavitelDatuma.Value.ToString() : "Nincs visszavitelve"));
        }
    }
}