using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016._08._08
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Student s2 = new Student();
            Student s3 = new Student();

            s.Name = "Fname";
            s.Age = 10;            
            s.Rate = 3.1;


            s2.Name = "Sname"; 
            s2.Age = 11;
            s2.Rate = 2.1;

            s3.Name = "Tname";
            s3.Age = 15;           
            s3.Rate = 5.0;

            /*Console.WriteLine(s.ToString());
            Console.WriteLine(s2.ToString());
            Console.WriteLine(s3.ToString());*/



            Group g = new Group();
            g.addStudent(new Student("FFname",12,5.0));
            g.addStudent(new Student("SSname", 13, 4.1));
            g.addStudent(new Student("TTname", 14, 3.6));
            Console.WriteLine(g);



        }
    }
}
