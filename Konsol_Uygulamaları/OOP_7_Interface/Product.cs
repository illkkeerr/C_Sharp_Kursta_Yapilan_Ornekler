using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7_Interface
{
    internal class Product
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Product()
        {

        }
        public Product(string name,int stock,decimal price)
        {
            Name= name;
            Stock= stock;
            Price= price;
        }
    }
}
