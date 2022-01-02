using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        // void: diye belirttimiz metotları şu şekilde düşünebiliriz - git güncelle, git sil - bir nevi emir kipi.
        // void:Senin bu işlemin sonucunda ne olduğu hakkında extra bir bilgiye ihtiyacın yoksa biz onu void tanımlıyoruz.
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
    } 
}









// Örnekler - Notlarım
//public int Topla(int sayi1, int sayi2)
//{
//    return sayi1 + sayi2;
//}

//// Burda kafa karıştırıcı nokta ben yukardaki gibi veya aşağıdaki gibi yapsam ne olur?
//// neden return'a ihtiyacım var: DRY prensiplerinden dolayı - bi işlemi tekrar ve farklı şekilde yapmak istiyorum o yüzden 

//public void Topla2(int sayi1, int sayi2)
//{
//    Console.WriteLine(sayi1 + sayi2); //sayi1,sayi2 - İşlemini yapıyor ve ekrana yazdırıyor *4 ve 7'yi gönderdim sonuçu yazdı
//}