using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı");
        }
    }
}


// İnterface'i İnherit etme sebebimiz:  Bu classın içinde de Hesapla() olsun  *ayrı ayrı yazmaya gerek yok