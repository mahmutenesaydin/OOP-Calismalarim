using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ders_4_MYDers47__Polymorphism
{
    public class Ekmek : Urun
    {
        public string EkmekTuru { get; set; }
        public int Gram { get; set; }
        public override double KDV()
        {
            return Fiyat * 1.01;
        }
        public Ekmek(string Ad, double fiyat, string ekmekturu, int gram)
        {
            UrunAdi = Ad;
            Fiyat = fiyat;
            EkmekTuru = ekmekturu;
            Gram = gram;
        }
    }
}
