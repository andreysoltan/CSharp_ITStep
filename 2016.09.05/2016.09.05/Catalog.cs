using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _2016._09._05
{
    class Catalog
    {
        List<Product> list;
        string path;

        public Catalog(string path)
        {
            this.path = path;
            list = new List<Product>();
        }
                
        public void addGood()
        {
            XmlTextReader reader = new XmlTextReader(path);
            reader.WhitespaceHandling = WhitespaceHandling.None;

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.AttributeCount > 0)
                {

                    try
                    {
                        string name = reader.GetAttribute("name");
                        string producer = reader.GetAttribute("producer");
                        int price = Convert.ToInt32(reader.GetAttribute("price"));
                        int quantity = Convert.ToInt32(reader.GetAttribute("quantity"));
                        Product prod = new Product(name, producer, price, quantity);

                        list.Add(prod);
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                   
                }
            }
            
        }

        public void Display()
        {
            foreach(Product p in list)
            {
                p.Display();
            }
        }
    }
}
