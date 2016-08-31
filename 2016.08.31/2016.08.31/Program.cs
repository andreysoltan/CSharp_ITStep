using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2016._08._31
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Data/data1.xml");

            XmlNode root = doc.DocumentElement;
            //show data
            XmlNodeList nodes = doc.GetElementsByTagName("student");
            
            foreach(XmlNode n in nodes)
            {
                // look through names
                //Console.WriteLine("{0}", n.Name);
                XmlAttributeCollection attribute = n.Attributes;
                foreach(XmlNode a in attribute)
                {
                    Console.Write("{0} ", a.Value);
                }
                Console.WriteLine();
            }

            //adding data
            /*
            XmlElement s = doc.CreateElement("student");

            XmlAttribute id = doc.CreateAttribute("id");
            XmlAttribute fname = doc.CreateAttribute("fname");
            XmlAttribute lname = doc.CreateAttribute("lname");
            XmlAttribute rate = doc.CreateAttribute("rate");
            XmlAttribute age = doc.CreateAttribute("age");

            Console.WriteLine("\n>Enter data:");            

            Console.Write("id:");
            string aid = Console.ReadLine();
            id.Value = aid;

            Console.Write("fname:");
            string afname = Console.ReadLine();
            fname.Value = afname;

            Console.Write("lname:");
            string alname = Console.ReadLine();
            lname.Value = alname;

            Console.Write("age:");
            string aage = Console.ReadLine();
            age.Value = aage;

            Console.Write("rate:");
            string arate = Console.ReadLine();
            rate.Value = arate;            

            s.Attributes.Append(id);
            s.Attributes.Append(fname);
            s.Attributes.Append(lname);          
            s.Attributes.Append(age);
            s.Attributes.Append(rate);

            root.AppendChild(s);
            if (true)
            {
                doc.Save(@"../../Data/data1.xml");

                Console.WriteLine("OK");
            }*/

            //delete
            /*
            XmlNode x = root.ChildNodes[2];
            root.RemoveChild(x);

            doc.Save(@"../../Data/data1.xml");
            Console.WriteLine("Deleted");
            */

            //search by lname and raiting modifier
            Console.WriteLine("Enter surname you want to find:");
            string last_name_search = Console.ReadLine();
            int k = 0;
            foreach (XmlNode n in nodes)
            {
                if (n.Attributes[2].Value == last_name_search)
                {
                    Console.WriteLine("There is a match to your "+last_name_search);
                    break;
                }
               ++k;
            }

            Console.Write("Enter raito: ");
            string r = Console.ReadLine();
            nodes[k].Attributes[4].Value = r;
            doc.Save(@"../../Data/data1.xml");
            Console.WriteLine("Modified.");
        }
    }
}
