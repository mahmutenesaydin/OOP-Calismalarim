using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__IO_Ders_10__Interface
{
    class Oyuncu
    {
        public string Adi { get; set; }
        public int Yasi { get; set; }
        public int YasamDegeri { get; set; }
        public Silah Silahi { get; set; }
        public string NisanAl()
        {
            //Nişan alma işlemleri yapılacak
            //Silahi property'si IYakinlastirabilir interface'sini implemente almış ise yani o yeteneği kazanmış işe;
            if (Silahi is IYakinlastirilabilir)
            {
                IYakinlastirilabilir iy = (IYakinlastirilabilir)Silahi;
                return iy.Yakinlastir();
            }
            else
                return "";
        }
        public void Saldir()
        {//Saldırma işlemleri yapılacak

        }
    }
}
