using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _2016._09._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Student Name", 21, 7.5);
            FileStream fs = new FileStream(@"..\..\student.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, s);
            fs.Close();
            Console.WriteLine("Worked");

            FileStream fs2 = new FileStream(@"..\..\student.dat", FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryFormatter bf2 = new BinaryFormatter();
            Student s2 = (Student)bf2.Deserialize(fs2);
            fs2.Close();
            Console.WriteLine(s2.ToString());

        }
    }
}
