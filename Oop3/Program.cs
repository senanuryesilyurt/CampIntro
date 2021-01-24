using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager IhtiyacKrediManager  = new IhtiyacKrediManager();
            IKrediManager TasitKrediManager = new TasitKrediManager();
            IKrediManager KonutKrediManager = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuru = new BasvuruManager();
            basvuru.BasvuruYap(TasitKrediManager, fileLoggerService);
                                                //new DatabaseLoggerService()
                                                 
            List<IKrediManager> krediler = new List<IKrediManager>() { };
            //basvuru.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
