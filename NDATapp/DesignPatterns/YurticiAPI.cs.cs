using System;

namespace NDATapp.DesignPatterns
{
    public class YurticiAPI
    {
        public string SevkiyatYarat(string detay)
        {
            return "YRT-" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();
        }
    }
}