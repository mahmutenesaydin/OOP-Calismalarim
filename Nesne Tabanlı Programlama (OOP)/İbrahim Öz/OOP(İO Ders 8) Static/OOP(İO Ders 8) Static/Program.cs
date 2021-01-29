using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İO_Ders_8__Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "Maho";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Soyadi = "Ayd";

            Ogrenci.TanimliOgrenciSayisi = 5;
            Console.WriteLine(Ogrenci.Ekle());
            Console.Read();
        }
    }
}
