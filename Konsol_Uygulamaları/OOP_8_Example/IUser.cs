using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8_Example
{
    internal interface IUser
    {
        //KursListele Metodu interface
        //User base abstract class
        /*
         ad,soyad,
        abstract KurslarıListele

        Kurs classı
        ad,toplam_sure,haftalık saati,baslangıc_tarihi,bitiş_tarihi(kendi hesaplasın)
        Encapculation ad<3 hata versin
        baslangıc_tarihi<Datetime.Now
        Ogrecileri
        Eğitmeni

        Eğitmen class
        Kurslar listesi
        KursOlustur(Kurs)

        ÖĞrenciler
        Kursları
        KursaKatıl(Kurs)

        Main
        2 eğitmen
        3 öğrenci 
        3 Kurs oluşturulacak

        1 eğitmen-2 kurs

         */


        List<Course> CourseList();
        
          
    }
}
