using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1_
{
    internal class Student
    {
        public short Student_No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public short Class_ { get; set; }
        public char Gender { get; set; }

        public Student()
        {

        }

        //overloading
        public Student(short student_no, string name, string surname, short class_, char gender)
        {
            this.Student_No = student_no;
            this.Name = name;
            this.Surname = surname;
            this.Class_ = class_;
            this.Gender = gender;
        }

    }
}
