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
        }
    }
}
