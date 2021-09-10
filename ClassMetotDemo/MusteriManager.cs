using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public  void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : "+ musteri.MusteriAdi);
        }

        public void Listing(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: "+ musteri.MusteriAdi);
        }
    }
}
