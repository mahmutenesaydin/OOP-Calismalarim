using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Polymorphizm_Ornek2
{
    class Ekmek : Urun
    {
        public double Gramaj { get; set; }
        public string EkmekTipi { get; set; }

        public override decimal KDVliFiyat()
        {
            return Fiyat + (Fiyat * 0.01m );
        }
    }
}
