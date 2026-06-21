using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class HavaleStratejisi : IOdemeStratejisi
    {
        public bool OdemeAl(double tutar)
        {
            // havale ile ödeme 
            Logger.GetInstance().Logla($"Havale/EFT işlemi onaylandı. Tutar: {tutar} TL.");
            return true;
        }
    }
}