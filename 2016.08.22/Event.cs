using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016._08._22
{
    class Event
    {
        public event myDelegate myEvent;
        public void onEventOccurred()
        {
            myEvent();
        }
    }
}
