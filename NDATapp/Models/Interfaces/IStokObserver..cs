using System;
using System.Collections.Generic;
using System.Text;

namespace NDATapp.Models.Interfaces
{
    public interface IStokObserver
    {
        void Bildir(string mesaj);
    }
}
