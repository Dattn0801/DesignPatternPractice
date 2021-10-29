using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class WildDog:IDog
    {
        public void AboutMe()
        {
            Console.WriteLine("Wild dog:I like freedom , awwww");
        }
    }
}
