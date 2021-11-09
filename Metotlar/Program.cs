using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            // type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("-------------------- Metotlar ---------------------");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 9);
            sepetManager.Ekle2("Elma", "Kırmızı Elma", 12, 5);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 1);

        }
    }
}

// Bir classın içinde birden fazla metot olabilir / yazabilirsin.
// Classların İki Özelliği veya kullanımı vardır - Özellik Tutarlar / Metot Tutarlar
// Dont repeat yourself - DRY - Clean Code
// Best Practice - Doğru Uygulama Teknikleri
// PascalCase - Kelimelerin İlk Harfi Büyük Yazılır:Convention Yazım Kuralı