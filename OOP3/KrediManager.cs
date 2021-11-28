using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager  // İnterface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
    {
        public void Hesapla();
        public void BiseyYap();
        
    }
}

// İnterface(Arayüz) aslında benim şablonum görevivi görmekte.
// Eğerki birisi bu interfaceyi kullanırsa o arkadaşım bu metodu içermek zorunda.
// Her kredi mutlaka bu interface'deki metotları içermeli - yoksa kod kabul etmez.
// Okunabilirliği artırmak için classların başına " I " koyarız - İnterface olduğu anlaşılır.
//Bunları zorunlu kıldık - Yeni kredi türetilirse bunları mutlaka içermeli

// Biz bir İnterface oluşturduğumuzda alternatif şablon ve referans tutucu görevi görmekte
