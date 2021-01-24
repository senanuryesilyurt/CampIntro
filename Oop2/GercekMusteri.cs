using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //individual - bireysel
    class GercekMusteri:Musteri // inheritance - miras : Musteride olan hersey tuzel musteride de vardır denir.
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
       
    }
}
