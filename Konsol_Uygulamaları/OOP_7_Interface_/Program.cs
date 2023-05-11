using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7_Interface_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.Add(new Product("telefon", 5000, 8578.58m));
            productManager.Add(new Product("saat", 285, 439.45m));
            productManager.Add(new Product("araba", 15, 1999999.99m));
            productManager.Add(new Product("bilgisayar", 15, 1999999.99m));
            Console.WriteLine("----ürün ekleme işlemi tamam-----");
            productManager.GetAll().ForEach(z => Console.WriteLine($"{z.Name} {z.Price} {z.Stock}"));
            Console.WriteLine("---Product listesindeki bütün ürünler---");
            var telefone = productManager.Get("telefon");
            Console.WriteLine("telefon class nesnesini product managerdaki listeden alıp yazdırıyoruz");
            Console.WriteLine("------FirstOrDefault() metodu ile------");
            Console.WriteLine($"{telefone.Name} {telefone.Price} {telefone.Stock}");
            Console.WriteLine("----ürün çıkarma işlemi-----");
            productManager.Remove(1);
            productManager.GetAll().ForEach(z => Console.WriteLine($"{z.Name} {z.Price} {z.Stock}"));
            Console.WriteLine("-----saat Products listesinden kaldırıldı------");
            productManager.Add(new Product("saat", 285, 439.45m));
            productManager.GetAll().ForEach(z => Console.WriteLine($"{z.Name} {z.Price} {z.Stock}"));
            Console.WriteLine("----saat class nesnesi tekrar Products listesine eklendi-----");




            Console.ReadLine();



        }
    }
}
