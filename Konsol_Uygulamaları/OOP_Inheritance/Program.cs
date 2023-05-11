using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Educator ibrahim = new Educator(1,"ibrahim","kaya");
            ibrahim.Gender = EnumGender.Male;
            ibrahim.KursOlustur();
            Student ilker = new Student(1,"ilker","şenel");
            ilker.KursaKatıl();
            Console.Read();

            List<Person> employees= new List<Person>();
            employees.Add(ilker);
            employees.Add(ibrahim);


        }
    }
}
