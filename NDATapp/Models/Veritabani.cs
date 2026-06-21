using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Linq;

namespace NDATapp.Models
{
    public class Veritabani
    {
        // Dosyayı direkt Masaüstüne kaydediyoruz, böylece kullanıcı kolayca erişebilir
        private readonly string _dosyaYolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "stok_veritabani.txt");
        private readonly string _sayacYolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "siparis_sayaci.txt");
        private readonly string _siparislerYolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "siparisler_veritabani.txt");

        public Veritabani()
        {
            // Eğer masaüstünde dosya yoksa, varsayılan stoklarla (10) birlikte yaratır
            if (!File.Exists(_dosyaYolu))
            {
                File.WriteAllLines(_dosyaYolu, new string[] {
                    "Kalem (Basit):10",
                    "Bilgisayar Kasası (Karmaşık):10"
                });
            }
        }

        public int StokGetir(string urunAd)
        {
            var satirlar = File.ReadAllLines(_dosyaYolu);
            foreach (var satir in satirlar)
            {
                var parcalar = satir.Split(':');
                if (parcalar[0] == urunAd)
                {
                    return int.Parse(parcalar[1]);
                }
            }
            return 0;
        }

        public void StokGuncelle(string urunAd, int yeniMiktar)
        {
            var satirlar = File.ReadAllLines(_dosyaYolu).ToList();
            for (int i = 0; i < satirlar.Count; i++)
            {
                var parcalar = satirlar[i].Split(':');
                if (parcalar[0] == urunAd)
                {
                    satirlar[i] = $"{urunAd}:{yeniMiktar}";
                    break;
                }
            }
            File.WriteAllLines(_dosyaYolu, satirlar);
        }

        public int YeniIdUret()
        {
            int id = 101;
            if (File.Exists(_sayacYolu))
                id = int.Parse(File.ReadAllText(_sayacYolu));

            File.WriteAllText(_sayacYolu, (id + 1).ToString());
            return id;
        }

        public void SiparisKaydet(int id, string urun, string durum)
        {
            // ID | Ürün Adı | Mevcut Durum formatında kaydediyoruz
            string satir = $"{id}|{urun}|{durum}{Environment.NewLine}";
            File.AppendAllText(_siparislerYolu, satir);
        }

        // Tüm siparişleri listeleme
        public string[] TumSiparisleriGetir()
        {
            if (!File.Exists(_siparislerYolu)) return Array.Empty<string>();
            return File.ReadAllLines(_siparislerYolu);
        }
        public void SiparisDurumGuncelle(int id, string yeniDurum)
        {
            if (!File.Exists(_siparislerYolu)) return;
            var satirlar = File.ReadAllLines(_siparislerYolu).ToList();

            for (int i = 0; i < satirlar.Count; i++)
            {
                var parcalar = satirlar[i].Split('|');
                if (int.Parse(parcalar[0]) == id)
                {
                    satirlar[i] = $"{id}|{parcalar[1]}|{yeniDurum}";
                    break;
                }
            }
            File.WriteAllLines(_siparislerYolu, satirlar);
        }
    }
}