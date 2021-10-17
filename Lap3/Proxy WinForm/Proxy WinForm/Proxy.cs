using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_WinForm
{
    public class Proxy : Subject
    {
        Subject subject;
        public Proxy()
        {
            subject = null;
        }
        public Proxy(Subject subject)
        {
            this.subject = subject;
        }
        public override string DoSomeWork()
        {
            string t = "Hello";
            //Lazy
            if(subject == null)
            {
                subject = new Math();
            }
            return t + "\n" + subject.DoSomeWork() + "\n";
        }

    }
}
