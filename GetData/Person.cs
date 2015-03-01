using System.Collections.Generic;

namespace GetData
{
    public class Person
    {
        public string name;
        public List<Project> Projects = new List<Project>();
        public Person(string tpname,List<Project> h)
        {
            name = tpname;
            Projects = h;
        }
    }
}
