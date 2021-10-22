using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Android android = new Android();
            Iphone iphone = new Iphone();
            Console.WriteLine("Recharge android with MicroUsb");
            rechargeMicroUsbPhone(android);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Recharge iphone with Lightning");
            rechargeLightningPhonne(iphone);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Recharge iphone with MicroUsb");
            rechargeMicroUsbPhone(new LightningToMicroUsbPhone(iphone));
            Console.ReadKey();
        }
        static void rechargeMicroUsbPhone(MicroUsbPhone phone)
        {
            phone.useMicroUsb();
            phone.recharge();
        }
        static void rechargeLightningPhonne(LightningPhone phone)
        {
            phone.useLightning();
            phone.recharge();
        }
    }
}
