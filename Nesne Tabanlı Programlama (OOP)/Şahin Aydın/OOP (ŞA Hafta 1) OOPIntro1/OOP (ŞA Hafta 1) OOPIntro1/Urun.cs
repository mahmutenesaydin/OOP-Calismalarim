using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__ŞA_Hafta_1__OOPIntro1
{
     class Urun
    {
        public Urun(string _ad)
        {
            Ad = _ad;
        }
        public Urun(string _ad, int _stok)
        {
            Ad = _ad;
            Stok = _stok;
        }

        public string Ad { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }


        //Sadece okunabilir bir özellik olarak KDVli fiyatı görmek istiyoruz.
        public decimal KDV
        {
            get
            {
                return Fiyat * 0.18m;
            }
        }
        public decimal ToplamFiyat()
        {
            return Stok * Fiyat;
        }
    }
}
