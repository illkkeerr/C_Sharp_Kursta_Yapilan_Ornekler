using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //User base abstract class
            /*ad,soyad,
             * kursları listele
             * abstract kursları listele
             */
            /*kurs classı
             * ad,toplam_sure,haftalık,baslangıc,saati,bitiş tarihi(kendi hesaplasın);
             * Encapsullation ad>3 ten büyük olsun
             * baslangıc_tarihi<datetime.now
             * ogrencileri
             * Educator
             * 
             * eğitmen claas
             * kurslar listesi
             * kurs oluştur(kurs)
             * öğrenciler
             * Kursları
             * KursaKatıl(kurs)
             * 
             * main
             * 2 eğitmen 3 öğrenci 2 kurs oluşturulacak; 
             * 1 eğitmen 2 kurs açıcak;
             * 
             */
            Course erp = new Course("erp-205", 400, 40, DateTime.Now);//kurs oluşturma
            Course yazılım = new Course("yazılım-201", 600, 40, DateTime.Now.AddDays(1));
            Course sql = new Course("sql-204", 300, 40, DateTime.Now);//kurs oluşturma

            Educator ibrahim = new Educator("ibrahim", "kaya");
            Educator Şamil = new Educator("şamil", "hoca");

            Student furkan = new Student("furkan", "ertantu");
            Student mehmet = new Student("mehmet", "bakmaz");

            ibrahim.CreateCourse(erp);
            ibrahim.CreateCourse(yazılım);
            Şamil.CreateCourse(sql);

            furkan.JoinCourse(erp);
            furkan.JoinCourse(yazılım);
            mehmet.JoinCourse(sql);

            Console.WriteLine("ibrahim hocanın verdiği kurslar");
            ibrahim.CourseList().ForEach(e => Console.WriteLine($"{e.Name} {e.Educator.Name} {e.Educator.Surname} {e.EndDate}"));

            Console.WriteLine("furkanın katıldığı kurslar");
            furkan.CourseList().ForEach(Course => Console.WriteLine($"{Course.Name} {Course.Educator.Name} {Course.Educator.Surname} "));
            Console.ReadLine();

        }
    }
}
