using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class PetTiger:ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("Pet Tiger:I like being at the circus");
        }
    }
}
