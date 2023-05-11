using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Student:Person
    {
        public Student(int id, string name, string surname) : base(id, name, surname)
        {
        }
        public Student() : base()
        {

        }
        public void KursaKatıl()
        {
            Console.WriteLine("Kursa Katıldı");
        }
    }
}
