using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2016._09._12
{
    public class Manager : Test
    {
        int definedTest;
        Menu switcher;

        void Actions()
        {
            switch (switcher)
            {
                case Menu.START:
                    break;
                case Menu.DISPLAY:
                    break;
                case Menu.OPTION:
                    break;
                case Menu.EXIT:
                    break;
            }
        }

        public void Start()
        {
            Console.WriteLine("Welcome!");
        }
        public void Exit()
        {
            Console.WriteLine("Exiting...");
        }

        public bool GenerelMenu()
        {
            Console.WriteLine("1: <{0}>", Menu.START);
            Console.WriteLine("2: <{0}>", Menu.DISPLAY);
            Console.WriteLine("3: <{0}>", Menu.OPTION);
            Console.WriteLine("4: <{0}>", Menu.EXIT);

            try
            {
                switcher = (Menu)Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Error]: {0}", error.Message);
                Console.ResetColor();
                return false;
            }

            if (switcher == Menu.EXIT)
            {
                return false;
            }
            return true;
        }
    }
}