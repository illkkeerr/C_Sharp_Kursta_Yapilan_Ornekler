using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6_Abstract_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            Cat cat = new Cat() { Name = "Minnak", Type = "Van Kedisi", Gender = EnumGender.Female };
            list.Add(cat);
            Dog dog = new Dog() { Name = "Karabaş", Type = "Sivas Kangalı", Gender = EnumGender.Male };
            list.Add(dog);
            list.ForEach(z => Console.WriteLine($"{z.Name} {z.Type} {z.Gender}"));
            cat.Sound();
            dog.Sound();

            Console.ReadLine();




        }
    }
}
