using System;
using System.Collections.Generic;

namespace OOP3  // İnterface Learn | Temel Dependency İnjection | 
{
    class Program  // Bu projede Bir bankada kredi yönetimi vs. gibi konuları İleri OOP teknikleri ile yaptık
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKredisiManager = new EsnafKredisiManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            List<ILoggerService> loggersServices = new List<ILoggerService>() { databaseLoggerService, smsLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager, loggersServices);


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            //SOLID: O => Sisteme Yeni bir özellik eklendiğinde mevcut kodlar bozulmaz.
            // Yukarıda iyi bir polimorfizm yaptık.
        }
    }
}


/*  ÖNEMLİ AÇIKLAMALAR !!
   
 *  IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
    ihtiyacKrediManager.Hesapla();

    TasitKrediManager tasitKrediManager = new TasitKrediManager();
    tasitKrediManager.Hesapla();

    KonutKrediManager konutKrediManager = new KonutKrediManager();
    konutKrediManager.Hesapla();

    => > Bu şekildede olur, Main'in içindekiler gibi de olur.
 */