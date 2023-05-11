using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7_Interface_x
{
    internal class ProductManager : IProductManager
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public void Add(Product product)
        {
            this.Products.Add(product);
        }

        public Product Get(int index)
        {
            return this.Products[index];
        }

        public Product Get(string name)
        {
            name = name.ToUpper();
            return Products.FirstOrDefault(z => z.Name == name);
        }

        public List<Product> GetAll()
        {
            return Products;
        }

        public void Remove(Product product)
        {
            Products.Remove(product);
        }

        public void Remove(int index)
        {
            Products.RemoveAt(index);
        }
    }
}
