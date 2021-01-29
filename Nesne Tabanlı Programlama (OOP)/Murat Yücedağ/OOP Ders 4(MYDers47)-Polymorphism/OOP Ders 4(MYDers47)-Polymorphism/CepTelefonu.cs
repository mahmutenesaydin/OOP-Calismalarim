using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ders_4_MYDers47__Polymorphism
{
    public class CepTelefonu : Urun
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }
        public CepTelefonu(string Ad, double fiyat, string marka)
        {
            UrunAdi = Ad;
            Fiyat = fiyat;
            Marka = marka;
        }
    }
}
