using System;

namespace MyExampleStudy
{
    /*  HAKKINDA !
* Burada önlisans,lisans,yükseklisans ve doktora öğrencilerine burs / kredi yatıran bir sistem yazacağım
* Bir nevi İnterface kullanımına örnek olacak
*/
    class Program
    {
        static void Main(string[] args)
        {
            IOdeme ogrenci1 = new OnLisansOgrencileri
            {
                Id = 4001,
                TcNo="12121212123",
                FirstName="Sam",
                LastName="Sapiel"
            };

            IOdeme ogrenci2 = new LisanOgrencileri 
            {
                Id=4002,
                TcNo="2312313423",
                FirstName="Angela",
                LastName="Mose"
            };

        }
    }


    class Ogrenci
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
    }

    interface IOdeme
    {
        void AlinacakOdeme();
    }

    class OnLisansOgrencileri : Ogrenci, IOdeme
    {
        public void AlinacakOdeme()
        {
            Console.WriteLine("Önlisans Öğrencisi - 1000 TL");
        }
    }

    class LisanOgrencileri : Ogrenci, IOdeme
    {
        public void AlinacakOdeme()
        {
            Console.WriteLine("Lisans Öğrencisi - 2100 TL");
        }
    }

    class YuksekLisansOgrencileri : Ogrenci, IOdeme
    { 
        public void AlinacakOdeme()
        {
            Console.WriteLine("Yüksek Lisans Öğrencisi - 3200 TL");
        }
    }

    class DoktoraOgrencileri : Ogrenci, IOdeme
    {
        public void AlinacakOdeme()
        {
            Console.WriteLine("Doktora Öğrencisi - 4400 TL");
        }
    }


    class AccountManager
    {
        public void ParaYatirildi(IOdeme odeme) // !!
        {
            Console.WriteLine(odeme);
        }
    }
}


