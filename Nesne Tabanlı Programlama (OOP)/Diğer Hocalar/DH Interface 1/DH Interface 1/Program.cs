using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IKayit kayit = new Kayit();
            kayit.Kaydet();
            kayit.Sil();
            kayit.Güncelle();
        }
    }
    interface IKayit
    {
        void Kaydet();
        void Güncelle();
        void Sil();
    }
    class Kayit : IKayit
    {
        public void Güncelle()
        {
            Console.WriteLine("Güncelle");
        }

        public void Kaydet()
        {
            Console.WriteLine("Kaydet");
        }

        public void Sil()
        {
            Console.WriteLine("Sil");
        }
    }
}
