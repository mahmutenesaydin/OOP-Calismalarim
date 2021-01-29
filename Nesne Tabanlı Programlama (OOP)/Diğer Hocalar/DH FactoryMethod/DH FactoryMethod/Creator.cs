using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        // FACTORY METHOD

namespace DH_FactoryMethod
{
    enum ScreenModel
    {
        Windows,
        Mobile
    }
    class Creator
    {
        public Screen ScreenFactory(ScreenModel _screenModel)
        { 
            Screen _screen = null;

            switch (_screenModel)
            {
                case ScreenModel.Windows:
                    _screen = new WindowsScreen();
                    break;
                case ScreenModel.Mobile:
                    _screen = new MobileScreen();
                    break;
                default:
                    break;
            }
            return _screen;
        }
    }


       //  FactoryMethodun 2.KULLANIMI

    abstract class Creator2
    {
        public abstract Screen ScreenFactory();
    }

    class WinScreen : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new WindowsScreen();
        }
    }
    class MobilScreen : Creator2
    {
        public override Screen ScreenFactory()
        {
            return new MobileScreen();
        }
    }
}
