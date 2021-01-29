using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Calisma_3__DH_
{
    class Kartal : Hayvan
    {
        public override string Cinsi
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Avlan()
        {
            return "Uçarak avlandı";
        }
        class KopekBaligi : Hayvan
        {
            public override string Cinsi
            {
                get
                {
                    throw new NotImplementedException();
                }

                set
                {
                    throw new NotImplementedException();
                }
            }

            public override string Avlan()
            {
                return "Yüzerek avlandı";
            }
        }
    }
}
