using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA_Hafta_2_SingletonDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik mat1 = Matematik.Instance();
            Matematik mat2 = Matematik.Instance();

            if (mat1==mat2)
            {
                Console.WriteLine("Aynı");
            }
            else
            {
                Console.WriteLine("Farklı");
            }
            Console.ReadKey();
        }
    }
}
