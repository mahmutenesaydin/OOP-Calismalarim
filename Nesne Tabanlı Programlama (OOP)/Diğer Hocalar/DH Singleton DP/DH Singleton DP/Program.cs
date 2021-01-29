using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH_Singleton_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton sing1 = Singleton.GetInstance();
            Console.WriteLine(sing1.id.ToString());

            Singleton sing2 = Singleton.GetInstance();
            Console.WriteLine(sing2.id.ToString());


            Console.ReadKey();
        }
    }
}
