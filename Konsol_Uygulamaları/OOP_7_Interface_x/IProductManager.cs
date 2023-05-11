using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7_Interface_x
{
    internal interface IProductManager
    {
        void Add(Product product);
        void Remove(Product product);
        void Remove(int index);
        List<Product> GetAll();
        Product Get(int index);
        Product Get(string name);
    }
}
