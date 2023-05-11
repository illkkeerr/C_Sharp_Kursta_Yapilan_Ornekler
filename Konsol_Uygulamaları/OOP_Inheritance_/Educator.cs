using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_
{
    internal class Educator : Person
    {
        public Educator() : base()
        {

        }

        public Educator(string name, string surname) : base(name, surname)
        {

        }

        public Educator(short id, string name, string surname) : base(id, name, surname)
        {

        }

        public Educator(short id, string name, string surname, EnumGender gender) : base(id, name, surname, gender)
        {

        }

        public void CreateCourse()
        {
            Console.WriteLine("kurs oluşturuldu");
        }
    }
}
