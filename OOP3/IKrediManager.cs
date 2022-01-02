using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla();

    }
}


/*  İnterfaces Note !!
 * 
 * Diyelimki Hesapla() Metodum var benim. 5-6 Tane kredi için kullanacağım bu hesaplamayı. !! Fakat her kredinin hesaplanışı farklı
 
 * Burada devreye Interfaceler girer. İnterface benim şablonumdur,içerisinde imza taşır.
 
 * ! İnterfacler implemente edilen(kullanılan) her sınıfta - barındırdığı metotları / imzaları bulundurmak zorundadır.
 
 * ! İçerisindeki kullanılan metot o an ne için / hangi amaçla kullanılacaksa ona göre yapılandırılır.(Herkes kendi kuralını yazabilir)
 
 * ! Okunurluğu artırmak için başlarına " I " harfi koyarız  (Ex. IKrediManager)
  
 * Mevzu Bahis: Interface'i implemente eden class kendi kurallarını kullanınca koyar.
 
 * ! Genellikle / Çoğunlukla Operasyonel Classlarda Kullanılır.
  
 * ! İnterfacelerde o interface'i implemente eden classın referans numarasını tutabilir
 * 
 * new'lenemez classtır
 */