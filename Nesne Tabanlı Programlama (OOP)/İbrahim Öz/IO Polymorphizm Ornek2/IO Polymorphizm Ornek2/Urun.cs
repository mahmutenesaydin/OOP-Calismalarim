using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Polymorphizm_Ornek2
{
    class Urun
    {
        public string Adı { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }

        public virtual decimal KDVliFiyat()
        {
            return Fiyat + (Fiyat * 0.18m);
        }
    }
}
