using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//using System.Delegate;              //базовые классы делегатов
//using System.MulticastDelegate;     

//System.Threading.ThreadStart
//System.Threading.Parametrized ThreadStart
//System.AsyncCallback
//System.EventHandler

namespace _2016._08._15_1
{
    public delegate int IntOperation (int i, int j);


    class Program
    {
        // Организуем ряд методов
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Prz(int x, int y)
        {
            return x * y;
        }

        static int Del(int x, int y)
        {
            return x / y;
        }
        static void Method1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Прошло:\t\t{0}", i);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        static void Method2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Прошло:\t\t\t {0}", i);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        static void Main(string[] args)
        {
            // Сконструируем делегат
            IntOperation op1 = new IntOperation(Sum);

            ThreadStart ts1 = new ThreadStart(Method1);
            ThreadStart ts2 = new ThreadStart(Method2);

            Thread t1 = new Thread (ts1);
            Thread t2 = new Thread (ts2);

            t1.Start();
            t2.Start();

            int result = op1(5, 10);
            Console.WriteLine("Сумма: {0}",  result);

            // Изменим ссылку на метод
            op1 = new IntOperation(Prz);
            result = op1(5, 10);
            Console.WriteLine("Произведение: {0}" , result);
            /*
            for (int i = 60; i > 0; --i)
            {                
                Console.WriteLine("Осталось:"+i);
                Thread.Sleep(1000);
                Console.Clear();
            }*/
        }
    }
}
