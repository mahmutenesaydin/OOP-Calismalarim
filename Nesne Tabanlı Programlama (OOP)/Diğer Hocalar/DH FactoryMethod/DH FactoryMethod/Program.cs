using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator olustur = new Creator();
            Screen Win = olustur.ScreenFactory(ScreenModel.Windows);
            Screen Mobile = olustur.ScreenFactory(ScreenModel.Mobile);

            Win.Draw();
            Mobile.Draw();



            //Factory method 2.KULLANIMI

            Console.WriteLine("----------------");

            Creator2[] cr2 =
            {
                new WinScreen(),
                new MobilScreen()
            };

            foreach (Creator2 creator in cr2)
            {
                Screen _screen = creator.ScreenFactory();
                _screen.Draw();
            }

            Console.ReadKey();
        }
    }
}
