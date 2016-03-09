using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerDrawOnline
{
    class StringEventArgs:EventArgs
    {
        public string arg;
        public StringEventArgs(string txt)
        {
            arg = txt;
        }
    }
}
