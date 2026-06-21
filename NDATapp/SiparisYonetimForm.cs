using NDATapp.Models;
using NDATapp.DesignPatterns;
using NDATapp.Models.Interfaces;
using System;
using System.Windows.Forms;

namespace NDATapp
{
    public partial class SiparisYonetimForm : Form
    {
        Veritabani db = new Veritabani();

        public SiparisYonetimForm()
        {
            InitializeComponent();
            SiparisleriYukle();
        }

        private void SiparisleriYukle()
        {
            lstSiparisler.Items.Clear();
            var siparisler = db.TumSiparisleriGetir();
            lstSiparisler.Items.AddRange(siparisler);
        }

        // Txt'deki string yazıyı, bizim State nesnelerine çeviren yardımcı metot
        private ISiparisDurumu DurumNesnesiGetir(string durumAd)
        {
            if (durumAd == "Beklemede") return new BeklemedeDurumu();
            if (durumAd == "Kargoda") return new KargodaDurumu();
            if (durumAd == "Teslim Edildi") return new TeslimEdildiDurumu();
            if (durumAd == "İade Sürecinde") return new IadeDurumu();
            if (durumAd == "İptal Edildi") return new IptalDurumu();
            return new BeklemedeDurumu();
        }

        // State (Durum) nesnesini tekrar Txt'ye yazılacak string'e çeviren yardımcı metot
        private string DurumAdiGetir(ISiparisDurumu durum)
        {
            if (durum is BeklemedeDurumu) return "Beklemede";
            if (durum is KargodaDurumu) return "Kargoda";
            if (durum is TeslimEdildiDurumu) return "Teslim Edildi";
            if (durum is IadeDurumu) return "İade Sürecinde";
            if (durum is IptalDurumu) return "İptal Edildi";
            return "Bilinmiyor";
        }

        // İLERLET BUTONU
        private void btnDurumIlerlet_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.SelectedItem == null) return;

            string[] parcalar = lstSiparisler.SelectedItem.ToString().Split('|');
            int id = int.Parse(parcalar[0]);
            string mevcutDurumStr = parcalar[2];

            // 1. Durumu algıla ve siparişi o durumla başlat
            Siparis s = new Siparis(DurumNesnesiGetir(mevcutDurumStr)) { Id = id };

            // 2. State desenini tetikle (Bir sonraki aşamaya geç)
            s.IleriGec();

            // 3. Yeni durumu al ve veritabanını güncelle
            string yeniDurumStr = DurumAdiGetir(s.MevcutDurum);
            db.SiparisDurumGuncelle(id, yeniDurumStr);

            // 4. Listeyi yenile
            SiparisleriYukle();
        }

        // İPTAL BUTONU (Şartnamedeki kuralın çalıştığı yer)
        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            if (lstSiparisler.SelectedItem == null) return;

            string[] parcalar = lstSiparisler.SelectedItem.ToString().Split('|');
            int id = int.Parse(parcalar[0]);
            string mevcutDurumStr = parcalar[2];

            Siparis s = new Siparis(DurumNesnesiGetir(mevcutDurumStr)) { Id = id };

            try
            {
                // İptal etmeyi dene
                s.IptalEt();

                string yeniDurumStr = DurumAdiGetir(s.MevcutDurum);
                db.SiparisDurumGuncelle(id, yeniDurumStr);
                SiparisleriYukle();
            }
            catch (InvalidOperationException ex)
            {
                // EĞER SİPARİŞ KARGODAYSA STATE DESENİ BURAYA HATA FIRLATIR!
                MessageBox.Show(ex.Message, "Kural İhlali", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}