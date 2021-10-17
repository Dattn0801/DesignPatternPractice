using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ConcreteSubject:Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("I am processing your request");
        }
    }
}
