using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.MusteriAdi + "\n");
        }

        public void Listing(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Listelendi:  " + musteri.MusteriAdi + "\n");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.MusteriAdi + "\n");
        }
    }
}
