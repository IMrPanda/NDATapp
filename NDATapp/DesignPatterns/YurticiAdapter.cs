using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class YurticiAdapter : IKargoServisi
    {
        private YurticiAPI _yurticiApi = new YurticiAPI();

        public string GonderiOlustur(string paketBilgisi)
        {
            Logger.GetInstance().Logla("Yurtiçi kargo adaptörü tetiklendi.");
            return _yurticiApi.SevkiyatYarat(paketBilgisi);
        }
    }
}