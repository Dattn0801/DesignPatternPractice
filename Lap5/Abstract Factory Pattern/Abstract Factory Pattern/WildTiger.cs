using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    //Concrete product (WildTiger)
    class WildTiger:ITiger
    {
        public void AboutMe()
        {
            Console.WriteLine("Wild tiger: I like hunting.!!!");
        }
    }
}
