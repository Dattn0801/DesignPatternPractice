using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            sourdough.Make();
            Console.WriteLine("------------------------------");
            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();
            Console.WriteLine("------------------------------");
            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();
            Console.ReadKey();
        }
    }
}
