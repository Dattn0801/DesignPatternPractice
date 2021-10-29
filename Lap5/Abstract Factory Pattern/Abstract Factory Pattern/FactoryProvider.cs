using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class FactoryProvider
    {
        public static IAnimalFactory GetAnimalFactory(string factoryType)
        {
            if(factoryType.Contains("wild"))
            {
                return new WildAnimalFactory();
            }
            else if (factoryType.Contains("pet"))
                {
                    return new PetAnimalFactory();
                }
                else
                {
                throw new ArgumentException("You need to fill will or pet");
                }    
        }
    }
}
