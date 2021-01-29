using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// STATİC = Sınıftan instance almadan sınıfın sonuna nokta koyarak STATIC elemana ulaşmamızı sağlar.
// Static metodlar içersinde static olmayan elemanlara ulaşılamaz.
// Static metotlar içerisinde sadece static elemanlara ulaşılabilir.

namespace OOP_İO_Ders_8__Static
{
    class Ogrenci
    {
        public Ogrenci()
        {
            TanimliOgrenciSayisi++;
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string OkulNo { get; set; }
        public string Sinif{ get; set; }
        public static int TanimliOgrenciSayisi { get; set; }

        public static int Ekle()
        {
            return TanimliOgrenciSayisi;
        }
    }
}
