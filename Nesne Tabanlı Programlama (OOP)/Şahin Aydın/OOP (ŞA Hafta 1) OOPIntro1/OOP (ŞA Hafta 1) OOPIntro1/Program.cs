using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__ŞA_Hafta_1__OOPIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Ad = "maho";
            ogr1.Soyad = "ayd";
            Console.WriteLine(ogr1.GetAd());

            double a = 5.3;
            decimal b = 425.58m;
            float c = 54.58f;


            /*----------------------------*/

            //Urun urn1 = new Urun();
            //urn1.Ad = "Telefon";
            //urn1.Fiyat = 4000;
            //urn1.Stok = 200;
            //decimal sonuc = urn1.ToplamFiyat();
            //Console.WriteLine(urn1.KDV);


            //Urun urn2 = new Urun
            //{
            //    Ad = "PC"
            //    Fiyat = 6200
            //    Stok = 120
            //};

            Urun urun = new Urun("S10+");

            /* ----------------------------------*/

            Matematik mat = new Matematik();
            int s;
            mat.Topla(2, 4, out s);
            Console.WriteLine(s);

            int a = 0;
            mat.Topla(1, 2, 3, ref a);
            Console.WriteLine(a);



            Console.Read();
        }
    }
}
