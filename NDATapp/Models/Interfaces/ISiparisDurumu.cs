using System;
using System.Collections.Generic;
using System.Text;
using NDATapp.Models;

namespace NDATapp.Models.Interfaces
{
    public interface ISiparisDurumu
    {
        void IleriGec(Siparis s);
        void IptalEt(Siparis s);
    }
}
