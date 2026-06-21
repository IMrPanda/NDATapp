using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class KargodaDurumu : ISiparisDurumu
    {
        public void IleriGec(Siparis s)
        {
            // Kargodaki ürün teslim edildi olarak işaretlenebilir
            Logger.GetInstance().Logla($"Sipariş #{s.Id} teslim edildi olarak işaretlendi.");
            s.DurumDegistir(new TeslimEdildiDurumu());
        }

        public void IptalEt(Siparis s)
        {
            // Kargodaki ürün iptal edilemez
            string mesaj = $"HATA: Sipariş #{s.Id} kargoya verildiği için iptal edilemez. Sadece iade süreci başlatılabilir.";
            Logger.GetInstance().Logla(mesaj);
            throw new InvalidOperationException(mesaj);
        }
    }
}