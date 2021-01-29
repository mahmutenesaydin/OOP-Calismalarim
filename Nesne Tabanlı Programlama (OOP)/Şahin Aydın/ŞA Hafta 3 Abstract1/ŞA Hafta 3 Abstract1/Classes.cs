using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA_Hafta_3_Abstract1
{
    abstract class Urun
    {
        public int Barkod { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public abstract decimal Kdv();
        public abstract decimal KdvliFiyat { get; }
    }
    abstract class TekstilUrunu : Urun
    {

    }
    class Gomlek : TekstilUrunu
    {
        public override decimal KdvliFiyat
        {
            get
            {
                return Fiyat * 1.18m;
            }
        }

        public override decimal Kdv()
        {
            return Fiyat * 0.18m;
        }

        public double YakaGenisligi()
        {
            return 5.00;
        }
    }

    class Pantolon : TekstilUrunu
    {
        public override decimal KdvliFiyat
        {
            get
            {
                return Fiyat * 1.18m;
            }
        }

        public override decimal Kdv()
        {
            return Fiyat * 0.18m;
        }
    }
}
