using System;
namespace HibasOOPDolgozat
{
    public class Tag
    {
        public string Nev;
        public DateTime SzuletesiDatum;
        public string Email;

        public Tag(string nev, DateTime szuletesiDatum, string email)
        {
            Nev = nev;
            SzuletesiDatum = szuletesiDatum;
            Email = email;
        }


        public void Kolcsonoz(Konyv konyv)
        {
            if (konyv.Elerheto())
            {

                konyv.Kolcsonoz();
            }
            else
            {
                Console.WriteLine("A konyv jelenleg nem elerheto.");
            }
        }


        public int Eletkor()
        {
            return DateTime.Now.Year - SzuletesiDatum.Year;
        }

        public void Kiir()
        {
            Console.WriteLine("Nev: " + Nev + ", Szuletesi datum: " + SzuletesiDatum.ToString() + ", Email: " + Email);
        }
    }
}