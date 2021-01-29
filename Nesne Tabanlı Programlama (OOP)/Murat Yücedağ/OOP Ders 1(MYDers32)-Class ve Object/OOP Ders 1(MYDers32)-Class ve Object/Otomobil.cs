using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ders_1_MYDers32__Class_ve_Object
{
    class Otomobil
    {
        public string Marka { get; set; }

        public string Model { get; set; }

        public int ModelYılı { get; set; }

        public string Renk { get; set; }

        public string VitesTipi { get; set; }

        public string MarkaGetir()
        {
            return Marka;
        }
    }
}
