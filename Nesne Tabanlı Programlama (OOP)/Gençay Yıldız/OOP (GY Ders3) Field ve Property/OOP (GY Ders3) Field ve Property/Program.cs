using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__GY_Ders3__Field_ve_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek ornek = new Ornek();
            ornek.Ad = "Maho";
            Console.WriteLine(ornek.Ad);
            Console.Read();

            //READoNLY PROPERTY; -->
            //int Sayi = ornek.Sayi;
            //Console.WriteLine(Sayi.ToString());
            //Console.Read();

            //WRITEoNLY PROPERTY; -->
            //ornek.Soyisim = "Aydın";

            //KOLAY KULLANIMLI PROPERTY -->
            //ornek.Rakam = 13;
            //Console.WriteLine(ornek.Rakam.ToString());
            //Console.Read();

        }
    }
}
