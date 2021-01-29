using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_2_AbstractFactoryDP
{

    /*
     Africa, America,... --> Continent
     Herbivor, Carnivor...--> 
     Wildeebeast, Lion, Bison, Wolf
     Animal World
     */


    interface IHerbivor
    {

    }
    interface ICarnivor
    {
        void Eat(IHerbivor her);
    }
    class Wildebeest : IHerbivor
    {

    }
    class Lion : ICarnivor
    {
        public void Eat(IHerbivor her)
        {
            Console.WriteLine(this.GetType().Name + " eats " + her.GetType().Name);
        }
    }
    class Bison : IHerbivor
    {

    }
    class Wolf : ICarnivor
    {
        public void Eat(IHerbivor her)
        {
            Console.WriteLine(this.GetType().Name + " eats " + her.GetType().Name);
        }
    }
    interface IContinentFactory
    {
        IHerbivor CreateHerbivor();
        ICarnivor CreateCarnivor();
    }
    class AfricaFactory : IContinentFactory
    {
        public ICarnivor CreateCarnivor()
        {
            return new Lion();
        }

        public IHerbivor CreateHerbivor()
        {
            return new Wildebeest();
        }
    }

    class AmericaFactory : IContinentFactory
    {
        public ICarnivor CreateCarnivor()
        {
            return new Wolf();
        }

        public IHerbivor CreateHerbivor()
        {
            return new Bison();
        }
    }
    class AnimalWorld
    {
        private IHerbivor herbivor;
        private ICarnivor carnivor;
        public AnimalWorld(IContinentFactory factory)
        {
            herbivor = factory.CreateHerbivor();
            carnivor = factory.CreateCarnivor();
        }

        public void RunFoodChain()
        {
            carnivor.Eat(herbivor);
        }
    }
}
