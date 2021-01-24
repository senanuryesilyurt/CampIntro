using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        public void Ekle(Product urun)//kapsülleme
        {
            Console.WriteLine("sepete eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama,double fiyat)
        {
            Console.WriteLine("sepete eklendi : " + urunAdi);
            Console.WriteLine("sepete eklendi : " + aciklama);
            Console.WriteLine("sepete eklendi : " + fiyat);
        }

    }
}
