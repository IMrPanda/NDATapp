using System;

namespace NDATapp.DesignPatterns
{
    public class ArasAPI
    {
        public string KargoOlustur(string bilgi)
        {
            return "ARAS-" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        }
    }
}