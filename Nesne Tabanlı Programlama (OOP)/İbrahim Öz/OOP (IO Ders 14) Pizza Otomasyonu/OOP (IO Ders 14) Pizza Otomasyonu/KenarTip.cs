using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__IO_Ders_14__Pizza_Otomasyonu
{
    class KenarTip
    {
        public string Adi { get; set; }
        public decimal EkFiyat { get; set; }
        public Ebat Ebati { get; set; }
        public KenarTip KenarTipi { get; set; }
    }
}
