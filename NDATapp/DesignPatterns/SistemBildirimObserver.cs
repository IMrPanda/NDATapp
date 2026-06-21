using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.DesignPatterns
{
    public class SistemBildirimObserver : IStokObserver
    {
        public void Bildir(string mesaj)
        {
            Logger.GetInstance().Logla($"[DEPO SORUMLUSUNA BİLDİRİM] {mesaj}");
        }
    }
}