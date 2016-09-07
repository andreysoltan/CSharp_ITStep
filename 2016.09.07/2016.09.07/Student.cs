using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _2016._09._07
{
    [Serializable]
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Rate { get; set; }
        public Student(string name, int age, double rate)
        {
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
        public override string ToString()
        {
            return String.Format(
                "name:{0}" +
                "age:{1}" +
                "rate:{2}" +
                Name, Age, Rate);
        }
    }
}
