using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class KrediKartiStratejisi : IOdemeStratejisi
    {
        public bool OdemeAl(double tutar)
        {
            Logger.GetInstance().Logla($"Kredi Kartı ile {tutar} TL ödeme başarıyla çekildi.");
            return true; 
        }
    }
}