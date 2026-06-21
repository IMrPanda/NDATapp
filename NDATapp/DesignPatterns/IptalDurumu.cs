using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class IptalDurumu : ISiparisDurumu
    {
        public void IleriGec(Siparis s) { } // İptal edilen sipariş ilerleyemez
        public void IptalEt(Siparis s) { }  // Zaten iptal edildi
    }
}