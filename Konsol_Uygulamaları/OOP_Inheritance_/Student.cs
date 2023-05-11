using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_
{
    internal class Student : Person
    {
        public Student() : base()
        {

        }

        public Student(string name, string surname) : base(name, surname)
        {
            
        }

        public Student(short id, string name, string surname) : base(id, name, surname)
        {

        }

        public Student(short id, string name, string surname, EnumGender gender) : base(id, name, surname, gender)
        {

        }

        public void JoinCourse()
        {
            Console.WriteLine("kursa katıldı");
        }

      
    }
}
