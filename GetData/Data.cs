using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetData
{
    //前面的Error，Person，Project是单个类，Data这个类将他们三汇总
    public class Data
    {
        public List<Person> Personlist = new List<Person>();
        
        //数字对应人，
        public Dictionary<int, Person> personProject = new Dictionary<int, Person>();
        public DataTable dt, dt2;
        public Dictionary<int, Error> work = new Dictionary<int, Error>();
        public Data()
        {
            Project p1, p2, p3;
            //定义项目
            p1 = new Project("a", "b", 0);
            p2 = new Project("g", "s", 1);
            p3 = new Project("w", "t", 2);

            //定义项目list
            List<Project> o1 = new List<Project>();
            o1.Add(p1);
            o1.Add(p2);
            List<Project> o2 = new List<Project>();
            o2.Add(p3);

            Personlist.Add(new Person("name_1", o1));
            Personlist.Add(new Person("name_2",o2));
            //人对应的项目
            int index = 0;
            foreach(Person x in Personlist)
            {
                personProject.Add(index, x);
                index++;
            }

            //定义错误
            Error e1 = new Error("a", "b", Convert.ToDateTime("2011-05-26 11:46:21"), "");
            Error e2 = new Error("c", "d", Convert.ToDateTime("2012-05-26 11:46:21"), "");
            //appid 对应错误
            work = new Dictionary<int, Error>();
            work.Add(0, e1);
            work.Add(1, e2);
            work.Add(2, e1);

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("appid"));
            dt.Columns.Add(new DataColumn("name"));
            dt.Columns.Add(new DataColumn("Englisg_name"));
            dt2 = new DataTable();
            dt2.Columns.Add(new DataColumn("appid"));
            dt2.Columns.Add(new DataColumn("name"));
            dt2.Columns.Add(new DataColumn("type"));
            dt2.Columns.Add(new DataColumn("time"));
            dt2.Columns.Add(new DataColumn("reason"));
        }
    }
}
