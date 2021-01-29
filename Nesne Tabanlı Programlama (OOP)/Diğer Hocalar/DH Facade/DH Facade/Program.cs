using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade fcd = new Facade();
            fcd.UseCredit(new Customer { Name = "Mahmut", TC = "445", ID = 58 }, 100);

            Console.Read();
        }
    }
}
