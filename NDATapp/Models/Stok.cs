using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using System.Collections.Generic;

namespace NDATapp.Models
{
    public class Stok
    {
        public IUrun Urun { get; set; }
        private int _miktar;
        private int _kritikEsik;
        private List<IStokObserver> _gozlemciler = new List<IStokObserver>();

        public Stok(IUrun urun, int miktar, int kritikEsik)
        {
            Urun = urun;
            _miktar = miktar;
            _kritikEsik = kritikEsik;
        }

        public void GozlemciEkle(IStokObserver observer)
        {
            _gozlemciler.Add(observer);
        }

        public void StokDusur(int adet)
        {
            _miktar -= adet;
            Logger.GetInstance().Logla($"{Urun.Ad} ürününden {adet} adet düşüldü. Kalan stok: {_miktar}");

            // VERİTABANINI GÜNCELLE
            new Veritabani().StokGuncelle(Urun.Ad, _miktar);

            // Kritik eşik kontrolü ve Observer tetiklemesi
            if (_miktar <= _kritikEsik)
            {
                BildirimleriTetikle();
            }
        }

        private void BildirimleriTetikle()
        {
            // Kritik eşik altına düştüğünde gözlemcilere bildirim gönder
            string mesaj = $"DİKKAT: {Urun.Ad} ürünü kritik eşiğin altına düştü! Kalan miktar: {_miktar}";
            foreach (var gozlemci in _gozlemciler)
            {
                gozlemci.Bildir(mesaj);
            }
        }
    }
}
