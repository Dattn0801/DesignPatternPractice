using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class LightningToMicroUsbPhone:MicroUsbPhone
    {
        public readonly LightningPhone lightningPhone;
        public LightningToMicroUsbPhone(LightningPhone lightningPhone)
        {
            this.lightningPhone = lightningPhone;
        }
        public void useMicroUsb()
        {
            Console.WriteLine("MicroUsb connected");
            lightningPhone.useLightning();
        }
        public void recharge()
        {
            lightningPhone.recharge();
        }
    }
}
