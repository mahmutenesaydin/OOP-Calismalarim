using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__IO_Ders_9__Abstract
{
    class Gitar : MuzikAletleri
    {
        public override CalmaTuru CalmaTuru
        {
            get
            {
                return CalmaTuru.TelliCalma;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Cal()
        {
            return "Gitar çal";
        }
    }
}
