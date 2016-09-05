using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016._09._05
{
    class Product
    {
        string name, producer;
        double price;
        int quantity;
        public Product(string n, string prod, double p, int q)
        {
            this.name = n;
            this.producer = prod;
            this.price = p;
            this.quantity = q;
        }
        public void Display()
        {
            Console.WriteLine("producer:{1},price:{2},quantity:{3}",
                name, producer, price, quantity);
        }
    }
}
