using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH_Singleton_DP
{
    class Singleton
    {
        private static Singleton _instance;
        private static Guid ID;
        private static object _lockObject = new object();

        public Guid id
        {
            get { return Singleton.ID; }
        }

        private Singleton(Guid id)
        {
            ID = id;
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                        _instance = new Singleton(Guid.NewGuid());


                }
            }
            return _instance;
        }
    }
}
