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
            Student s = new Student("Student Names", 21, 7.5);
            FileStream fs = new FileStream(@"..\..\student.dat",FileMode.Create,FileAccess.Write,FileShare.None);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,s);
            fs.Close();
            Console.WriteLine("Worked");
        }
    }
}
