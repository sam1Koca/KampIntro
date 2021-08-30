using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlama İçin Temel Kurs";
            string kurs3 = "Assembly Kursu";
            string kurs4 = "Perl Kursu";

            // array - dizi

            string[] kurslar = new string[] {kurs1, kurs2, kurs3, kurs4 };
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Loop is over. \n");

            foreach (string kurs in kurslar)  // foreach dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu -- Footer");
        }

    }
}
