using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;
using NDATapp.Models;

namespace NDATapp.Models
{
    public class EmailObserver : IStokObserver
    {
        public void Bildir(string mesaj)
        {
            Logger.GetInstance().Logla($"[SATIN ALMA BİRİMİNE E-POSTA GÖNDERİLDİ] {mesaj}");
        }
    }
}
