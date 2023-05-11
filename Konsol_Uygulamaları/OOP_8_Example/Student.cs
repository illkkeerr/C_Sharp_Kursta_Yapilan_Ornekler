using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8_Example
{
    internal class Student : User
    {
        public Student() : base()
        {

        }
        public Student(string name, string surname) : base(name, surname)
        {

        }
        public override List<Course> CourseList()
        {
            return this.Courses;
        }
        public void JoinCourse(Course course)
        {
            
            this.Courses.Add(course);
            course.Students.Add(this);

        }
    }
}
