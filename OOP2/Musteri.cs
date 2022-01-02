using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }


    }
}



/*    ÖNEMLİ NOTLAR !
 * 
 * Eğerki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsa / o nesneye ait değilmiş gibi duruyorsa ?Soyutlama hatan vardır!!
 * Yani program.cs'de bunun örneğini yaptım ben Sami kocayım(kişiyim) şirket değilim fakat / bu propertye göre sirket adi gelmekte?
 * Doğrusu Nedir: Üşenme, GercekMusteri ve TuzelMusteri adında class oluştur.
 * 
 * Inheritance İşleminde Ebevyn İlişkisinden Bahsedebiliriz.
 * Baba-oğul ( Baba base classtır - oğulda ondan özellikler alır / fakat tamamını almaz
 */






//       KENDİ NOTLARIM
// Classların iki Temel Özelliği Vardır:
//Property Tutmak ve Operasyon Tutmak
//Property tutulan yerde operasyon olmaz - Operasyon olan yerde property tutulmaz 

//Eğer bir veri üzerinde matematiksel işlem yapmıyorsan - ona sayı özelliği vermiyorsan "string" olarak tanımlamak daha doğru olur.

// Müşteri vs. Property tutan classlar Entity'dir : Operasyon Tutamazlar!