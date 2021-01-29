using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GY_Ders4__Constructer_Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Ornek ornek = new Ornek();
            Console.WriteLine(ornek.sayi.ToString());
            Console.Read();

            Ornek orn = new Ornek(77);
            Console.WriteLine(orn.sayi.ToString());
            Console.ReadKey();
        }
    }
}
