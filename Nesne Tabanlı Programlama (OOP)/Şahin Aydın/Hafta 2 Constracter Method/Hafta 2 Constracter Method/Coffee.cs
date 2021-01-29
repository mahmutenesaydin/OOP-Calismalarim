using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_2_Constracter_Method
{
    class Coffee:Product
    {
        public Coffee(int id):base(id)
        {

        }
        public override decimal KDV()
        {
            return Price * 0.08m;
        }
    }
}
