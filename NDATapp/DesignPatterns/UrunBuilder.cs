using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class UrunBuilder
    {
        private Urun _urun;

        public UrunBuilder(string ad, double temelFiyat)
        {
            _urun = new Urun(ad, temelFiyat);
        }

        // karmaşık ürün olan bilgisayar bileşenlerini eklemek için metotlar
        public UrunBuilder EkleIslemci(string cpu)
        {
            _urun.Bilesenler.Add($"İşlemci: {cpu}");
            _urun.Fiyat += 5000;
            Logger.GetInstance().Logla($"[Builder] Montaj: İşlemci ({cpu}) sisteme eklendi.");
            return this;
        }

        public UrunBuilder EkleEkranKarti(string gpu)
        {
            _urun.Bilesenler.Add($"Ekran Kartı: {gpu}");
            _urun.Fiyat += 12000;
            Logger.GetInstance().Logla($"[Builder] Montaj: Ekran Kartı ({gpu}) sisteme eklendi.");
            return this;
        }

        public Urun Olustur()
        {
            string bilesenlerStr = string.Join(", ", _urun.Bilesenler);

            Logger.GetInstance().Logla($"{_urun.Ad} isimli ürün başarıyla inşa edildi. İçeriği: [{bilesenlerStr}]");
            return _urun;
        }
    }
}