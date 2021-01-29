using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Bir sınıf içerisinde tanımlanan değişkenlere Field(Alan)denir

namespace OOP_İO_Ders_3_Encapsulation__Kapsülleme
{
    class Urun
    {

        private string _adi;//FİELD
        public string Adi //PROPERTY
        {
            get
            {
                if (_adi == "Enes")
                {
                    return "Hoşgeldiniz";
                }
                else
                {
                    return "Hatalı giriş";
                }
            }
            set
            {
                _adi = value;
            }
        }

        private decimal _fiyat;
        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                _fiyat = value;
            }
        }

        //private decimal _kdvliFiyat;  /* SET'i kullanmayacağımız için bunu açmamıza gerek yok*/ 
        public decimal KdvliFiyat
        {
            get
            {
                return Fiyat + (Fiyat * 0.18m);
            }
        }

                   /*AUTO PROPERTY*/
        //Arka plandaki Field'ını kendi içerisinde tutar.
        //Field tanımlanmaz
        //Get ve Set metodları değiştirilmez. Değiştirilmek istenirse auto property bozulur. Arka plandaki field'ını elimizde tanımlamamız gerekir.

        public string Soyadi { get; set; }
    }
}



//YUKARIDAKİ YAZDIĞIMIZ AŞAĞIDAKİNİN OOP ŞEKLİ, İKİSİ DE AYNI ŞEY



//public string Adi;

//public void AdiYaz(string deger)
//{
//    if (deger == "Enes")
//    {
//        Adi = deger;
//    }
//    else
//    {
//        MessageBox.Show("Hatalı giriş");
//    }        
//}
//public string AdiOku()
//{
//    if (true)
//    {
//        //Geriye adi değerini döndermeden bir işlem yapabiliriz;
//    }
//    return Adi;
//}

//    }
//}
