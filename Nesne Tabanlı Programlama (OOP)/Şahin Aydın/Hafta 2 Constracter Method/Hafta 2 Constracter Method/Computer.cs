using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_2_Constracter_Method
{
    //Inheritance (Kalıtım/Miras)
    //Derived Class
    class Computer : Product
    {
        public Computer(int id):base(id)
        {

        }
        public int HddCapasity { get; set; }
        public int RamCapasity { get; set; }
    }
}
