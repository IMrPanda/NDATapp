using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;

namespace NDATapp.DesignPatterns
{
    public class KargoFabrikasi
    {
        public static IKargoServisi KargoUret(string firmaSecimi)
        {
            
            if (firmaSecimi == "Aras") return new ArasAdapter();
            if (firmaSecimi == "Yurtici") return new YurticiAdapter();

            throw new Exception("Geçersiz kargo firması seçimi!");
        }
    }
}