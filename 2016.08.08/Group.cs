using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016._08._08
{
    class Group
    {
        int n;
        Student []students;
        public Group()
        {
            students = null;
        }

        public void addStudent(Student s)
        {
            if (n == 0)
            {
                students = new Student[1];
                students[0] = s;
            }
            else
            {

                Array.Resize(ref students, n + 1);
                students[n] = s;
            }
            n++;
        }
        public override string ToString()
        {
            if(n==0)
            {
                return "No students here";
            }          
            else
            {
                string temp = "";
                foreach(Student item in students)
                    temp += item.ToString() + "\n";
                return temp;
            }
        }
        public Student this[int k]
        {
            get { return students[k]; }
            set{students[k]=value;}
        }
    }
}
