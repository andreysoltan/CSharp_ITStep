﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2016._09._12
{
    [Serializable]
    public class Student
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
                "\nage:{1}" +
                "\nrate:{2}",
                Name, Age, Rate);
        }
    }
}