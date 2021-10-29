using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class PetDog : IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Pet Dog: I like stay at home");
        }
    }
}
