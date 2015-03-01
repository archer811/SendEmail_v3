using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetData
{
    public class Project
    {
        public string name;
        public string engName;
        public int appid;
        public Project(string n, string e, int a)
        {
            name = n;
            engName = e;
            appid = a;
        }
    }
}
