using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7_Interface_
{
    internal class Product
    {
        private string name;
        public string Name { get => name; set => name = value.ToUpper(); }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public Product()
        {

        }
        public Product(string name, int stock, decimal price)
        {
            this.name = name;
            this.Stock = stock;
            this.Price = price;
        }
    }
}
