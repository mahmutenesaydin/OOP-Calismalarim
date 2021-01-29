using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Önce Abstract olan yazılır sonra ise Interface olan(önce interface'yi yazarsak geriye kalanları da interface olarak algılar);

namespace OOP__IO_Ders_10__Interface
{
    class Kanas : AtesliSilahlar, IYakinlastirilabilir
    {
        public string Yakinlastir()
        {
            return "Yakınlaştırıldı";
        }
    }
}
