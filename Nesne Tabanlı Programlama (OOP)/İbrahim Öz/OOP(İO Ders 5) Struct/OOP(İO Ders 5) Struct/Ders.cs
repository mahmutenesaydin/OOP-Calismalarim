using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İO_Ders_5__Struct
{
    struct Ders
    {
        public string Adi { get; set; }
        public string Kitabi { get; set; }
        public int Kredi { get; set; }
        public int DersSaati { get; set; }
        public Ders Dersi { get; set; }
    }
}
