    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA_Hafta_2_Static
{
    class MetinIsleme
    {
        public static int AdetBul(string metin,string aranan)
        {
            int metinUzunluk = metin.Length;
            string yeniMetin = metin.Replace(aranan, "");
            int yeniMetinUzunluk = yeniMetin.Length;
            int adet = (metinUzunluk - yeniMetinUzunluk) / aranan.Length;
            return adet;
        }
    }
}
