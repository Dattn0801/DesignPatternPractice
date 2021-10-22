using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Android:MicroUsbPhone
    {
        private bool connector;
        public void useMicroUsb()
        {
            connector = true;
            Console.WriteLine("Microusb connected");
        }
        public void recharge()
        {
            if (connector)
            {
                Console.WriteLine("Android recharge started");
                Console.WriteLine("Android recharge finished");
            }
            else
                Console.WriteLine("Connected microUsb first");
        }
    }
}
