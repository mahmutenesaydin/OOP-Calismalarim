using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ders_4_MYDers47__Polymorphism
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }
        public virtual double KDV()
        {
            return Fiyat * 1.08;
        }
        public Urun()
        {

        }
        public Urun(string Ad, double fiyat)
        {
            UrunAdi = Ad;
            Fiyat = fiyat;
        }
    }
}
