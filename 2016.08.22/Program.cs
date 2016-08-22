using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016._08._22
{
    public delegate void myDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            Event ev = new Event();
            User u = new User("Test user", 20);
            //sub user to events
            ev.myEvent+=u.Handler;
            ev.onEventOccurred();
        }
    }
}
