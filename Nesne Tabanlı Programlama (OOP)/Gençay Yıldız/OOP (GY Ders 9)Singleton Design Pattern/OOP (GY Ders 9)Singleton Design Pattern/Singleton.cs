using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Singeton d.p.'de Constracter methodumu private olmalıdır çünkü constracter'ı private olan bir sınıftan nesne üretilmez.


namespace OOP__GY_Ders_9_Singleton_Design_Pattern
{
    class Singleton
    {
        private Singleton()
        {

        }
        private static Singleton nesne;
        public static Singleton NesneVer()
        {
            if (nesne==null)
            {
                nesne = new Singleton();
            }
            return nesne;
        }


        //Singleton'un diğer kullanım şekli ; 
        public static Singleton NesneVerr
        {
            get
            {
                return nesne;
            }
        }
        static Singleton()
        {
            nesne = new Singleton();
        }

    }
}
