using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Abstract class ortak özelliğe sahip nesnelerin ortak özelliğidir(Ezilebilir Class);

namespace Abstract_Calisma_2__DH_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi cat = new Kedi();
            cat.Voice();
            Kopek dog = new Kopek();
            dog.Voice();

            Console.ReadLine();
        }
    }
    abstract public class Ses //Ortak özellikler ezilecek
    {
        public abstract void Voice();
    }
    public class Kedi : Ses
    {
        public override void Voice()
        {//Ezilen metod
            Console.WriteLine("Miyav");
        }
    }
    public class Kopek : Ses
    {//Ezilen metod
        public override void Voice()
        {
            Console.WriteLine("Hav");
        }
    }
}
