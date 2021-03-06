using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Go";
            kurs1.Egitmen = "Cihan Özhan";
            kurs1.İzlenmeOrani = 408;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Cobol";
            kurs2.Egitmen = "Mehmet İnce";
            kurs2.İzlenmeOrani = 6478;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Linux 101";
            kurs3.Egitmen = "Kevin Mittnick";
            kurs3.İzlenmeOrani = 127320;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Cisco CCNA 200-301";
            kurs4.Egitmen = "Neil Anderson";
            kurs4.İzlenmeOrani = 627320;

            // Console.WriteLine(kurs1.KursAdi + ": " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}

