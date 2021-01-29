using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İO_Ders_2_Constructor
{
    class Personel
    {
        public Personel()
        {
            KayitTarihi = DateTime.Now;
        }
        public Personel(string Ad)
        {
            Adi = Ad;
        }
        public Personel(string Ad,string Soyad,DateTime DgmTar,string tc)
        {
            Adi = Ad;
            Soyadi = Soyad;
            DogumTarihi = DgmTar;
            TC = tc;
        }
        internal string Adi;
        internal string Soyadi;
        internal DateTime DogumTarihi;
        internal string TC;
        public DateTime KayitTarihi;
    }
}
