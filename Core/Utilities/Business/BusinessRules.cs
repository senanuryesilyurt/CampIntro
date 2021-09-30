using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //business code hepsini buraya gönderiyoruz.
        //params ile istediğimiz kadar IResult türünden değişken gönderebiliyoruz.
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                //kurala uymayanı döndür.
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
