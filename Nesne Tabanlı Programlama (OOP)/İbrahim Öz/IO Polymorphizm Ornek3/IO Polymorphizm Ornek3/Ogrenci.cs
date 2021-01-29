using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Polymorphizm_Ornek3
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TC { get; set; }
        public DateTime DogumTarihi { get; set; }

        public override string ToString()
        {
           // return Adi + " " + Soyadi + " " + TC + " " + DogumTarihi;

            return string.Format("{0}-{1}-{2}-{3}", Adi, Soyadi, TC, DogumTarihi); //Diğer Kullanımı
        }
    }
}
