using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype concretePrototype  = new ConcretePrototype();
            concretePrototype.age = 10;
            ConcretePrototype cloneItem1 = (ConcretePrototype)concretePrototype.Clone();
            Console.WriteLine("Do tuoi cua ban la "+ cloneItem1.age);
            concretePrototype.age = 15;
                       
            Console.WriteLine("Do tuoi cua conretePrototype la "+ concretePrototype.age);
            Console.WriteLine("Do tuoi cua cloneItem1 la " + cloneItem1.age);
            Console.ReadKey();

        }
    }
}
