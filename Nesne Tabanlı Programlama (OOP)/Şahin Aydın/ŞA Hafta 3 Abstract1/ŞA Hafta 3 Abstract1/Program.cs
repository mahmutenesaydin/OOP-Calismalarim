using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA_Hafta_3_Abstract1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gomlek gomlek = new Gomlek();
            gomlek.Fiyat = 124;
            decimal kdvliFiyat = gomlek.KdvliFiyat;
            Console.WriteLine(kdvliFiyat);

            TekstilUrunu pantolon = new Pantolon();
            Gomlek gmlk = new Gomlek();

            List<Urun> urunler = new List<Urun>
            {
                new Gomlek(),
                new Pantolon()
            };
            Console.ReadKey();
        }
    }
}
