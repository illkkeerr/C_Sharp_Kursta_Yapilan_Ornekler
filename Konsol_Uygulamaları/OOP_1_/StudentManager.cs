using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1_
{
    internal static class StudentManager
    {
        public static List<Student> Students { get; set; } = new List<Student>();

        static StudentManager()
        {
            //Değer atama yöntemleri
            //1.yöntem
            Student ogr1 = new Student();
            ogr1.Student_No = 2;
            ogr1.Name = "ibrahim";
            ogr1.Surname = "kaya";
            ogr1.Class_ = 205;
            ogr1.Gender = 'E';
            //ogr1.Info();
            //2.yöntem
            Student ogr2 = new Student()
            {//new Student()
                Student_No = 3,
                Name = "mehmet",
                Surname = "çelik",
                Class_ = 205,
                Gender = 'E'
            };
            //ogr2.Info();


            //3.yöntem
            Student ogr3 = new Student(4, "sercan", "yöndem", 205, 'E');

            Students = new List<Student>()
            {
                new Student(1,"ilker","şenel",12,'E') ,
                ogr1 ,
                ogr2 ,
                ogr3,
                new Student(5,"ahmet","şenel",11,'E'),
                new Student(6,"şevval","şenel",10,'E')
            };
        }

        public static void Add(Student student)
        {
            Students.Add(student);
        }

        public static void Remove(Student student)
        {
            Students.Remove(student);
        }
        public static void Remove(int i)
        {
            Students.RemoveAt(i);
        }
        public static void Show()
        {
            Students.ForEach(x => Console.WriteLine($"{x.Student_No} {x.Name} {x.Surname} {x.Class_} {x.Gender}"));
        }

        public static void Show(int i)
        {

            Console.WriteLine($"{Students[i].Student_No} {Students[i].Name} {Students[i].Surname}" +
                $" {Students[i].Class_} {Students[i].Gender}");
        }


    }
}
