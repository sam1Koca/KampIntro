using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager // Bu classta bir krediye başvuru alacağız ve hesaplamayı ona göre yapacağız
    {
        //Method İnjection Yaptık => Bu metodun kullanacağı kredi türünü vs. enjekte ediyoruz
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //Başvuru sonunda hangi hesaplama yapıldıysa logla.
        {
            //Başvuran bilgilerini değerlendirme


            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}


/*  KOD AÇIKLAMALARI
 *  
 *  List<IKrediManager> krediler  => Bana bir liste ver ve türü IKrediManager - önceden tek veri geliyordu şimdi türü birden fazla ve farklı. 
 */


/*  DİKKAT!
 * 
   KonutKrediManager konutKrediManager = new KonutKrediManager();
   konutKrediManager.Hesapla();

 * Burada Böyle yaparsak - Tüm Başvuruları Konut kredisine bağımlı hale getirdik.
 * 
 * Şöyle yapsak BasvuruYap(IKrediManager krediManager) => Başvuru yaparken bir parametre alsam - 
   ==> Bu başvuruyu hangi krediye göre yapmam gerektiğini bana söyle - herkesin referansını elimde tutan birşey var:) *IKrediManager

 * Yukarıdakini Yaparak:
     ==>  Başvuruyu Bağımsız hale getirdim Çünkü: IKredıManager tipinde krediManager alıyorum. Hangisi gelirse ona göre yaparım :)

 */