using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Polymorphizm_Ornek2
{
    class TekstilUrunu : Urun
    {
        public string KumasTipi { get; set; }
        public string Rengi { get; set; }
        public string KumasKalitesi { get; set; }
        public object UrunEkle { get; internal set; }

        public override decimal KDVliFiyat()
        {
            return Fiyat + (Fiyat * 0.08m);
        }
    }
}
