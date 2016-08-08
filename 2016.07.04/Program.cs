using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016._07._04
{
    class Program
    {
        static void DisplayArray(int[] x)
        {
            Console.WriteLine("Array :>");
            foreach (int elem in x)
            {
                Console.Write("{0,4}", elem);
            }
            Console.WriteLine("\n");
        }
        static void DisplayMatrix(int[,] m, int x, int y)
        {
            Console.WriteLine("Matrix :>");
            for (int i = 0; i < x; ++i)
                for (int j = 0; j < y; ++j)
                    Console.Write("{0,4}", m[i, j]);
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int size = 0;
            Console.WriteLine("Size of the array");
            Console.Write(":>");

            try
            {
                size = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[size];
                //DisplayArray(array);
                Random r = new Random();
                for (int i = 0; i < size; ++i)
                {
                    array[i] = r.Next(1, 10);
                }
                DisplayArray(array);

                //многомерные массивы

                int x = 5;
                int y = 7;
                int[,] matrix = new int[x, y];
                for (int i = 0; i < x; ++i)
                    for (int j = 0; j < y; ++j)
                        matrix[i, j] = r.Next(1, 9);
                DisplayMatrix(matrix, x, y);


                //рваные массивы
                int[][] rip = new int[5][];
                rip[0] = new int[1] { 10 };
                rip[1] = new int[2] { 20, 20 };
                rip[2] = new int[2] { 30, 20 };
                rip[3] = new int[3] { 40, 20, 20 };
                rip[4] = new int[3] { 10, 40, 60 };
                for(int i =0;i<5;++i)
                {
                    foreach (int element in rip[i])
                        Console.Write("{0,4}", element);
                    Console.WriteLine("\n");
                }
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error.Message);
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Exit...");
            }
        }
    }
}
