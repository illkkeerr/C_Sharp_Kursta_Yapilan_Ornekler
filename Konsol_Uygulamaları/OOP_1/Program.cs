using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class
            /*
             1-property 
             2-Metotlar
            3-Conctuctor
            Nesne
            4-Encapculation
            5-Static
            6-Inheritance(Kalıtım)
            7-Abstaraction(Sanallaştırma-override(polimorfism))
            8-Interface(Arayüz)

             */

            /*
             Student classım
            OgrNo,Name,Surname,Sınıf,Cinsiyeti
            BilgileriYazdır()
             */



            //students.ForEach(student => student.Info());
            //foreach (var student in students)
            //{
            //    student.Info();
            //}


            
            StudentManager.Add(new Student(12, "a", "b", 2, 's'));

            StudentManager.Remove(3);
            StudentManager.students.ForEach(i => Console.WriteLine($"no : {i.No} ad: {i.Name} soyad : {i.Surname} sınıf :  {i.Class_No} cinsiyet:{i.Gender}"));
            Console.ReadLine();
        }
    }
}
