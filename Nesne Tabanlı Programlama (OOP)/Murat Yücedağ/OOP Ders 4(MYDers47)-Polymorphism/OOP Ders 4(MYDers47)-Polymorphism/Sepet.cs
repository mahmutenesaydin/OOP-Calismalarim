using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ders_4_MYDers47__Polymorphism
{
    public class Sepet
    {
        private List<Urun> Urunler = new List<Urun>();
        public double ToplamTutar()
        {
           double ToplamFiyat = 0;
           foreach (Urun ekle in Urunler)
            {
                ToplamFiyat += ekle.KDV();
            }
            return ToplamFiyat; 
        }
        public void UrunEkle(Urun YeniUrun)
        {
            Urunler.Add(YeniUrun);
        }
    }
}
