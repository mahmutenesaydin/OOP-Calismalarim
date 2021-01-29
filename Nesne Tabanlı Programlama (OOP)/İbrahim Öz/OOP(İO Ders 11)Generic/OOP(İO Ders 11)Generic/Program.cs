using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İO_Ders_11_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Maho");
            list.Add(true);
            list.Add('a');
            list.Add(2);

            string isim = (string)list[0];

            List<string> isimler = new List<string>();
            isimler.Add("Enes");
            List<int> sayilar = new List<int>();
            sayilar.Add(2);

            int sayi = sayilar[0];


            //-----------------------------------------------

            Ogrenci<string,int,decimal> ogr1 = new Ogrenci<string,int,decimal>();
            Ogrenci<Ders<int>,float,bool> ogr2 = new Ogrenci<Ders<int>,float,bool>();

            MetotGeneric mg = new MetotGeneric();
            mg.Ekle<int>(1);
            mg.Ekle<string>("ad");
        }
    }
}
