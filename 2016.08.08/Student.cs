using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016._08._08
{
    class Student
    {
        string name;
        int age;
        double rate;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public override string ToString()
        {
            return String.Format("Name: {0} \nAge: {1} \nRate: {2} \n", name, age, rate);
        }

        public Student()
        {
            name = "";
            age = 0;
            rate = 0;
        }
        public Student(string name, int age, double rate)
        {
            this.name = name;
            this.age = age;
            this.rate = rate;
        }
    }
}
