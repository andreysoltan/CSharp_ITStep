using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2016._09._05
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader(@"../../Data/data1.xml");
            reader.WhitespaceHandling = WhitespaceHandling.None;

            while (reader.Read())
            {
                XmlNodeType type = reader.NodeType;
                string name = reader.Name;
                string value = reader.Value;
                int q = reader.AttributeCount;

                //Console.WriteLine("id:{0}\t\ttitle={1}\t\t",reader.Name, reader.Value);

                if (reader.NodeType==XmlNodeType.Element && reader.AttributeCount > 0)
                {
                    Console.WriteLine(reader.GetAttribute("id"));
                    Console.WriteLine(reader.GetAttribute("title"));
                    Console.WriteLine(reader.GetAttribute(" "));
                }
            
            }

            reader.Close();


        }
    }
}
