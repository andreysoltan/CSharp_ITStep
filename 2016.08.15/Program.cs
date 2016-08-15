
using System;
using System.Linq;

namespace _2016._08._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Lorry l = new Lorry( 2000, 8, 100, "Kamaz");
            Console.WriteLine(l.ToString());

            l.Power = 2500;
            l.LiftPower = 200;
            Console.WriteLine(l.ToString());
        }
    }
}