using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class KirilacakDecorator : KargoDecorator
    {
        public KirilacakDecorator(IKargoUcret sarmalanan) : base(sarmalanan) { }

        public override double FiyatHesapla()
        {
            double fiyat = base.FiyatHesapla() + 35.0; // 35 TL kırılacak eşya koruması
            Logger.GetInstance().Logla("Kargo ücretine Kırılacak Eşya Koruması eklendi (+35 TL).");
            return fiyat;
        }
    }
}