using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Interface_Ornek_2
{
    class Futbolcu
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public float Boy { get; set; }
        public float Kilo { get; set; }
        public int FormaNumarasi { get; set; }
        public string Takimi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Yas
        {
            get
            {
                int yas = DateTime.Now.Year - DogumTarihi.Year;
                return yas;
            }
        }
    }
}
