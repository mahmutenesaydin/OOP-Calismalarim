using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Bir metodun abstract olması "o metot miras verilen sınıflarda ezilmek zorundadır" anlamındadır.
 *  Abstract metotların gövdesi olmaz; yani {} içine yazı yazılmaz
 *  Abstract metotlar, abstract olmayan sınıflarda bulunmaz.
 *  Sınıf abstract olsa da içerisinde abstract olmayan metot veya property bulunabilir.
 *  Ancak abstract  bir metot veya bir property abstract olmayan sınıfta bulunmaz. 
*/

namespace OOP__IO_Ders_9__Abstract
{
    abstract class MuzikAletleri
    {
        public abstract string Cal();
        public string Mensei { get; set; }
        public DateTime UretimTarihi { get; set; }
        public abstract CalmaTuru CalmaTuru { get; set; }
    }
}
