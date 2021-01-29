using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*   VIRTUAL ==> İşaretlenmiş metot isteğe bağlı olarak türetilen sınıflarda değiştirilebilir demektir. Yani bu metot ezilebilir.
    OVERRIDE ==> Metodu ezmek anlamına geliyor. Çalışma yapısını değiştirmemizi sağlıyor.
*/

namespace IO_Inheritance_2.Ornek
{
    class Yemek
    {
        public string PismeSuresi { get; set; }
        public string Malzemeler { get; set; }
        public string AciTipi { get; set; }
        public string Asci { get; set; }
        public string PismeSekli { get; set; }
        public string PismeYeri { get; set; }

        public virtual string SunumSekli()
        {
            return "Yanında az pilav ve salata";
        }
    }

}
