using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        // Değer tipler stack'i kullanır - referans tipler ise hem "heap" hemde "stack'i" kullanır.
        // new dediğimiz anda bellekte yeni bir adres oluşur.
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Atıl", "Mehmet", "Ömer", "Mittnick" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5]; 
            //isimler[4] = "Steve";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //collections - list
            List<string> isimler2 = new List<string> {"Steve","Mark","Musk","Sami" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Mittnick");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
