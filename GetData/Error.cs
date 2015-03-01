using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetData
{
    public class Error
    {
        public string name;
        public string type;
        public DateTime time;
        public string reason;
        public Error(string n, string t, DateTime t2, string r)
        {
            name = n;
            type = t;
            time = t2;
            reason = r;
        }
    }
}
