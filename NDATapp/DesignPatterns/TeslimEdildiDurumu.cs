using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class TeslimEdildiDurumu : ISiparisDurumu
    {
        public void IleriGec(Siparis s)
        {
            // Teslim edilen siparişler için ileri geçiş mümkün değil, süreç burada sonlanır
            Logger.GetInstance().Logla($"Sipariş #{s.Id} zaten teslim edilmiş. Daha ileri bir aşama yok.");
        }

        public void IptalEt(Siparis s)
        {
            // Teslim edilen siparişler iptal edilemez, ancak iade sürecine alınabilir
            Logger.GetInstance().Logla($"Sipariş #{s.Id} teslim edildiği için doğrudan iade sürecine alınıyor.");
            s.DurumDegistir(new IadeDurumu());
        }
    }
}