 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is demo abstract factory pattern");

            // static not declare new
            IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("wild");
            IDog dog =  animalFactory.GetDog();
            dog.AboutMe();
            ITiger tiger = animalFactory.GetTiger();
            tiger.AboutMe();


            Console.WriteLine("---------------------------------");

            animalFactory = FactoryProvider.GetAnimalFactory("pet");
            dog = animalFactory.GetDog();
            dog.AboutMe();
            tiger = animalFactory.GetTiger();
            tiger.AboutMe();
            Console.ReadKey();
        }   
    }
}
