using NDATapp.Models.Interfaces;

namespace NDATapp.DesignPatterns
{
    // Base Decorator
    public abstract class KargoDecorator : IKargoUcret
    {
        protected IKargoUcret _sarmalanan;

        public KargoDecorator(IKargoUcret sarmalanan)
        {
            _sarmalanan = sarmalanan;
        }

        public virtual double FiyatHesapla()
        {
            return _sarmalanan.FiyatHesapla();
        }
    }
}