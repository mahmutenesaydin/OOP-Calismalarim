using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__GY_Ders3__Field_ve_Property
{
    class Ornek
    {
        //Field
        string _ad;
        //Property
        public string Ad
        {
            //Fieldimiza değer aktarma bloğudur;
            set
            {
                _ad = value;
            }
            //fieldımıza geri değer döndürür;
            get
            {
                return _ad;
            }
        }
        //------------------------
        //ReadOnly Property;
        int _sayi = 10;
        public int Sayi
        {
            get
            {
                return _sayi;
            }
        }
        //WriteOnly Property;
        string soyisim;
        public string Soyisim
        {
            set
            {
                soyisim = value;
            }
        }
        //KOLAY KULLANIMLI PROPERTY
        public int Rakam { get; set; }

        public string ornek { get; private set; } //ReadOnly Property
        public double örnek { private get; set; } //WriteOnly Property
    }
}
