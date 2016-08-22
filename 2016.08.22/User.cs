using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016._08._22
{
    public class User
    
    {
        string name;
        int age;

        public User(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public string Name
        {
            get { return name; }
            set{ name=value; }
        }
        public int Age
        {
            get { return age; }
            set { age=value;}
        }

        public void Handler()
        {
            Console.WriteLine("User:{0}, age:{1} logged in", name, age);
        }
    }
}
