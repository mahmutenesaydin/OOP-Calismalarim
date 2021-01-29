using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Calisma_3__DH_
{
    public abstract class Hayvan
    {
        public string Ismi { get; set; }
        public abstract string Cinsi { get; set; }

        public abstract string Avlan();
    }
}
