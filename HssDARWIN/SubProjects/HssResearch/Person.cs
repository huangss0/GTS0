using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssDARWIN.SubProjects.HssResearch
{
    public class Person
    {
        public string name = "hss";
        private string ID = "0";
        public Person friends = null;

        public Person() { }

        public Person(string name)
        {
            this.name = name;
            this.friends = new Person("yh");
        }

        public int Index
        {
            get
            {
                int res = -1;
                if (int.TryParse(this.ID, out res)) return res;
                else return -2;
            }
        }

        public void Show()
        {
            Console.WriteLine(this.name);
        }
    }
}
