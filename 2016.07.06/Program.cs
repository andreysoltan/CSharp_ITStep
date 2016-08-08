using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2016._07._06
{
    class Program
    {
        static void DisplayArray(int[] array)
        {
            Console.WriteLine("Array display\n");
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write("{0,3}", array[i]);
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            const int a = 3;
            const int b = 4;


            int[,] matrix = new int[a, b] {
                {10,20,30,40},
                {15,25,35,45},
                {20,30,40,50}
            };

            for (int i = 0; i < a; ++i)
            {
                for (int j = 0; j < b; ++j)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("_____________________________________________________________");

            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            Console.WriteLine("m={0},n={1}", m, n);
            Console.WriteLine("_____________________________________________________________");

            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            //for (int j = 0; j < 5; ++j)
            //{
            //    Console.Write("{0,3}", array[j]);
            //}

            Console.WriteLine("Array a");
            DisplayArray(array);
            Console.WriteLine("_____________________________________________________________");

            int[] b1 = new int[7];
            Console.WriteLine("Array b");
            DisplayArray(b1);
            Console.WriteLine("_____________________________________________________________");

            Console.WriteLine("Array b");
            array.CopyTo(b1, 1);
            DisplayArray(b1);
            Console.WriteLine("_____________________________________________________________");

            Console.WriteLine("Array b");
            Array.Clear(b1, 1, 6);
            DisplayArray(b1);
            Console.WriteLine("_____________________________________________________________");

            Console.WriteLine("Index of array - x");
            int x = Array.IndexOf(array, 1);
            Console.WriteLine(x);
            Console.WriteLine("_____________________________________________________________");

            Console.WriteLine("Resize of - x");
            Array.Resize(ref array, 10);
            DisplayArray(array);
            Console.WriteLine("_____________________________________________________________");


            const int randSIZE = 15;
            int[] randArr = new int[randSIZE];
            Random r = new Random();
            for (int i = 0; i < randArr.Length; i++)
            {
                randArr[i] = r.Next(1, 99);
            }
            DisplayArray(randArr);
            Console.WriteLine("_____________________________________________________________");

            Console.WriteLine("Sort:");
            Console.WriteLine(" min = {0}\n max = {1}\n sum = {2}\n avr = {3}\n", randArr.Min(), randArr.Max(), randArr.Sum(), randArr.Average());
            Console.WriteLine("_____________________________________________________________");

            string s = "h";
            Console.WriteLine("fist string:" + s);
            string s1 = "hi";
            Console.WriteLine("second string:" + s1);
            Console.WriteLine(s == s1);
            Console.WriteLine(string.Compare(s, s1));//false = -1, true = 0
            Console.WriteLine("_____________________________________________________________");

            string info = "data text; datatext2";
            int infoIndex = info.IndexOf(";");
            Console.WriteLine(infoIndex);
            string data = info.Substring(0, infoIndex);
            string data2 = info.Substring(infoIndex + 2);
            Console.WriteLine(data);
            Console.WriteLine(data2);
            Console.WriteLine("_____________________________________________________________");

            string[] newInfo = info.Split(';');
            foreach (string sss in newInfo)
            {
                Console.WriteLine(sss.Trim());
            }
            Console.WriteLine("_____________________________________________________________");

            string z = "111 xxx 111 xxx";
            Console.WriteLine(z);
            string z2 = z.Replace("111", "222");
            Console.WriteLine(z2);
            Console.WriteLine("_____________________________________________________________");

            ////Rabota s filami



            string path = @"..\..\Data\input.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text1 = sr.ReadToEnd();
            sr.Close();
            fs.Close();

            //Console.WriteLine(text1);

            string text2 = text1.Replace("fuck", "@*!");
            string path2 = @"..\..\Data\output.txt";
            Console.WriteLine(text2);
            FileStream fs2 = new FileStream(path2, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            sw.Write(text2);
            sw.Close();
            fs2.Close();


        }
    }
}
