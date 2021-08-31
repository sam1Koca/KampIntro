using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2  };

            // type safe : tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("----------------------Metotlar---------------------");

            // instance - örnek
            // encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 14);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 18);
        }
    }
}

// Metotlar Tekrar Tekrar Kullanılabilirliği Sağlayan Kod Bloklarıdır. - Dont Repeat Yourself.
// Clean Code - Best Practice(Doğru / En iyi uygulama taktıikleri)
// type safe: Program ben hangi veri tipiyle çalışacağımı bilmeliyim der.
