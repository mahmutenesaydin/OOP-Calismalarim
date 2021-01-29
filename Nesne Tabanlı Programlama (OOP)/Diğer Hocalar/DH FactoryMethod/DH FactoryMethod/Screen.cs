using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH_FactoryMethod
{
    public abstract class Screen
    {
        public abstract void Draw();
    }
    public class WindowsScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Windows Ekranı");
        }
    }
    public class MobileScreen : Screen
    {
        public override void Draw()
        {
            Console.WriteLine("Telefon Ekranı"); 
        }
    }
}
