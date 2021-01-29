using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İO_Ders_7__Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Mahmut";
            ogr.Alani = Alan.Sayisal;
            ogr.Cinsiyeti = Cinsiyet.Erkek;
            Console.WriteLine(Enum.GetName(typeof(Alan), ogr.Alani));
            Console.Read();

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Soyadi = "Aydın";
            //ogr2.Alani = Alan.Sözel;
            ogr.Cinsiyeti = Cinsiyet.Kadın;
            ogr.Alani = (Alan)40;
            int sys = (int)Alan.Dil;
            string[] alanlar = Enum.GetNames(typeof(Alan)); 
        }
    }
}
