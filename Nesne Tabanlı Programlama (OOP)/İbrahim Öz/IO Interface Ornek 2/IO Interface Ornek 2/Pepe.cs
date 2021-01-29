using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Interface_Ornek_2
{
    class Pepe : Futbolcu, ISavunma
    {
        public string SavunmaYap()
        {
            return "Savunma Yapıldı";
        }
    }
}
