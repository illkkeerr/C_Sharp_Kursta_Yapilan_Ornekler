using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Student classım
          OgrNo,Name,Surname,Sınıf,Cinsiyeti
          BilgileriYazdır()
           */
            StudentManager.Show();
            Console.WriteLine("------------");
            Console.WriteLine("eklemeli");
            StudentManager.Add(new Student(7, "recep", "akçam", 4, 'E'));
            StudentManager.Show();
            Console.WriteLine("------------");
            Console.WriteLine("silmeli");
            StudentManager.Remove(0);
            StudentManager.Show();
            Console.WriteLine("------------");
            Console.WriteLine("indeks göstermeli");
            StudentManager.Show(0);



            Console.ReadLine();
        }
    }
}
