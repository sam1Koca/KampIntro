using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // İçindeki "T" : Type'den geliyor. = Ben MyList'imde T ile çalışacağım
    class MyList<T>
    {
        T[] items;
        //constructor - ctor = Sen yukarıdaki class'ı newlersen bu bu parantezlerin içerisi çalışır. (Bir nevi metot)
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items; // Geçici dizinin referansı items'ın referansı - Geçici olarak bir arkadaşa verdim sonra artırdım
                                   //Newlemek demek yeni ref. numarası yani eski verilerimin uçması - biz onu tempArrayda tutyoruz.
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}

// Ben sana T olarak ne verirsem istediğim elemanın türüde odur.
// Yani programcı new'leyince hangi tipte kullanır/yada belirtirse o şekilde kullanılır.