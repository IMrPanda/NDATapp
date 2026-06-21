using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;

namespace NDATapp.Models
{
    public class Siparis 
    {
        // Sipariş ID'si
        public int Id { get; set; }
        public List<IUrun> Urunler { get; set; } = new List<IUrun>();
        private ISiparisDurumu _mevcutDurum;
        public IOdemeStratejisi? OdemeYontemi { get; set; }
        public ISiparisDurumu MevcutDurum => _mevcutDurum;

        public Siparis(ISiparisDurumu baslangicDurumu)
        {
            _mevcutDurum = baslangicDurumu;
        }

        public void DurumDegistir(ISiparisDurumu yeniDurum)
        {
            _mevcutDurum = yeniDurum;
        }

        public void IleriGec()
        {
            _mevcutDurum.IleriGec(this);
        }

        public void IptalEt()
        {
            _mevcutDurum.IptalEt(this);
        }
    }
}
