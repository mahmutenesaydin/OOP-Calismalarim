using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Interface_Ornek_2
{
    class CenkTosun : Futbolcu, IGolAtar
    {
        public string SutCeksin(float Hiz, float Mesafe)
        {
            return string.Format("{0} hızıyla {1} mesafeye kadar şut çekildi", Hiz, Mesafe);
        }
    }
}
