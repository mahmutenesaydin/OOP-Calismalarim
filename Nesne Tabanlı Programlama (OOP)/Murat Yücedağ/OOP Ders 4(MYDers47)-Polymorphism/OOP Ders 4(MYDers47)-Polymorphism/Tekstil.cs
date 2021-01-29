using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ders_4_MYDers47__Polymorphism
{
    public class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public int Beden { get; set; }
        public string UreticiFirma { get; set; }
        public Tekstil(string Ad, double fiyat, string kumasturu, int beden)
        {
            UrunAdi = Ad;
            Fiyat = fiyat;
            KumasTuru = kumasturu;
            Beden = beden;
        }
    }
}
