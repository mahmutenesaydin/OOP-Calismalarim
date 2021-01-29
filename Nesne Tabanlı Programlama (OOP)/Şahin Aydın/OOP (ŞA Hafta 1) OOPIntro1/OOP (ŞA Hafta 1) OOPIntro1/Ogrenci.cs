using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__ŞA_Hafta_1__OOPIntro1
{
    class Ogrenci
    {
        private string _ad;
        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        private string _soyad;
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        private string _makam;
        public void SetAd(string Makam)
        {
            _makam = Makam;
        }
        public string GetAd()
        {
            return _makam;
        }
    }
}
