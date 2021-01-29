using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GY_Ders__interface_2.ornek
{
    class Class1 : IA, IB
    {// public olmamasına rağmen Program.cs'de çalışıyor çünkü interface'in kendine has özelliklerinden birisidir.
        void IA.a()
        {
            throw new NotImplementedException();
        }

        void IB.b()
        {
            throw new NotImplementedException();
        }

        void IA.e() 
        {
            throw new NotImplementedException();
        }

        void IB.m()
        {
            throw new NotImplementedException();
        }

        void IA.m()
        {
            throw new NotImplementedException();
        }

        void IB.s()
        {
            throw new NotImplementedException();
        }
    }
}
