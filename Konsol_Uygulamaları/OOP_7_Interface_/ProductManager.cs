using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7_Interface_
{
    internal class ProductManager : IProductManager
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public void Add(Product product)
        {
            Products.Add(product);
        }
        public void Remove(int index)
        {
            Products.RemoveAt(index);
        }
        public void Remove(Product product)
        {
            Products.Remove(product);
        }
        public Product Get(string name)
        {
            name = name.ToUpper();
            var product = Products.FirstOrDefault();//p => p.Name == name
            //listedeki first or default ilk haneyi kontrol edip ilgili listeki product class nesnesini döndürür
            return product;
        }

        public List<Product> GetAll()
        {
            return Products;
        }


    }
}
