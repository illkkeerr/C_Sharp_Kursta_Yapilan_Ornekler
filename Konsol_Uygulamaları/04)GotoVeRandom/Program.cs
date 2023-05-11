using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_GotoVeRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hileli sayı seçim
            //Random sayı görmek
            //Hileli sayı seçim
            //Random random = new Random();
            //int randomx = 0;
            //while (randomx <= 4998)
            //{
            //    randomx = random.Next(5000);
            //    if (randomx > 4998)
            //        Console.WriteLine(randomx);
            //}
            #endregion
            #region kullanıcının girdiği aralıklar arasında random değer döndürme
            //kullanıcını girdiği aralıklar arasında random değer döndürme
            //Random random = new Random();
            //int rand;
            //Console.Write("alt limiti giriniz:");
            //int lower_limit = int.Parse(Console.ReadLine());
            //Console.Write("üst limiti giriniz");
            //int upper_limit = Convert.ToInt32(Console.ReadLine());
            //if (upper_limit < lower_limit)
            //{
            //    //Console.WriteLine("üst limit alt limitten küçük olamaz");
            //    rand = random.Next(upper_limit, lower_limit);
            //    Console.WriteLine($"rastgele gelen sayı:{rand}");
            //}
            //else
            //{
            //    rand = random.Next(lower_limit, upper_limit);
            //    Console.WriteLine($"rastgele gelen sayı:{rand}");
            //}
            #endregion
            #region rastgele girilen 10 asyının toplamını veren algoritma
            //    //rastgele girilen 10 asyının toplamını veren algoritma
            //    Random rnd = new Random();
            //    short rnd_num, sum = 0;
            //    byte counter = 0;

            //loop://bu şekilde yazmak problemli if bloğunu içinde olması daha doğru olur.
            //    rnd_num = (short)rnd.Next(11);
            //    Console.WriteLine($"{counter + 1}. sayı={rnd_num}");
            //    sum += rnd_num;
            //    counter++;
            //    if (counter < 10)
            //        goto loop;
            //    Console.WriteLine($"toplam={sum}");
            #endregion
            #region 500 kez zar at ve kaç 6 5 4 3 2 1 olduğunu bul
            //    //500 kez zar at ve kaç 6 5 4 3 2 1 olduğunu bul
            //    Random rnd = new Random();
            //    int counter = 0;
            //    int dice_number = 0;
            //    short one = 0, two = 0, three = 0, four = 0, five = 0, six = 0;
            //loop:
            //    if (counter < 500)
            //    {
            //        dice_number = rnd.Next(1, 7);
            //        switch (dice_number)
            //        {
            //            case 1: one++; break;
            //            case 2: two++; break;
            //            case 3: three++; break;
            //            case 4: four++; break;
            //            case 5: five++; break;
            //            case 6: six++; break;
            //        }
            //        counter++;
            //        goto loop;
            //    }
            //    Console.WriteLine($"{one} tane 1  %{one / 5}\n{two} tane 2  %{two / 5}\n{three} tane 3  %{three / 5}\n" +
            //        $"{four} tane 4  %{four / 5}\n{five} tane 5  %{five / 5}\n{six} tane 6  %{six / 5}\n");
            #endregion
            #region kullanıcının girdiği ifadeyi istediği kadar ekrana yazdıran algoritma
            //    //kullanıcının girdiği ifadeyi istediği kadar ekrana yazdıran algoritma
            //    string text;
            //    int again;
            //    int counter = 0, sum = 0;
            //    Console.Write("ne yazmak istiyorsun:");
            //    text = Console.ReadLine();
            //    Console.Write("kaç defa yazdırmak istiyorsun:");
            //    again = Convert.ToInt32(Console.ReadLine());
            //loop:
            //    if (counter < again)
            //    {
            //        sum += counter + 1;
            //        Console.WriteLine(text);
            //        counter++;
            //        goto loop;
            //    }
            //    Console.WriteLine($"1 ile {again}'a kadar toplam {sum}'dır");
            #endregion
            #region  (Üçgen, kare, dikdörtgen).Daha sonra alan bilgileri girilip alan hesaplanacak.
            ///* Soru: Hesaplamak istediğiniz geometrik şekli seçin. 
            //(Üçgen, kare, dikdörtgen).Daha sonra alan bilgileri girilip alan hesaplanacak.*/
            //string polygon;
            //Console.WriteLine("alanını hesaplamak istediğiniz şeklin adını yazın");
            //Console.Write("üçgen,kare,dikdörtgen?:");
            //polygon = Console.ReadLine();
            //switch (polygon.ToLower())
            //{
            //    case "üçgen":
            //        Console.Write("üçgenin taban uzunluğunu giriniz:");
            //        double side_lenght = Convert.ToDouble(Console.ReadLine());
            //        Console.Write("üçgenin yüksekliğini giriniz:");
            //        double height = Convert.ToDouble(Console.ReadLine());
            //        double area = (side_lenght * height / 2);
            //        Console.WriteLine($"üçgenin alanı={area}");
            //        break;
            //    case "dikdörtgen":
            //        Console.Write("dikdörtgenin ilk kenar uzunluğunu giriniz:");
            //        double side_lenght1 = Convert.ToDouble(Console.ReadLine());
            //        Console.Write("dikdörtgenin ikinci kenar uzunluğunu giriniz:");
            //        double side_lenght2 = Convert.ToDouble(Console.ReadLine());
            //        double area1 = side_lenght1 * side_lenght2;
            //        Console.WriteLine($"dikdörtgenin alanı={area1}");
            //        break;
            //    case "kare":
            //        Console.Write("karenin kenar uzunluğunu giriniz:");
            //        double side_lenght3 = Convert.ToDouble(Console.ReadLine());
            //        double area2 = side_lenght3 * side_lenght3;
            //        Console.WriteLine($"karenin alanı={area2}");
            //        break;
            //    default:
            //        Console.WriteLine("yanlış bir şeyler oldu");
            //        break;
            //}
            #endregion
            #region 10 adet sayı girilecek bu sayıların 5 ile bölünen ve bölünmeyenlerin sayısını ekrana yazdırılacak
            //    //10 adet sayı girilecek bu sayıların 5 ile bölünen ve bölünmeyenlerin sayısını ekrana yazdırılacak
            //    byte counter = 0;
            //    int number, mod5_num = 0;
            //    int other_num = 0;
            //loop:
            //    if (counter < 10)
            //    {
            //        Console.Write("bir sayı gir:");
            //        number = Convert.ToInt32(Console.ReadLine());
            //        if (number % 5 == 0)
            //            mod5_num++;
            //        else
            //            other_num++;
            //        counter++;
            //        goto loop;
            //    }
            //    Console.WriteLine($"5'e bölünen sayı adedi={mod5_num}");
            //    Console.WriteLine($"5'e bölünemeyen sayı adedi={other_num}");
            #endregion
        }
    }
}
