using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ahmet";
            person.SurName = "Şenel";
            person.BirtYear = 1868;
            person.AgePrint();

            Console.WriteLine($"kişinin adı:{person.Name} soyadı:{person.SurName} doğum yılı:{person.BirtYear}");



            Console.ReadLine();
        }
    }
}
