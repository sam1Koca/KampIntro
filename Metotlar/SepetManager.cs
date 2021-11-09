using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    // Bir classın sonunda manager-service vs. görürseniz bunlar bir operasyon yönetiyor demektir.
    // Ortak kodlar classların içine yazılır genellikle
    class SepetManager
    {
        // naming convention - isimlendirme kuralı *Metotun baş harfini büyük yazdık
        //syntax - yazım şekli
        // Ekle() => Fonksiyonuna göre - Metota Parametre olarak ne ekleyeceğimizi göndermeliyiz
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi!" + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);
        }
    }
}
