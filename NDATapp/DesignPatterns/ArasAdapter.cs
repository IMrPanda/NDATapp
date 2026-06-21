using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class ArasAdapter : IKargoServisi
    {
        private ArasAPI _arasApi = new ArasAPI();

        public string GonderiOlustur(string paketBilgisi)
        {
            Logger.GetInstance().Logla("Aras kargo adaptörü tetiklendi.");
            return _arasApi.KargoOlustur(paketBilgisi);
        }
    }
}