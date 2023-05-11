using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8_Example
{
    internal class Educator : User
    {
        public Educator() : base()
        {

        }
        public Educator(string name, string surname) : base(name, surname)
        {

        }
        public override List<Course> CourseList()
        {
            return this.Courses;
        }
        public void CreateCourse(Course course)
        {
            this.Courses.Add(course);
            course.Educator = this;

        }
    }
}
