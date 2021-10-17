using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_WinForm
{
    public class Literature : Subject
    {
        public override string DoSomeWork()
        {
            return "I'm doing literature homework";
        }
    }
}
