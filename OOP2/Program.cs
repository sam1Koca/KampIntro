using System;

namespace OOP2
{
    class Program   //Inheritance Learning :=)
    {
        static void Main(string[] args)
        {
            //Bill Gates
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "127001";
            musteri1.Adi = "Bill";
            musteri1.Soyadi = "Gates";
            musteri1.TcNo = "133765992";



            //Microsoft
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "127002";
            musteri2.SirketAdi = "Microsoft";
            musteri2.VergiNo = "2064819";

            // Gerçek - Tüzel 
            //SOLID : L  = Birbirine benziyor diye Inheritance yapma


            Musteri musteri3 = new TuzelMusteri();  

            Musteri musteri4 = new GercekMusteri();
            //Musteri tipindeki değişken Her ikisinide tutabiliyor

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);


            // İnheritance'da Olay Base Class'ta Her ikisinide - Tutabilmesi,İnherit edebilmesi!


        }
    }
}


// !!! Makalede Bu örnekleri Verebilirsin (Tüzel Müşteri - Gerçek Müşteri örn.)


// Eğer bir yerde "new" görürseniz bu bellekteki referans no'su.




/*  MY NOTES!
 *  Gerçek - Tüzel  *Bunlar birbirine benziyor diye, birbirleri yerine kullanılamaz.
 *  İmplementasyon : Uygulama.
 */