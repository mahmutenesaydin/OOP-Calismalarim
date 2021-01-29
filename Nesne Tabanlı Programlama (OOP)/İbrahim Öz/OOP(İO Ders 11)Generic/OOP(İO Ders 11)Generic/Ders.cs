using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İO_Ders_11_Generic
{
    class Ders<T>where T:struct
    {
        public string Adi { get; set; }
        public int Kredi { get; set; }
    }
}
