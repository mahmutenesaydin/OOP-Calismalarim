using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Generic = Dışarıdan bir tip alarak çalışmayı sağlayan yapıdır.

namespace OOP_İO_Ders_11_Generic
{
    class Ogrenci<T,H,Y> where T:class where H:struct
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Y OkulNo { get; set; }
        public H Okulu { get; set; }
        public T TemsiliTip { get; set; }

        public void Ekle(T prm)
        {

        }
    }
}
