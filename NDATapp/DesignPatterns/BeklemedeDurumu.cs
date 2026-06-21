using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class BeklemedeDurumu : ISiparisDurumu
    {
        public void IleriGec(Siparis s)
        {
            // Beklemede durumundan sonra sadece Kargoda durumuna geçilebilir
            Logger.GetInstance().Logla($"Sipariş #{s.Id} durumu 'Beklemede' aşamasından 'Kargoda' aşamasına geçiyor.");
            s.DurumDegistir(new KargodaDurumu());
        }

        public void IptalEt(Siparis s)
        {
            // Beklemede durumundayken sipariş iptal edilebilir
            Logger.GetInstance().Logla($"Sipariş #{s.Id} 'Beklemede' aşamasındayken iptal edildi.");
            s.DurumDegistir(new IptalDurumu());     

        }
    }
}
