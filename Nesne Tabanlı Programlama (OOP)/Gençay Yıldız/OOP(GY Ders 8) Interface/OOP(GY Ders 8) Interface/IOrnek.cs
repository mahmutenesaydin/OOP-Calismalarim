using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GY_Ders_8__Interface
{
    interface IOrnek
    {
        int X();
        void Y();

        /*public*/ string Z { get; set; } //interface'de public olmaz
    }


}
