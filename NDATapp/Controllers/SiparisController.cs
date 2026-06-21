using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models;
using NDATapp.Models.Interfaces;
using NDATapp.DesignPatterns;

namespace NDATapp.Controllers
{
    public class SiparisController
    {
        public void SiparisIsle(string urunAd, string kargoFirma, string odemeTipi)
        {
            Veritabani db = new Veritabani();
            int yeniId = db.YeniIdUret(); // Otomatik artan ID , yeni bir sipariş için kullanıyoruz. Bu ID'nin başlangıç değerini biz belirleyebiliyoruz txt ile.

            Logger.GetInstance().Logla($"--- Yeni İşlem Başlatıldı: {urunAd} ---");

            // Üretim (Builder)
            IUrun secilenUrun;
            if (urunAd == "Bilgisayar Kasası (Karmaşık)")
            {
                secilenUrun = new UrunBuilder("Bilgisayar Kasası (Karmaşık)", 15000) // Karmaşık ürün 
                                .EkleIslemci("Intel i9")
                                .EkleEkranKarti("RTX 4060")
                                .Olustur();
            }
            else
            {
                secilenUrun = new Urun(urunAd, 500); // Basit ürün
            }

            // Stok ve Observer 
            int guncelStok = db.StokGetir(secilenUrun.Ad);

            if (guncelStok <= 0)
            {
                throw new Exception($"HATA: {secilenUrun.Ad} isimli ürünün stoğu tükenmiştir! Sipariş verilemez."); // Stok kalmadığında sipariş verilemez, hata fırlatıyoruz.
            }

            // veritabanından gelen guncelStok değerini veriyoruz
            Stok stokYonetimi = new Stok(secilenUrun, guncelStok, 5);
            stokYonetimi.GozlemciEkle(new EmailObserver());
            stokYonetimi.GozlemciEkle(new SistemBildirimObserver());

            // Sonrasında stoktan 1 adet düşüyoruz
            stokYonetimi.StokDusur(1);

            // Sipariş ve State 
            Siparis yeniSiparis = new Siparis(new BeklemedeDurumu()) { Id = yeniId };
            yeniSiparis.Urunler.Add(secilenUrun);
            db.SiparisKaydet(yeniId, secilenUrun.Ad, "Beklemede");

            // Ödeme (Strategy) 
            if (odemeTipi == "Kredi Kartı")
                yeniSiparis.OdemeYontemi = new KrediKartiStratejisi();
            else if (odemeTipi== "Kripto Cüzdan")
                yeniSiparis.OdemeYontemi = new KriptoStratejisi();
            else
                yeniSiparis.OdemeYontemi = new HavaleStratejisi();
            

            yeniSiparis.OdemeYontemi.OdemeAl(secilenUrun.Fiyat);


            // Kargo ve Fiyatlandırma (Factory + Adapter + Decorator)
            IKargoServisi kargoServisi = KargoFabrikasi.KargoUret(kargoFirma);
            string takipNo = kargoServisi.GonderiOlustur(secilenUrun.Ad);

            // Decorator
            IKargoUcret ucretHesaplayici = new TemelKargo(2.5); // kilo bazlı
            ucretHesaplayici = new SigortaDecorator(ucretHesaplayici);
            ucretHesaplayici = new KirilacakDecorator(ucretHesaplayici);

            Logger.GetInstance().Logla($"Kargo Takip No: {takipNo}");
            Logger.GetInstance().Logla($"Toplam Kargo Maliyeti: {ucretHesaplayici.FiyatHesapla()} TL");

            // State
            yeniSiparis.IleriGec(); // Beklemede -> Kargoda -> Teslim Edildi ya da İptal Edildi. Eğer kargodaysa iptal edilemez, teslim edilince iade süreci başlar

            Logger.GetInstance().Logla("--- İşlem Başarıyla Tamamlandı ---");
        }
    }
}