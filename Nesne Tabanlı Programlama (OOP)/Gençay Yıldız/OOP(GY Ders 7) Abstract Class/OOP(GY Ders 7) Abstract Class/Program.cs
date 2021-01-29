using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Abstract class'da inheritcan(kalıtım)olmalı;
//Abstract Class'ın nesnesi oluşturulmaz fakat referans noktası alınabilir.
namespace OOP_GY_Ders_7__Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek ornek = new Calisma();
            ornek.X();
        }
    }
}
