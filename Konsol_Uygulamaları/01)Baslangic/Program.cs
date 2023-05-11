using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baslangic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string ad girme
            //Console.Write("adınızı giriniz:");
            //string ad = Console.ReadLine();
            //Console.WriteLine($"Adınız:{ad}");
            #endregion
            #region bilinçsiz tür dönüşümü ve object değişkeni
            //// bilinçsiz tür dönüşümü
            //byte a = 5;
            //byte b = 6;
            //sbyte c = 4;

            //int d = a + b + c;

            //char f = 'k';
            //string e = "deneme";

            //object g = e + f + d + e + c;
            //Console.WriteLine(g);
            #endregion
            #region kullanıcının girdiği iki sayının toplamı
            //Console.Write("bir sayi giriniz:");
            //int a1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("bir sayi giriniz:");
            //int b1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(a1 + b1);
            #endregion
            #region karenin alanı ve kenar uzunluğu
            //    double side_lenght;
            //    double area, environment;
            //square:
            //    Console.Write("karenin kenar uzunluğunu gir:");
            //    side_lenght = double.Parse(Console.ReadLine());
            //    area = Math.Pow(side_lenght, 2);
            //    environment = 4 * side_lenght;
            //    Console.WriteLine($"alan={area} çevre={environment}");
            //    goto square;
            #endregion
            #region d=b2 - 4 * a * c kullanıcıdan değerleri alıp bilgisayar ekranında sonucu yazdırma
            //// d = b2 - 4 * a * c kullanıcıdan değerleri alıp bilgisayar ekranında sonucu yazdır.
            // int a, b, c, d;
            // Console.Write("a değerini gir:");
            // a = Convert.ToInt32(Console.ReadLine());
            // Console.Write("b değerini gir:");
            // b = Convert.ToInt32(Console.ReadLine());
            // Console.Write("c değerini gir:");
            // c = Convert.ToInt32(Console.ReadLine());
            // d = b * b - 4 * a * c;
            // Console.WriteLine($"d nin değeri:{d}");
            #endregion
            #region ad soyad uygulaması
            //Console.WriteLine("lütfen adınızı giriniz:");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Lütfen soyadınızı giriniz:");
            //string soyad = Console.ReadLine();
            //Console.WriteLine($"kullanıcının ad ve soyadı:{ad} {soyad} ");
            #endregion
            #region ad soyad yaş takım burcu
            //// ad soyad yaş takım burcu
            // string name, surname, my_team, my_horoscope, homeland;
            // byte age;
            // Console.Write("adın ne:");
            // name = Console.ReadLine();
            // Console.Write("soyadın ne:");
            // surname = Console.ReadLine();
            // Console.Write("yaşın ne:");
            // age = byte.Parse(Console.ReadLine());
            // Console.Write("takımın ne:");
            // my_team = Console.ReadLine();
            // Console.Write("burcun ne:");
            // my_horoscope = Console.ReadLine();
            // Console.Write("memleket ne:");
            // homeland = Console.ReadLine();
            // Console.WriteLine($"{name} {surname} {age} {my_team} {my_horoscope}  {homeland}");
            #endregion
            #region üçgenin alanını hesaplama
            //    //üçgenin alanın hesaplama
            //    // side*height/2
            //    double side_length = 0, height = 0;
            //    double triangle_area;
            //try_:
            //    try
            //    {
            //        Console.Write("üçgenin kenar uzunluğunu giriniz:");
            //        side_length = double.Parse(Console.ReadLine());
            //        Console.Write("üçgenin yüksekliğini giriniz:");
            //        height = Convert.ToDouble(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("yanlış değer giridiniz tekrar deneyin");
            //        goto try_;
            //    }
            //    triangle_area = side_length * height / 2;
            //    Console.WriteLine($"üçgenin alanı={triangle_area}");
            //    //breakpointten sonra f10 ile adım adım devam edilebilir.
            //    if (triangle_area > 50)
            //    {
            //        Console.WriteLine("üçgenin alanı 50 den büyüktür");
            //    }
            #endregion
            Console.ReadLine();
        }
    }
}
