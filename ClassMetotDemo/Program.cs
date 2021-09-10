using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Kazım";
            musteri1.MusteriSoyadi = "Kar";
            musteri1.MusteriBakiye = 1200;


            Musteri musteri2 = new Musteri();

            musteri2.MusteriId = 1;
            musteri2.MusteriAdi = "Sami";
            musteri2.MusteriSoyadi = "Koca";
            musteri2.MusteriBakiye = 500;


            Musteri musteri3 = new Musteri();

            musteri3.MusteriId = 1;
            musteri3.MusteriAdi = "Kevin";
            musteri3.MusteriSoyadi = "Mittnick";
            musteri3.MusteriBakiye = 150;

            Musteri[] Musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            MusteriManager manager = new MusteriManager();
            manager.Add(musteri1);
            Console.WriteLine("\n ---------------------------------------------------- \n");
            Console.WriteLine("********* Müşteriler Listelendi ********** \n"); 
            manager.Listing(musteri1);
            manager.Listing(musteri2);
            manager.Listing(musteri3);
            Console.WriteLine("-------------------------------------------------------------");
            manager.Delete(musteri2);

        }
    }
}
