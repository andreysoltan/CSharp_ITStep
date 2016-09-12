using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _2016._09._12
{
    [Serializable]
    class Group 
    {
        string name;
        List<Student> students;
        
        public Group(string name)
        {
            this.name = name;
            students = new List<Student>();
        }

        public void addStudent(Student s)
        {
            students.Add(s);
        }

        public void addStudentInfo(Student[] goods)
        {
            foreach (Student s in goods)
            {
                this.students.Add(s);
            }
        }

        public void DisplayStudents()
        {
            if (students.Count != 0)
            {
                foreach (Student s in students)
                    Console.WriteLine(s.ToString());
            }
            else
                Console.WriteLine("Student group is empty!");
        }

        public static void StudentsToFile(string path, Group g)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, g);

            fs.Close();
        }

        public static Group StudentsFromFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            BinaryFormatter formatter = new BinaryFormatter();
            Group g = (Group)formatter.Deserialize(fs);

            fs.Close();

            return g;
        }
    }
}