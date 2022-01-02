using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate Customer

    class TuzelMusteri : Musteri  // TuzelMusteri Bir müşteridir | Miras İnheritance
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}


// Musteride olan özellikler Tuzel Musteridede vardır - ortakları atarız! (TuzelMusteri:Musteri)