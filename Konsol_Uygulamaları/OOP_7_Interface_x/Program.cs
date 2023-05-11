using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7_Interface_x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product car = new Product("araba", 5, 1882887.256m);
            Product television = new Product("televizyon", 20, 18000.999m);
            ProductManager productManager = new ProductManager();
            productManager.Add(car);
            productManager.Add(television);
            productManager.Add(new Product("kulaklık", 1000, 199.99m));
            productManager.Add(new Product("saat", 200, 1000.00m));
            productManager.Add(new Product("playstaion", 350, 15000.00m));
            Console.WriteLine("---ürün ekleme tamamlandı---");
            productManager.GetAll().ForEach(x => Console.WriteLine($"{x.Name} {x.Stock} adet {x.Price} TL"));
            Console.WriteLine("---ürünler yazdırıldı---");
            productManager.Remove(car);
            productManager.Remove(0);
            Console.WriteLine();
            Console.WriteLine("---araba ve televizyon ürünleri kaldırıldı---");
            productManager.GetAll().ForEach(x => Console.WriteLine($"{x.Name} {x.Stock} adet {x.Price} TL"));
            Console.WriteLine("---ürünler yazdırıldı---");
            Console.WriteLine();
            var val = productManager.Get("kulaklık");
            Console.WriteLine($"{val.Name}");
            Console.WriteLine("---oluşturulan get metoduyla kulaklık ismi çağrıldı---");
            val = productManager.Get(1);
            Console.WriteLine($"{val.Name}");
            Console.WriteLine("---oluşturulan get metodunun overload metodu ile saat ismi çağrıldı---");


            Console.ReadLine();


        }
    }
}
