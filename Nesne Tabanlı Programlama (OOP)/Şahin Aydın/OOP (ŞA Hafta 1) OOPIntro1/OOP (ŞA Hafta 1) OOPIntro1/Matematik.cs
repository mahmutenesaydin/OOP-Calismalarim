using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__ŞA_Hafta_1__OOPIntro1
{
    class Matematik
    {
        //Method signature
        public int Topla(int a,int b)
        {
            return a + b;
        }
        public int Topla(int y)
        {
            return 10 + y;
        }
        public void Topla(int x,int y, out int t)
        {
            t = x + y;
        }
        public void Topla(int x,int y,int z,ref int t)
        {
            t = x + y + z;
        }

    }
}
