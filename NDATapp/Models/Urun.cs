using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models.Interfaces;

namespace NDATapp.Models
{
    public class Urun : IUrun
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public List<string> Bilesenler { get; set; } = new List<string>();

        // Basit ürün olan kalem için
        public Urun(string ad, double fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
    }
}