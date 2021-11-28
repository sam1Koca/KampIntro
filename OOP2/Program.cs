using System;

namespace OOP2
{
    class Program  // *Eğer senin base Classın varsa o base class referans tutucudur -Message
    {
        static void Main(string[] args)
        {
            //Mark Zuckerberg

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1212121";
            musteri1.Adi = "Mark";
            musteri1.Soyadi = "Zuckerberg";
            musteri1.TcNo = "1212323232";




            //Metaverse

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "56565656";
            musteri2.SirketAdi = "Metaverse";
            musteri2.VergiNo = "12797198";




            // Musteri Classı hem gerçekMusterinin hemde TuzelMusterinin referansını tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);  //Buraya musteri3 - 4'ü de yollayabilir metot müşteri tipinde istiyorya hani :)


        }
    }
}

// Gerçek  Müşteri - Tüzel Müşteri
//SOLID - L     // Birbirine benziyor diye Inheritance yapma
// Nasıl Ele almalıyız peki? - Üşenmek yerine git ayrı ayrı classları oluştur. /Tuzel /Gercek
// Yazılan Musteri Classında Şirket Adı var fakat Kişinin şirketi yok. Bu yanlıştır! *HATALI*