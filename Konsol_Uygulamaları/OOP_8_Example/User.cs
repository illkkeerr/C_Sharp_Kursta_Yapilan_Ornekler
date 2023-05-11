using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8_Example
{
    internal abstract class User : IUser//abstract
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Course> Courses { get; set; }



        public User()
        {
            Courses = new List<Course>();
        }

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Courses = new List<Course>();
        }

        public abstract List<Course> CourseList();
    }
}
