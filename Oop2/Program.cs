using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "126985";
            musteri1.Adi = "Sena";
            musteri1.Soyadi = "Yesilyurt";
            musteri1.TcNo = "78963248541";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "78962";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "2345678765434";

            //Musteri hem gercekMusterinin hem de tuzelMusterinin referansını tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        
        
        }
    }
}
