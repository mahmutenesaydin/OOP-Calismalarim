using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GY_Ders4__Constructer_Metod
{
    class Ornek
    {
        //1.) Sınıf ismiyle aynı olmalıdır.
        //2.) Geri dönüş tipi olmamalıdır.
        //3.) Constructer(Yapıcı)metod olmadan RAM'da nesne(object)üretilmez.

        public int sayi;
        public Ornek()
        {   //Bu Constructer metodu yazdığımız anda Default Constructer metod ezilmiştir.
            sayi = 13;
        }
        //---------------------------------
        public Ornek(int SayiDegeri)
        {
            sayi = SayiDegeri;
        }
    }
}
