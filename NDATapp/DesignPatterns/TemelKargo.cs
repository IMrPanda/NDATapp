using NDATapp.Models.Interfaces;

namespace NDATapp.DesignPatterns
{
    // Sadece ağırlığa göre hesaplanan en sade kargo fiyatı
    public class TemelKargo : IKargoUcret
    {
        private double _agirlik;

        public TemelKargo(double agirlik)
        {
            _agirlik = agirlik;
        }

        public double FiyatHesapla()
        {
            return _agirlik * 15.0; // Kilosu 15 TL'den hesaplıyo
        }
    }
}