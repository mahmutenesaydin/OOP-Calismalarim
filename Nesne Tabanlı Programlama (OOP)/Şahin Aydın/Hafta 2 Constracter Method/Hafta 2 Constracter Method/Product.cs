using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_2_Constracter_Method
{   //BASE CLASS
    class Product
    {
        public Product(int _id)
        {
            ID = _id;
        }

        public Product(int _id, string _name, decimal _price, int _stock)
        {
            ID = _id;
            Name = _name;
            Price = _price;
            Stock = _stock;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public virtual decimal KDV()
        {
            return Price * 0.18m;
        }
    }
}
