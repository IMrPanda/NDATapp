using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class SigortaDecorator : KargoDecorator
    {
        public SigortaDecorator(IKargoUcret sarmalanan) : base(sarmalanan) { }

        public override double FiyatHesapla()
        {
            double fiyat = base.FiyatHesapla() + 50.0; // 50 TL sabit sigorta bedeli
            Logger.GetInstance().Logla("Kargo ücretine Sigorta eklendi (+50 TL).");
            return fiyat;
        }
    }
}