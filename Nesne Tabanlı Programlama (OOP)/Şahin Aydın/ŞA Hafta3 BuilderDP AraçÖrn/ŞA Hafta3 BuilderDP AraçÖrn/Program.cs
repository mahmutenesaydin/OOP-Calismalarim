using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA_Hafta3_BuilderDP_AraçÖrn
{
    class Program
    {
        static void Main(string[] args)
        {
            var dukkan = new Dukkan();

            dukkan.Olustur(new MotorsikletUretici(AracTipi.Motosiklet));
            dukkan.AraciGoster();

            dukkan.Olustur(new OtomobilUreticisi(AracTipi.Otomobil));
            dukkan.AraciGoster();

            Console.ReadKey();
        }
    }
}
