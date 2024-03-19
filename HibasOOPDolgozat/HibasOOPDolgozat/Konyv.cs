using System;
namespace HibasOOPDolgozat
{
    public class Konyv
    {
        public string Cim;
        public Szerzo Szerzo;
        public int KiadasEve;
        public bool Kolcsonozve;



        public Konyv(string cim, Szerzo szerzo, int kiadasEve)
        {
            Cim = cim;
            Szerzo = szerzo;
            KiadasEve = kiadasEve;
            Kolcsonozve = false;
        }

        public void Kolcsonoz()
        {
            Kolcsonozve = true;
        }


        public void Visszahoz()
        {
            Kolcsonozve = false;
        }

        public bool Elerheto()
        {
            return !Kolcsonozve;
        }

        public void Kiir()
        {
            string semmi = "";
            if (!Kolcsonozve)
            {
                semmi = "Nincs kikölcsönözve.";
            }
            else
            {
                semmi = "Már kikölcsönözték!";
            }
            Console.WriteLine("Cim: " + Cim + ", Szerzo: " + Szerzo.Nev + ", Kiadas eve: " + KiadasEve + ", Kolcsonozve: " + semmi);
        }
    }
}