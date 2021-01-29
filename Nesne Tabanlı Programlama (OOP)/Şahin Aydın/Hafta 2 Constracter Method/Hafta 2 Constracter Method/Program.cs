using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_2_Constracter_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            //Product product1 = new Product();
            //product1.Id = 1;
            //product1.Name = "Computer";
            //product1.Price = 5500;
            //product1.Stock = 45;

            //Product p2 = new Product
            //{
            //    ID = 2,
            //    Name = "Mobile Phone",
            //    Price = 4500,
            //    Stock = 100
            //};

            Product p1 = new Product(1);

            Computer c1 = new Computer(2);
            c1.Price = 6200;
            Console.WriteLine(c1.KDV());

            Coffee cf1 = new Coffee(3);
            cf1.Price = 10;
            Console.WriteLine(cf1.KDV());

            Console.ReadKey();
        }
    }
}
