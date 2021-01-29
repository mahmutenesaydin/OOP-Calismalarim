using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Interface_Ornek_2
{
    class Quaresma : Futbolcu, IOyunKurabilir,IGolAtar
    {
        public string CalimAt(float Hiz)
        {
            return string.Format("{0} hızla çalım atıldı", Hiz);
        }

        public string OyunKurar()
        {
            return "Oyun Kuruldu";
        }

        public string SutCeksin(float Hiz, float Mesafe)
        {
            string.Format("{0}hızıyla {1} mesafeye kadar şut çekildi", Hiz, Mesafe);
        }
    }
}
