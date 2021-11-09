using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Hannah Wasilyev";
            musteri1.MusteriHesapNo = "1577965";
            musteri1.MusteriHesapBakiyesi = 456.75;

            Musteri musteri2 = new Musteri();

            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Kevin Mittnick";
            musteri2.MusteriHesapNo = "8887621";
            musteri2.MusteriHesapBakiyesi = 4756.5;

            Musteri musteri3 = new Musteri();

            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Emmiliano Astec";
            musteri3.MusteriHesapNo = "4453420";
            musteri3.MusteriHesapBakiyesi = 12.30;


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);

            musteriManager.Listing(musteri1);
            musteriManager.Listing(musteri2);
            musteriManager.Listing(musteri3);

            musteriManager.Delete(musteri3);

        }
    }
}
