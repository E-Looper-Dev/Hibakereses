using System;
namespace HibasOOPDolgozat
{
    public class Szerzo
    {
        public string Nev;
        public DateTime SzuletesiDatum;
        public string Nemzetiseg;

        public Szerzo(string nev, DateTime szuletesiDatum, string nemzetiseg)
        {
            Nev = nev;
            SzuletesiDatum = szuletesiDatum;
            Nemzetiseg = nemzetiseg;
        }


        public void Kiir()
        {
            Console.WriteLine("Nev: " + Nev + ", Szuletesi datum: " + SzuletesiDatum.ToString() + ", Nemzetiseg: " + Nemzetiseg);



        }

        public int Eletkor()
        {
            return DateTime.Now.Year - SzuletesiDatum.Year;
        }

        public bool NobelDijas = false;

        public void NobelDijatKap()
        {
            NobelDijas = true;
        }
    }
}