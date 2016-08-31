using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2016._08._31_1
{
    class Program
    {
        enum Menu
        {
            EXIT,
            DISPLAY_GOODS,
            ADD_PRODUCT,
            EDIT_PRODUCT_PRICE,
            EDIT_PRODUCT_QUANTITY,
            DELETE_PRODUCT,
            SEARCH_BY_CATEGORY,
            SEARCH_BY_TITLE,
            SEARCH_BY_PRICE
        }
        class DialogManager
        {
            Menu switcher;

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
                Console.WriteLine("<{0}> - exit", Menu.EXIT);
                Console.WriteLine("<{0}> - display goods", Menu.DISPLAY_GOODS);
                Console.WriteLine("<{0}> - add product", Menu.ADD_PRODUCT);
                Console.WriteLine("<{0}> - edit product price", Menu.EDIT_PRODUCT_PRICE);
                Console.WriteLine("<{0}> - edit product quantity", Menu.EDIT_PRODUCT_QUANTITY);
                Console.WriteLine("<{0}> - delete product", Menu.DELETE_PRODUCT);
                Console.WriteLine("<{0}> - search by category", Menu.SEARCH_BY_CATEGORY);
                Console.WriteLine("<{0}> - search by title", Menu.SEARCH_BY_TITLE);
                Console.WriteLine("<{0}> - search by price", Menu.SEARCH_BY_PRICE);

                try
                {
                    switcher = (Menu)Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("[Error]: {0}", error.Message);
                    Console.ResetColor();
                }

                if (switcher == Menu.EXIT)
                {
                    return false;
                }
                return true;
            }            
        }
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Data/data1.xml");

            XmlNode root = doc.DocumentElement;

            /*
            //show data
            XmlNodeList nodes = doc.GetElementsByTagName("item");

            foreach (XmlNode n in nodes)
            {
                // look through names
                //Console.WriteLine("{0}", n.Name);
                XmlAttributeCollection attribute = n.Attributes;
                foreach (XmlNode a in attribute)
                {
                    Console.Write("{0} ", a.Value);
                }
                Console.WriteLine();
            }*/
        }
    }
}