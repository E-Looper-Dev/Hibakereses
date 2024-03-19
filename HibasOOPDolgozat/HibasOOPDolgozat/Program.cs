using System;
namespace HibasOOPDolgozat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Szerzo tolkien = new Szerzo("J.R.R. Tolkien", new DateTime(1892, 1, 3), "brit");
            Konyv lotr = new Konyv("A Gyűrűk Ura", tolkien, 1954);
            Tag tag = new Tag("Kiss Peter", new DateTime(1980, 5, 21), "peter.kiss@email.com");

            lotr.Kiir(); 
            tag.Kolcsonoz(lotr);
            lotr.Kiir();


			Kolcsonzes kolcsonzes = new Kolcsonzes(lotr, tag);
            kolcsonzes.Kiir();
            kolcsonzes.Visszavit();
            kolcsonzes.Kiir();

		}
	}
}