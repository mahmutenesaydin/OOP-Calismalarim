using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Interface_Ornek_2
{
    class Fabri : Futbolcu, ITopTutabilir
    {
        public string TopTut()
        {
            return "Top tutuldu";
        }
    }
}
