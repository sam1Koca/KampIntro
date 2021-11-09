using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // snippet-Hazır kodlar [..] =>Sembolü
    class Product // Bu tip classlarda sadece Özellik Olur
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        // Ürün ismi
        public string ProductName { get; set; }
        // Ürün birim Fiyatı
        public double UnitPrice { get; set; }
        // Ürünün stok adedi
        public int UnitsInStock { get; set; }

        // "CRUD" : Create-Read-Update-Delete : *Eklemek*Okumak*Güncellemek*Silmek - Operasyonları 

    }
}
