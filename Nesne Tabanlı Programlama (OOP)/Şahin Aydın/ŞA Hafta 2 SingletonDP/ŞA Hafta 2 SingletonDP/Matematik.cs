using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA_Hafta_2_SingletonDP
{
    //Singleton Design Pattern

    class Matematik
    {
        private static Matematik instance;
        private Matematik()
        {

        }
        
        public static Matematik Instance()
        {
            if (instance == null)
                instance = new Matematik();
            return instance;
        }
    }
}
