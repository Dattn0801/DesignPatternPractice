using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Iphone:LightningPhone
    {
        private bool connector;
        public void useLightning()
        {
            connector = true;
            Console.WriteLine("Lightning connected");
        }
        public void recharge()
        {
            if (connector)
            {
                Console.WriteLine("Iphone recharge started");
                Console.WriteLine("Iphone recharge finished");
            }
            else
                Console.WriteLine("Connected lighning first");
        }
    }
}
