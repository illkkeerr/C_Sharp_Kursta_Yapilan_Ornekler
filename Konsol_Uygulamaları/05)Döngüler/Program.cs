using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region kullanıcıdan girilen mesajı 5 veya istediği kere yazdıran program
            //string message;
            //int piece;
            //Console.Write("ne yazdırmak istiyosunuz:");
            //message = Console.ReadLine();
            //Console.Write("kaç adet yazdırmak istiyorsunuz:");
            //piece = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < piece; i++)
            //{
            //    //Console.WriteLine(i+".merhaba");
            //    Console.WriteLine(message);
            //}
            #endregion
            #region sonsuz döngü oluşturma
            //for (int i=0; ;i++)
            //{
            //    Console.WriteLine(i+" infinite loop");
            //}
            #endregion
            #region for ile char değer döndürme
            //for (char i = 'A'; i <= 'Z'; i++)
            //{
            //    Console.Write(i+" ");
            //}
            #endregion
            #region 1 ile 100 arasında çift sayıları yazdıran program
            ////bir ile 100 arasında çift sayıları yazdıran program
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}
            ////kullanıcıdan girilen aralıklar arasındaki çift sayıları yazdıran program
            //int interval1, interval2;
            //int joker_num;
            //int sum = 0, counter = 0;
            //Console.Write("birinci sayıyı gir:");
            //interval1 = int.Parse(Console.ReadLine());
            //Console.Write("ikinci sayıyı gir:");
            //interval2 = int.Parse(Console.ReadLine());
            //if (interval1 > interval2)
            //{
            //    joker_num = interval2;
            //    interval2 = interval1;
            //    interval1 = joker_num;
            //}
            //for (int i = interval1; i <= interval2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        //Console.Write(i + " ");
            //        sum += i;
            //        counter++;
            //    }
            //}
            //Console.WriteLine($"\n{interval1}-{interval2} arasındaki {counter} çift sayının" +
            //    $" toplamının ortalaması={sum / counter}");
            //farklı bir çözüm mantığı
            //int sayi1 = 0, sayi2 = 0, Toplam = 0, sayac = 0;

            //Console.WriteLine("İlk sayı küçük olan");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayı büyük olan");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //for (; sayi1 < sayi2; sayi1++)
            //{
            //    if (sayi1 % 2 == 0)
            //    {
            //        Toplam += sayi1;
            //        sayac = sayac + 1;
            //    }
            //}
            //Console.WriteLine("******************");
            //Console.WriteLine(Toplam / sayac);

            #endregion
            #region 1'den 10 a kadar toplayan sayıları toplayan program
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("1'den 10'a sayıların toplamı=" + sum);
            #endregion
            #region İstenilen aralıkta girilen sayıların son rakamı
            ////:  İstenilen aralıkta girilen sayıların son rakamı
            ////5 ve 5 ten büyük olanların ortalamasını alan program.
            //int interval1, interval2;
            //int joker_num;
            //int sum = 0, counter = 0;
            //Console.Write("birinci sayıyı gir:");
            //interval1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("ikinci sayıyı gir:");
            //interval2 = Convert.ToInt32(Console.ReadLine());
            //if (interval1 > interval2)
            //{                         //interval1=100 interval2=50
            //    joker_num = interval2;//joker=50 interval2=50
            //    interval2 = interval1;//interval2=100 interval1=100
            //    interval1 = joker_num;//interval1=50 interval2=100
            //}
            //if (interval1 < 5)
            //    interval1 = 5;

            //for (int i = interval1; i <= interval2; i++)
            //{
            //    if (i % 10 >= 5)//if (sayi1 % 10 == 5 && sayi1>5)
            //    {
            //        Console.Write(i + " ");
            //        sum = sum + i;
            //        counter++;
            //    }
            //}
            //if (counter != 0)
            //    Console.WriteLine($"toplam={sum} adet={counter} ortalama={sum / counter}");
            //else
            //    Console.WriteLine("5 ten küçük sayılar girme");
            #endregion
            #region kullanıcının  girdiği 10 sayıdan en büyük ve en küçüğü bulan sayı
            //int num1, num2;
            //int largest_number, smallest_number;
            //Console.Write("bir sayı girin:");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //largest_number = num1;
            //smallest_number = num1;

            //for (int i = 0; i < 9; i++)
            //{
            //    Console.Write("bir sayı girin:");
            //    num2 = Convert.ToInt32(Console.ReadLine());

            //    if (num2 > largest_number)
            //    {
            //        largest_number = num2;
            //    }
            //    if (num2 < smallest_number)
            //    {
            //        smallest_number = num2;
            //    }
            //}
            //Console.WriteLine($"en büyük sayı={largest_number} en küçük sayı={smallest_number}");
            #endregion
            #region tek sayıların karesinin toplamı çift sayıların küpü toplamı
            //int number_1, number_2;
            //int joker;
            //Console.Write("bir sayı gir:");
            //number_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("bir sayı gir:");
            //number_2 = Convert.ToInt32(Console.ReadLine());

            //int even_pieces = 0, odd_pieces = 0;
            //int even_square = 0, odd_cube = 0;

            //if (number_1 > number_2)
            //{
            //    joker = number_2;
            //    number_2 = number_1;
            //    number_1 = joker;
            //}
            //for (int i = number_1; i <= number_2; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        even_pieces++;
            //        even_square += i * i;
            //    }
            //    else
            //    {
            //        odd_pieces++;
            //        odd_cube += i * i * i;
            //    }
            //}
            //Console.WriteLine($"çift adedi:{even_pieces} çiftlerin karesi toplam:{even_square}\n" +
            //    $"tek adedi:{odd_pieces} teklerin küpü toplam:{odd_cube}");
            #endregion
            #region random 1-10 arası sayı üretelim 1000 sayı üretelim hangi sayıdan kaç tane ne geldi:
            ////random 1-10 arası sayı üretelim 1000 sayı üretelim hangi sayıdan kaç tane ne geldi:
            //Random rnd = new Random();
            //byte number = 0;
            //int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0, nine = 0, ten = 0;

            //for (short i = 0; i < 1000; i++)
            //{
            //    number = (byte)rnd.Next(1, 11);
            //    switch (number)
            //    {
            //        case 1: one++; break;
            //        case 2: two++; break;
            //        case 3: three++; break;
            //        case 4: four++; break;
            //        case 5: five++; break;
            //        case 6: six++; break;
            //        case 7: seven++; break;
            //        case 8: eight++; break;
            //        case 9: nine++; break;
            //        case 10: ten++; break;
            //    }
            //}
            //Console.WriteLine($"bir={one} iki={two} üç={three} dört={four} beş={five}" +
            //    $"\naltı={six} yedi={seven} sekiz={eight} dokuz={nine} on={ten}");
            //Console.WriteLine("toplam sayı:" + (one * 1 + two * 2 + three * 3 + four * 4 + five * 5 +
            //    six * 6 + seven * 7 + eight * 8 + nine * 9 + ten * 10));
            #endregion
            #region 100 km hızı azaltma kaç saniye zeno paradoksu
            //// 100 km hızı azaltma kaç saniye zeno paradoksu
            //int seconds = 0;
            //double velocity = 100;
            //Console.WriteLine("kaç saniye frene basmak istiyorsun:");
            //seconds = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < seconds; i++)
            //{
            //    velocity = 0.9 * velocity;
            //    Console.WriteLine($"hız:{velocity}");
            //}
            #endregion
            // \t hücre hücre yerleştirme.Bir sekmeyle eşleşir.(tab tuşu)
            #region çarpım tablosu
            ////iç içe for
            ////for (int i = 1; i <= 10; i++)
            ////{
            ////    for (int j = 1; j <= 10; j++)
            ////    {

            ////        Console.Write($"{j}x{i}={j * i}\t");//\t hücre hücre yerleştirme.Bir sekmeyle eşleşir. 
            ////    }
            ////    Console.WriteLine();
            ////}
            //for (int a = 1; a <= 10; a++)
            //{
            //    for (int b = 1; b <= 5; b++)
            //    {
            //        Console.Write(b + "x" + a + "=" + (a * b) + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("---------------------------------------------------------");
            //Console.Write("\n");
            //for (int a = 1; a <= 10; a++)
            //{
            //    for (int b = 6; b <= 10; b++)
            //    {
            //        Console.Write(b + "x" + a + "=" + (a * b) + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            #endregion
            #region yıldız sayısı dörtgen oluşturma
            //int num_1, num_2;
            //Console.Write("satır sayısı:");
            //num_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("sütün sayısı:");
            //num_2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 0; i < num_1; i++)
            //{
            //    for (int j = 0; j < num_2; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region yıldızlarla üçgen oluşturma
            //int num_1 = 0;
            //Console.Write("sayı giriniz:");
            //num_1 = int.Parse(Console.ReadLine());
            //for (int i = 0; i < num_1; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region baklava dilimi
            //int num_1 = 0;
            ////Console.BackgroundColor = ConsoleColor.White;
            ////Console.ForegroundColor = ConsoleColor.Black;

            //Console.Write("sayı gir:");
            //num_1 = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //for (int i = 0; i < num_1; i++)
            //{
            //    for (int z = num_1; z > i + 1; z--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i < num_1; i++)
            //{
            //    for (int z = 0; z < i; z++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = num_1; j > i; j--)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            ////Console.WriteLine("Satır sayısı\n");
            ////int row = int.Parse(Console.ReadLine());
            ////int space = row;

            ////for (int i = 0; i <= row; i++)
            ////{
            ////    for (int b = space; b >= 1; b--)
            ////    {
            ////        Console.Write(" ");
            ////    }
            ////    for (int j = 0; j <= i; j++)
            ////    {
            ////        Console.Write("* ");
            ////    }
            ////    Console.Write("\n");
            ////    //space--;
            ////}

            ////for (int i = row - 1; i >= 0; i--)
            ////{
            ////    for (int b = space + 2; b >= 1; b--)
            ////    {
            ////        Console.Write(" ");
            ////    }
            ////    for (int j = 0; j <= i; j++)
            ////    {
            ////        Console.Write("* ");
            ////    }
            ////    Console.Write("\n");

            ////    //space++;
            ////}
            #endregion
            #region Karo Baklava
            //Console.Write("Baklava dilimi boyut yazını: ");
            //int boyut = int.Parse(Console.ReadLine());
            //for (int i = 0; i < boyut; i++)
            //{
            //    for (int j = boyut; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < i; k++)
            //    {
            //        Console.Write("*" + " ");
            //    }
            //    Console.WriteLine(" ");
            //}
            //for (int i = 0; i < boyut; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = boyut; k > i; k--)
            //    {
            //        Console.Write("*" + " ");
            //    }
            //    Console.WriteLine(" ");
            //}

            #endregion
            //while döngüsü
            #region örnek
            //int x = 0;
            //while (x < 10)
            //{
            //    Console.WriteLine(x + 1 + " A B C");
            //    x++;
            //}
            #endregion
            #region kullanıcının istediği kadar ismi ekrena yazdırma
            ////kullanıcını istediği kadar ismi ekrena yazdırma
            //int number;
            //int i = 0;
            //string text;

            //Console.Write("ne yazdırmak istiyosun:");
            //text = Console.ReadLine();
            //Console.Write("kaç adet yazdırmak lazım:");
            //number = Convert.ToInt32(Console.ReadLine());

            //while (number > i)
            //{
            //    Console.WriteLine(text);
            //    i++;
            //}
            #endregion
            #region 1den 10a yazdırma toplamını yazma
            //////1den 10a yazdırma toplamını yazma
            ////int sum = 0, count = 1;
            ////while (count < 11)
            ////{
            ////    sum += count;
            ////    count++;
            ////}
            ////Console.WriteLine($"toplam={sum}");
            #endregion
            #region 1den 50 ye kadar tek sayıları toplayıp tek sayıları yazan program
            ////1den 50 ye kadar tek sayıları toplayıp tek sayıları yazan program
            //int counter = 1;
            //int odd_sum = 0;
            //while (counter < 50)
            //{
            //    Console.Write(counter + " ");
            //    odd_sum += counter;
            //    counter += 2;
            //}
            //Console.WriteLine($"\ntek sayıların toplam={odd_sum}");
            #endregion
            #region klavyeden girilen sayı 0 olana kadar girilen sayılası toplayan program
            ////klavyeden girilen sayı 0 olana kadar girilen sayılası toplayan program.
            //// Klavyeden girilen sayı 0 olana kadar girilen
            //// sayıları toplayıp ortalamasını alan program. (çözüm de hata var)
            //int number = 0;
            //int sum = 0;
            //while (true)
            //{
            //    Console.Write("bir sayı gir:");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    sum += number;
            //    Console.WriteLine($"toplam:{sum}");
            //    if (number == 0)
            //        break;
            //}
            //Console.WriteLine("döngüden çıkıldı");
            #endregion
            #region Klavyeden girilen sayıların 100  toplamı yüz olduğunda kaç sayıyla girmiş kodu             
            //int number = 0;
            //int sum = 0;
            //int counter = 0;
            //while (sum < 100)
            //{
            //    Console.Write("sayı gir:");
            //    number = int.Parse(Console.ReadLine());
            //    sum += number;
            //    counter++;
            //}
            //Console.WriteLine($"toplam={sum} girilen sayı adedi={counter}");
            #endregion
            #region istenilen sayıyı istenilen tekrada bulan program
            //istenilen sayıyı istenilen tekrada bulan program
            // random sayı 0 - 100 arasında
            //Random rnd = new Random();
            //int number_1, number_2;
            //int counter_1 = 0, counter_2 = 0;
            //int again = 0;

            //Console.Write("hangi sayıyı bulmak istiyorsunuz:");
            //number_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("kaç kere bulmak istiyorsunuz:");
            //again = Convert.ToInt32(Console.ReadLine());

            //while (counter_1 < again)
            //{
            //    number_2 = rnd.Next(1, 101);
            //    if (number_1 == number_2)
            //        counter_1++;
            //    counter_2++;
            //}
            //Console.WriteLine($"seçilen sayı:{number_1}, {counter_1} kere bulundu ve toplam:{counter_2} deneme yapıldı");

            ////Random rnd = new Random();
            ////int sayi_1, sayi_2;
            ////int sayac_1 = 0, sayac_2 = 0;
            ////int tekrar = 0;

            ////Console.Write("hangi sayıyı bulmak istiyorsunuz:");
            ////sayi_1 = Convert.ToInt32(Console.ReadLine());
            ////Console.Write("kaç kere bulmak istiyorsunuz:");
            ////tekrar = Convert.ToInt32(Console.ReadLine());

            ////while (sayac_1 < tekrar)
            ////{
            ////    sayi_2 = rnd.Next(1, 101);
            ////    if (sayi_1 == sayi_2)
            ////        sayac_1++;
            ////    sayac_2++;
            ////}
            ////Console.WriteLine($"seçilen sayı:{sayi_1}, {sayac_1} kere bulundu ve toplam:{sayac_2} deneme yapıldı");
            ///


            //Random random = new Random();
            //int sayi = 0, adet = 0, sayacsayi = 0, sayacdongu = 0;
            //int rnd;

            //bool bl = true;


            //Console.WriteLine("Bulunacak sayi:");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Adet sayisi");
            //adet = Convert.ToInt32(Console.ReadLine());

            //while (bl)
            //{

            //    rnd = random.Next(0, 100);
            //    sayacdongu++;
            //    if (sayi == rnd)
            //    {
            //        sayacsayi++;
            //        if (sayacsayi == adet)
            //        {
            //            bl = false;
            //        }
            //    }
            //}
            //Console.WriteLine($"{sayi} {sayacsayi} kere bulundu {sayacdongu} deneme yapıldı");
            #endregion
            //do while kontrolü sonra yapar
            #region 1 den 10 a sayı yazdırma
            ////int x = 0;
            ////do
            ////{
            ////    Console.WriteLine("bir kere çalışır");
            ////} while (x < 0);

            //byte i = 0;
            //do
            //{

            //    Console.WriteLine(i + 1);
            //    i++;

            //} while (i < 10);
            #endregion
            #region 10 kadar yazılan sayıdan en büyük ve en küçüğü bulma;
            //byte counter = 1;
            //int number_1 = 0, number_2;
            //int bigger = 0, smaller = 0;
            //do
            //{
            //    if (counter == 1)
            //    {
            //        Console.WriteLine("bir sayı gir:");
            //        number_1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("bir sayı gir:");
            //        number_2 = Convert.ToInt32(Console.ReadLine());

            //        if (number_1 > number_2)
            //        {
            //            bigger = number_1;
            //            smaller = number_2;
            //        }
            //        else
            //        {
            //            bigger = number_2;
            //            smaller = number_1;
            //        }
            //    }
            //    Console.WriteLine("bir sayı gir:");
            //    number_2 = Convert.ToInt32(Console.ReadLine());
            //    if (number_2 > bigger)
            //        bigger = number_2;
            //    if (number_2 < smaller)
            //        smaller = number_2;
            //    counter++;


            //} while (counter < 9);

            //Console.WriteLine($"en büyük sayı={bigger}");
            //Console.WriteLine($"en küçük sayı={smaller}");
            #endregion
            #region asal sayı bulma
            ////asal sayı bulma programı
            //int number = 0;
            ////int i = 1;
            //int counter = 0;
            //Console.Write("bir sayi gir:");
            //number = Convert.ToInt32(Console.ReadLine());
            ////do
            ////{
            ////    if (number % i == 0)
            ////        counter++;
            ////    i++;
            ////}
            ////while (i < number);

            ////if (counter == 1)
            ////    Console.WriteLine("bu sayı asal");
            ////else
            ////    Console.WriteLine("bu sayı asal değil");

            //for (int i = 2; i < number; i++)
            //{
            //    if (number % i == 0)
            //        counter++;
            //}
            //if (counter == 0)
            //    Console.WriteLine("bu sayı asal");
            //else
            //    Console.WriteLine("bu sayı asal değil");
            ////while (i < number)
            ////{

            ////    if (number % i == 0)
            ////        counter++;
            ////    i++;

            ////}
            ////if (counter == 1)
            ////    Console.WriteLine("bu sayı asal");
            ////else
            ////    Console.WriteLine("bu sayı asal değil");
            #endregion
            #region asal sayı bulma 
            ////Kullanıcı bir sayı girecek. Kullanıcının
            ////girdiği sayıdan küçük asal sayıları sıralayacak program.
            //int number = 0;
            //int counter;
            //Console.Write("bir sayi gir:");
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i <= number; i++)
            //{
            //    counter = 0;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //            counter++;
            //    }
            //    if (counter == 0)
            //        Console.WriteLine($"{i} sayısı asaldır");
            //}

            ////int number = 0;
            ////int i = 2;
            ////int j = 1;
            ////int counter = 0;
            ////Console.Write("bir sayi girin:");
            ////number = int.Parse(Console.ReadLine());
            ////while (number > i)
            ////{
            ////    while (i > j)
            ////    {
            ////        if (i % j == 0)
            ////            counter++;
            ////        j++;
            ////    }
            ////    j = 1;
            ////    if (counter == 1)
            ////    {
            ////        Console.WriteLine($"{i} sayısı asaldır");
            ////    }
            ////    counter = 0;
            ////    i++;
            ////}
            #endregion
            #region çalışan maaşları
            /*  Aynı firmada çalışan Ahmet ve Hasan 2 işçiden 1. sinin Ahmedin
            ücreti ilk ay %50 artmakta 2. ay %25 azalmaktadır. 
            Diğerinin(Hasanın) ise ücreti her ay %25 artmaktadır. 
            Her ikisinin de yılbaşındaki başlangıç ücretleri ve hesaplanacak
            ay bilgisi klavyeden girildikten sonra ay ay  ücretlerinin
            ne olacağını ve en sonunda hangi işçinin daha fazla (Veya eşit)
            ücret alacağını hesaplayan programı yazınız.
             */

            //double ahmet = 5000, hasan = 5000;

            //for (byte i = 0; i < 6; i++)
            //{
            //    ahmet = ahmet * 1.50 * 0.75;               
            //    //ahmet = ahmet * 0.75;

            //    hasan = hasan * 1.25 * 1.25;
            //    //hasan = hasan * 1.25;
            //}
            //ahmet = Math.Round(ahmet, 2);
            //hasan = Math.Round(hasan, 2);
            //Console.WriteLine($"12 ay sonra ahmet maaş:{ahmet} hasan maaş:{hasan}");
            //Console.WriteLine("hasan ezmiş geçmiş");

            ////double ahmetMaas = 5000;
            ////double hasanMaas = 5000;

            ////Console.Write("Kaç ayın ücretini hesaplamak istiyorsunuz: ");
            ////int aySayisi = Convert.ToInt16(Console.ReadLine());

            ////for (int ay = 1; ay <= aySayisi; ay++)
            ////{
            ////    if (ay % 2 == 1)
            ////    {
            ////        ahmetMaas = ahmetMaas * 1.5;
            ////    }

            ////    else
            ////    {
            ////        ahmetMaas = ahmetMaas * 0.75;
            ////    }

            ////    hasanMaas = hasanMaas * 1.25;

            ////    Console.WriteLine("{0}. Ay, Ahmetin maaşı {1}, Hasanın maaşı {2}", ay, ahmetMaas, hasanMaas);

            ////}

            ////if (ahmetMaas > hasanMaas)
            ////{
            ////    Console.WriteLine("Ahmetin maaşı Hasanın maaşından fazladır");
            ////}
            ////else if (hasanMaas > ahmetMaas)
            ////{
            ////    Console.WriteLine("Hasanın maaşı Ahmetin maaşından fazladır");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Ahmetin maaşı ile Hasanın maaşı eşittir");
            ////}

            #endregion
            #region bakteri büyümesi
            /*
            Soru-
            Her 2 saniyede 2 ye bölünen bakteri
            kolonisi var başlangıç durumunda 16 tane var 24. sn deki bakteri sayısı
            12. saniyedeki bakteri sayısının kaç katıdır.
            // */
            //double bacteria_12 = 0, bacteria_24 = 0;
            //for (int i = 1; i <= 12; i++)
            //{
            //    bacteria_24 = Math.Pow(16, i);
            //    if (i == 6)
            //    {
            //        Console.WriteLine($"12. saniyede bakteri sayısı:{bacteria_24}");
            //        bacteria_12 = bacteria_24;
            //    }

            //}
            //Console.WriteLine($"24. saniyedeki bakteri sayısı={bacteria_24}");
            //Console.WriteLine(bacteria_24 / bacteria_12 + " katıdır");
            #endregion
            #region bakteri büyümesi
            //Console.WriteLine("Saniye Girin");
            //int saniye = Convert.ToInt32(Console.ReadLine());
            //int bakteri = 16;
            //int bakteri1 = 16;
            //int bakteri2 = 16;

            //for (int i = 1; i <= saniye; i += 2)
            //{
            //    bakteri = bakteri * 2;
            //    Console.WriteLine($"{i}.Saniyede Bakteri Sayısı={bakteri}");
            //    Console.WriteLine($"{i + 1}.Saniyede Bakteri Sayısı={bakteri}");

            //}
            //Console.WriteLine($"******************************************");


            //for (int i = 1; i <= 12; i += 2)
            //{
            //    bakteri1 = bakteri1 * 2;
            //}

            //for (int i = 1; i <= 24; i += 2)
            //{
            //    bakteri2 = bakteri2 * 2;
            //}

            //int sonuc = bakteri2 / bakteri1;
            //Console.WriteLine($"12.Saniyede Bakteri Sayısı = {bakteri1}");
            //Console.WriteLine($"24.Saniyede Bakteri Sayısı = {bakteri2}");
            //Console.WriteLine($"kat = {sonuc}");
            #endregion
            #region Romalı çarpımı
            ////Romalılar iki sayıyı çarpıyorlar
            //int num_1 = 0, num_2 = 0;
            //int sum = 0;
            //Console.Write("bir sayı gir:");
            //num_1 = int.Parse(Console.ReadLine());
            //Console.Write("bir sayı gir:");
            //num_2 = int.Parse(Console.ReadLine());

            //while (num_2 != 0)
            //{
            //    Console.WriteLine($"{num_1}\t{num_2}");
            //    if (num_2 % 2 == 1)
            //    {
            //        sum += num_1;
            //    }
            //    num_1 = num_1 * 2;
            //    num_2 = num_2 / 2;
            //}
            //Console.WriteLine($"toplam={sum}");

            ////int toplam = 0;
            ////Console.WriteLine("Birinci sayıyı giriniz=");
            ////int sayi1 = int.Parse(Console.ReadLine());
            ////Console.WriteLine("İkinci sayıyı giriniz=");
            ////int sayi2 = int.Parse(Console.ReadLine());
            ////do
            ////{
            ////    if (sayi1 % 2 == 1)
            ////    {
            ////        toplam = toplam + sayi2;
            ////    }
            ////    sayi1 = sayi1 / 2;
            ////    Console.WriteLine("ikiye bölüm " + sayi1);
            ////    sayi2 = sayi2 * 2;
            ////    Console.WriteLine("ikiyle çarpım " + sayi2);
            ////} while (sayi1 >= 1);
            ////Console.WriteLine("Sonuç = " + toplam);
            ////Console.ReadKey();


            #endregion
            #region mükemmel sayılar
            int num_1 = 96, num_2;
            int joker;

            Console.Write("sayıyı girin:");
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("sayıyı girin:");
            num_2 = Convert.ToInt32(Console.ReadLine());
            if (num_1 == 0)
                num_1 = 1;
            if (num_1 > num_2)
            {
                joker = num_2;
                num_2 = num_1;
                num_1 = joker;
            }
            for (int i = num_1; i <= num_2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine($"{i} mükemmel bir sayıdır");
            }

            #endregion
        }
    }
}
