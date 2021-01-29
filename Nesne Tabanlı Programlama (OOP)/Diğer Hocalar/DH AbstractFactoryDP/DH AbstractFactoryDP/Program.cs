using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH_AbstractFactoryDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory(new InterbaseFactory());
            factory.Start();

            Factory fact2 = new Factory(new Db2Factory());
            fact2.Start();

            Console.Read();
        }
    }
}
