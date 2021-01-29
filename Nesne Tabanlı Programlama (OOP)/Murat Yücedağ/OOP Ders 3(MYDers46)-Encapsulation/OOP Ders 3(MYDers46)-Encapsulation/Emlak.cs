using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ders_3_MYDers46__Encapsulation
{
    class Emlak
    {
        private string semt;
        private int odaSayısı;
        private int katNo;
        private int alan;

        public string Semt
        {
            get { return semt; }
            set { semt =value.ToUpper(); }
        }

        public int OdaSayısı
        {
            get { return odaSayısı; }
            set { odaSayısı = Math.Abs(value); }
        }

        public int KatNo
        {
            get { return katNo; }
            set { katNo = Math.Abs(value); }
        }
        public int Alan
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }
}
