using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH_Facade
{
    class Facade
    {
        private Bank _banka;
        private CentrelBank _merkezBanka;
        private Credit _kredi;

        public Facade()
        {
            _banka = new Bank();
            _merkezBanka = new CentrelBank();
            _kredi = new Credit();
        }

        public void UseCredit(Customer _cus, decimal _talep)
        {
            if (!_merkezBanka.KaraListeKontrol(_cus.TC) && _kredi.KrediKullanmaDurumu(_cus))
            {
                _banka.UseCredit(_cus, _talep);
                Console.WriteLine("Kredi kullandırıldı");
            }
        }

    }
}
