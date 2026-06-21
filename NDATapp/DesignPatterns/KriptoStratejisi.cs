using NDATapp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NDATapp.DesignPatterns
{
    internal class KriptoStratejisi : IOdemeStratejisi
    {
        public bool OdemeAl(double tutar)
        {
            Models.Logger.GetInstance().Logla($"Kripto Cüzdan üzerinden {tutar} TL başarıyla çekildi.");
            return true;
        }
    }
}
