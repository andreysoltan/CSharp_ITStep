using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2016._08._15
{
    public class Lorry : Car
    {
        int power, cylinders, liftPower;
        string mark;

        public int LiftPower
        {
            get { return liftPower; }
            set { liftPower = value; }
        }

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public int Cylinders
        {
            get { return cylinders; }
            set { cylinders = value; }
        }

        public Lorry(int power, int cylinders, int liftPower, string mark)
        {
            this.power = power;
            this.cylinders = cylinders;
            this.liftPower = liftPower;
            this.mark = mark;
        }

        public override string ToString()
        {
            return String.Format("Mark: {0} \nCylinders: {1} \nPower: {2} \nLift Power: {3}\n",
              mark, cylinders, power, liftPower);
        }
    }
}
