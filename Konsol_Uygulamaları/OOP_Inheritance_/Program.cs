using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Educator ibrahim = new Educator(1, "ibrahim", "kaya");
            ibrahim.Gender = EnumGender.Male;
            ibrahim.CreateCourse();

            Student ilker = new Student(2, "ilker", "şenel");
            ibrahim.Gender = EnumGender.Male;
            ilker.JoinCourse();

            List<Person> list = new List<Person>();
            list.Add(ibrahim);
            list.Add(ilker);


            list.ForEach(i => Console.WriteLine(i));
            list.ForEach(i => Console.WriteLine(i.Id + " " + i.Name + " " + i.Surname + " " + i.Gender));


            Console.ReadLine();



        }
    }
}
