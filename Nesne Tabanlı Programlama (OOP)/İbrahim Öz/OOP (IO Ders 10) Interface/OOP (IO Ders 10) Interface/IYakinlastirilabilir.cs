using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    INTERFACE = İçerisinde property, metot indexleyici ve event haricinde birşey bulunmaz.
    // Interface içerisindeki elemanların abstract sınıflarda olduğu gibi GÖVDESİ BULUNMAZ.
    // Interface'nin, Abstract'dan 1.farkı;
     * Gövdesi olan method veya property yazamayız;
     * Interface içersindeki elemanların access modifers'ları bulunmaz ve varsayılan access
       modifiers'leri PUBLIC'dir
    // Interface sınıflardan instance üretilemez.
    
 */

namespace OOP__IO_Ders_10__Interface
{
    public interface IYakinlastirilabilir
    {
        string Yakinlastir();
    }
}
