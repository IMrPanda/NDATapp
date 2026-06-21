using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class IadeDurumu : ISiparisDurumu
    {
        public void IleriGec(Siparis s)
        {
            Logger.GetInstance().Logla($"Sipariş #{s.Id} iade sürecinde, ürünler depoya geri alınıyor.");
            // Depoya ulaştığında süreç sonlanır
        }

        public void IptalEt(Siparis s)
        {
            // İade sürecindeyken iptal işlemi yapılamaz
            Logger.GetInstance().Logla($"Sipariş #{s.Id} iadesi iptal edildi edilemez, zaten iade durumunda.");
        }
    }
}