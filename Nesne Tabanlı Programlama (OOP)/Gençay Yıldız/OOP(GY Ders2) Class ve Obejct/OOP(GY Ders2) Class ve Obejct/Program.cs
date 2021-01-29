using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GY_Ders2__Class_ve_Obejct
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci Ogr = new Ogrenci();
            string sonuc = Ogr.Hosgeldiniz("Mahmut Enes", "Aydın");
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
