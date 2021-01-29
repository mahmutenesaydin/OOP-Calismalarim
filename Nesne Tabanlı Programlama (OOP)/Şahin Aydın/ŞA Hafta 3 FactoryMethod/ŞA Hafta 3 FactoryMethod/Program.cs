using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA_Hafta_3_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Dokuman[] dokumanlar = new Dokuman[]
            {
                new Rapor(),
                new Ozgecmiş()
            };
            foreach (Dokuman dkmn in dokumanlar)
            {
                Console.WriteLine("{0} --", dkmn.ToString());
                foreach (Sayfa syf in dkmn.Sayfalar)
                {
                    Console.WriteLine(" " + syf.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
