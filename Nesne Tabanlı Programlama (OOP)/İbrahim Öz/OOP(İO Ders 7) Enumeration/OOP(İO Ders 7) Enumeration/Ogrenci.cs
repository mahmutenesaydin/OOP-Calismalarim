using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_İO_Ders_7__Enumeration
{
    public class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Alan Alani { get; set; }
        public Cinsiyet Cinsiyeti { get; set; }

    }

    /* String, int gibi değerler enum'ların içine yazılmaz.
     * Kelimeler arası boşluklar bırakılmaz.
     * NOT**= Enum'lar kullanıcının seçeceği seçenekler için oluşturulan
              bir yapı değildir.
     * Programcının uygulamasını idame(sürdürebilme) ettirebilmesi için kullanılır.
     * Enum sınıfı içerisinde 2 tane metot vardır;
     -- GetName = Verilen enum seçeneğinin değerini dönderir.  Enum.GetName(typeof(Alan),ogr.Alani);
    -- GetNames = Geriye string dizisi dönderir. Geriye belirtilen enum tipinin içerisindeki tüm
                  seçeneckleri string olarak dönderir.   Enum.GetNames(typeof(Alan));
     */
    public enum Alan
    {
        Sayisal,     //0
        EşitAğırlık, //1
        Sözel,       //2
        Dil=40       //3
    }
}
