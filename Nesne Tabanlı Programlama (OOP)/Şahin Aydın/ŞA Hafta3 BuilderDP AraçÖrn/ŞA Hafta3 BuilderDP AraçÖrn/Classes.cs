using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    -Mağazamızda Motosiklet, Scooter, Otomobil gibi araçlar satılmaktadır. Bu araç isimleri aynı zamanda mağazada satılan araç tipleridir.
    -Araçlarlar kasa, motor, tekerler,kapı gibi parça tiplerinden oluşur.
    -Her bir araç farklı bir birim tarafından üretilmektedir. Örneğin Motosiklet üreticisi, Scooter üreticisi, Otomobil üreticisi... 
   */

/// <summary>
/// Builder Design Pattern
/// </summary>

namespace ŞA_Hafta3_BuilderDP_AraçÖrn
{
    enum AracTipi
    {
        Otomobil,
        Motosiklet,
        Scooter
    }
    public enum ParcaTipi
    {
        Kasa,
        Motor,
        Tekerlek,
        Kapi
    }

    class Arac
    {
        private AracTipi Tipi { get; set; }
        private Dictionary<ParcaTipi, string> _parcalar = new Dictionary<ParcaTipi, string>();
        public Arac(AracTipi _aracTipi)
        {
            Tipi = _aracTipi;
        }

        public string this[ParcaTipi key]
        {
            get { return _parcalar[key]; }
            set { _parcalar[key] = value; }
        }
        public void Goster()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("#Araç Tipi: {0}", Tipi);
            Console.WriteLine("#Kasa Tipi: {0}", this[ParcaTipi.Kasa]);
            Console.WriteLine("#Motor Tipi: {0}", this[ParcaTipi.Motor]);
            Console.WriteLine("#Tekerlek Sayısı: {0}", this[ParcaTipi.Tekerlek]);
            Console.WriteLine("@Kapı Sayısı : {0}", this[ParcaTipi.Kapi]);
        }
    }
    abstract class AracUreticisi
    {
        public Arac Arac { get; private set; }
        public AracUreticisi(AracTipi _aracTipi)
        {
            Arac = new Arac(_aracTipi);
        }
        public abstract void MotorUret();
        public abstract void KasaUret();
        public abstract void KapiUret();
        public abstract void TekerlekUret();
    }
    class MotorsikletUretici : AracUreticisi
    {
        public MotorsikletUretici(AracTipi _aracTipi) : base(_aracTipi)
        {

        }
        public override void KapiUret()
        {
            Arac[ParcaTipi.Kapi] = "0";
        }

        public override void KasaUret()
        {
            Arac[ParcaTipi.Kasa] = "Motorsiklet Kasası";
        }

        public override void MotorUret()
        {
            Arac[ParcaTipi.Motor] = "500 cc";
        }

        public override void TekerlekUret()
        {
            Arac[ParcaTipi.Tekerlek] = "2";
        }
    }

    class OtomobilUreticisi : AracUreticisi
    {
        public OtomobilUreticisi(AracTipi _aracTipi):base(_aracTipi)
        {

        }

        public override void KapiUret()
        {
            Arac[ParcaTipi.Kapi] = "5";
        }

        public override void KasaUret()
        {
            Arac[ParcaTipi.Kasa] = "Hatchback";
        }

        public override void MotorUret()
        {
            Arac[ParcaTipi.Motor] = "2500 cc";
        }

        public override void TekerlekUret()
        {
            Arac[ParcaTipi.Tekerlek] = "4";
        }
    }
    
    class Dukkan
    {
        private AracUreticisi _uretici;
        public void Olustur(AracUreticisi Uretici)
        {
            _uretici = Uretici;
            _uretici.KapiUret();
            _uretici.KasaUret();
            _uretici.MotorUret();
            _uretici.TekerlekUret();
        }

        public void AraciGoster()
        {
            _uretici.Arac.Goster();
        }
    }
}
