using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Polymorphizm_Ornek2
{
    class Sepet : Urun
    {
        public decimal ToplamFiyat { get; set; }

        public void UrunEkle(Urun urn)
        {
            ToplamFiyat += urn.KDVliFiyat();
        }
    }
}
