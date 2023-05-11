using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Kosullar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region çay suyu kaynama uygulaması
            ////çay suyu kaynama uygulaması
            //double temparature;
            //Console.WriteLine("çay suyu kaynadı mı?");
            //Console.Write("suyun sıcaklığını yaz:");
            //temparature = Convert.ToDouble(Console.ReadLine());
            //if (temparature >= 100)
            //{
            //    Console.WriteLine("çay suyu kaynamış");
            //    Console.Beep();
            //    Console.Beep();
            //    Console.Beep();
            //    Console.Beep();
            //}
            //else
            //{
            //    Console.WriteLine("su kaynamadı bekle");
            //}
            #endregion
            #region katı sıvı gaz uygulaması
            ////katı sıvı gaz uygulaması
            //int temperature;
            //Console.Write("suyun sıcaklığını giriniz:");
            //temperature = Convert.ToInt32(Console.ReadLine());
            //if (temperature > 100)
            //{
            //    Console.WriteLine("gaz");
            //}
            //else if (temperature > 0)
            //{
            //    Console.WriteLine("sıvı");
            //}
            //else
            //{
            //    Console.WriteLine("gaz");
            //}
            #endregion
            #region girilen sayı pozitif mi negatif mi
            ////girilen sayı pozitif mi negatif mi?
            ////tools options general word wrap
            //int number;
            //Console.Write("bir sayı giriniz:");
            //number = Convert.ToInt32(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine("sayı pozitif");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("sayı negatif");
            //}
            //else
            //{
            //    Console.WriteLine("0 ne pozitif ne de negatif bir sayı");
            //}
            #endregion
            #region vize final hesaplayıcı
            //double midterm, final;
            //double average;
            //Console.Write("vize notunu gir:");
            //midterm = Convert.ToDouble(Console.ReadLine());
            //Console.Write("final notunu gir:");
            //final = Convert.ToDouble(Console.ReadLine());
            //average = midterm * 0.4 + final * 0.6;
            //Console.WriteLine($"ders ortalaması={average}");
            //if (average > 50)
            //{
            //    Console.WriteLine("dersi geçti");
            //}
            //else
            //{
            //    Console.WriteLine("dersten kaldı");
            //}
            #endregion
            #region kullanıcı adı şifre
            //string username, password;
            //Console.Write("kullanıcı adınızı giriniz:");
            //username = Console.ReadLine();
            //Console.Write("şifrenizi giriniz:");
            //password = Console.ReadLine();
            //if (username == "ilker" && password == "123456")
            //    Console.WriteLine("giriş başarılı");
            //else
            //    Console.WriteLine("giriş başarısız");
            #endregion
            #region büyük olan sayıyı yazma
            //kullanıcı iki sayı girecek bilgisayar büyük olanı yazacak
            //int a, b;
            //Console.Write("1. sayıyı gir:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayıyı gir:");
            //b = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //    Console.WriteLine($"{a} sayısı büyüktür");
            //else
            //    Console.WriteLine($"{b} sayısı büyüktür");
            #endregion
            #region kullanıcı üç sayı girecek bilgisayar büyük olanı yazacak
            //// kullanıcı üç sayı girecek bilgisayar büyük olanı yazacak
            //int a, b, c;
            //Console.Write("1. sayıyı gir:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayıyı gir:");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("3. sayıyı gir:");
            //c = Convert.ToInt32(Console.ReadLine());

            //if (a >= b && a >= c)
            //    Console.WriteLine($"{a} büyüktür");
            //else if (b >= a && b >= c)
            //    Console.WriteLine($"{b} büyüktür");
            //else if (c >= a && c >= b)
            //    Console.WriteLine($"{c} büyüktür");
            #endregion
            #region Kullanıcı ekrana 3 not girecek
            ///* SORU:
            //F – 0 - 45
            //D – 45 - 55
            //C – 55 - 70
            //B – 70 - 85
            //A – 85 - 100
            //Kullanıcı ekrana 3 not girecek, 
            //bilgisayar not ortalamasını alınacak ve  
            //not yukarıdaki harflerden hangisine uyuyorsa bilgisayar ekrana o harfi yazdıracak.*/
            //int note1, note2, note3;
            //double average_note;
            //Console.Write("1. notu gir");
            //note1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. notu gir");
            //note2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("3. notu gir");
            //note3 = Convert.ToInt32(Console.ReadLine());
            //average_note = (note1 + note2 + note3) / 3;
            //Console.WriteLine($"ortalama={average_note}");
            //if (average_note > 85)
            //    Console.WriteLine("A");
            //else if (average_note > 70)
            //    Console.WriteLine("B");
            //else if (average_note > 55)
            //    Console.WriteLine("C");
            //else if (average_note > 45)
            //    Console.WriteLine("D");
            //else if (average_note > 0)
            //    Console.WriteLine("F");
            //Console.Write(" aldı.");
            #endregion
            #region kullanıcı 4 işlem
            ////SORU: Kullanıcı iki sayı girecek ve 
            ////işlem seçtirecek(kullanıcı çarpma işlemi seçmişse çarpım verecek) 
            ////ve işlemi yaptıracak.
            //double number1, number2;
            //byte choice;
            //Console.WriteLine("toplama için 1'e\n" +
            //    "çıkarma için 2'ye\n" + "çarma için 3'e\n" + "bölme için 4'e bas");
            //choice = Convert.ToByte(Console.ReadLine());
            //Console.Write("1. sayıyı gir:");
            //number1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. sayıyı gir:");
            //number2 = Convert.ToDouble(Console.ReadLine());
            //if (choice == 1)
            //    Console.Write($"{number1}+{number2}={number1 + number2}");
            //else if (choice == 2)
            //    Console.Write($"{number1}-{number2}={number1 - number2}");
            //else if (choice == 3)
            //    Console.Write($"{number1}*{number2}={number1 * number2}");
            //else if (choice == 4)
            //{
            //    if (number2 != 0)
            //        Console.Write($"{number1}/{number2}={number1 / number2}");
            //    else
            //        Console.WriteLine("bölen 0 olamaz");
            //}
            //else
            //    Console.WriteLine("yanlış seçim");
            #endregion
            #region banknot uygulaması
            ////banknot uygulaması if siz
            //Console.Write("çekeceğiniz para miktarını yazınız:");
            //int banknote = Convert.ToInt32(Console.ReadLine());
            //int number = banknote;
            //int two_hundred = banknote / 200;
            //banknote = banknote - (two_hundred * 200);
            //int one_hundred = banknote / 100;
            //banknote = banknote - (one_hundred * 100);
            //int fifty = banknote / 50;
            //banknote = banknote - (fifty * 50);
            //int twenty = banknote / 20;
            //banknote = banknote - (twenty * 20);
            //int ten = banknote / 10;
            //banknote = banknote - (ten * 10);
            //int five = banknote / 5;
            //banknote = banknote - (five * 5);

            //Console.WriteLine($"{two_hundred} iki yüzlük {one_hundred} yüzlük {fifty} " +
            //    $"ellilik {twenty} yirmilik {ten} onluk {five} beşlik {banknote} birlik");
            //---------------
            ////banknot uygulaması metodlu

            //int ikiyuz = Math.DivRem(number, 200, out number);
            //int yuz = Math.DivRem(number, 100, out number);
            //int elli = Math.DivRem(number, 50, out number);
            //int yirmi = Math.DivRem(number, 20, out number);
            //int on = Math.DivRem(number, 10, out number);
            //int bes = Math.DivRem(number, 5, out number);
            //Console.WriteLine($"{ikiyuz} ikiyüz {yuz} yüz {elli} elli {yirmi} yirmi {on} on {bes} bes {number} birlik");
            ///*
            ////Console.Write("tutar giriniz: ");
            ////int s1 = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine(((s1 - (s1 % 200)) / 200) + "adet 200 lük");
            ////Console.WriteLine((((s1 - (s1 % 100)) / 100) % 2) + "adet 100 lük");
            ////Console.WriteLine((((s1 % 100) - (s1 % 50)) / 50) + "adet 50 lik");
            ////Console.WriteLine(((s1 % 50) / 20) + "adet 20 lik");
            ////Console.WriteLine(((s1 % 50) / 30) + "adet 10 luk");
            ////Console.ReadLine();
            //*/
            ////*
            //////int para, adet200,adet100,adet50,adet20;
            //////Console.WriteLine("Çekmek İstediğin Parayı Gir : ");
            //////para = Convert.ToInt32(Console.ReadLine());


            //////adet200 = para / 200;
            //////para = para % 200;
            //////adet100 = para / 100;
            //////para = para % 100;
            //////adet50 = para / 50;
            //////para = para % 50;
            //////adet20 = para / 20;
            //////para = para % 20;

            //////Console.WriteLine("200LUK ADET" + adet200 + "\n100LUK ADET"
            ////*/
            #endregion
            #region çift mi tek mi
            ////çift mi tek mi
            //int number = 0;
            //Console.Write("bir sayı gir:");
            //number = Convert.ToInt32(Console.ReadLine());
            //if (number >= 0)
            //{
            //    if (number % 2 == 0)
            //        Console.WriteLine("sayı çift");
            //    else
            //        Console.WriteLine("sayı tek");
            //}
            //else
            //    Console.WriteLine("negatif sayılarda teklik çiftlik olmaz");
            #endregion
            #region mevsim aylarını yazan program
            ////kullanıcını girdiği mevsimlerin aylarını yazan program
            //string seasons;
            //Console.Write("aylarını öğrenmek istediğiniz mevsimi girin:");
            //seasons = Console.ReadLine();
            //if (seasons.ToLower() == "ilkbahar")
            //    Console.WriteLine($"{seasons} ayları:mart nisan mayıs");
            //else if (seasons.ToLower() == "yaz")
            //    Console.WriteLine($"{seasons} ayları:haziran temmuz ağustos");
            //else if (seasons.ToLower() == "sonbahar")
            //    Console.WriteLine($"{seasons} ayları:eylül ekim kasım");
            //else if (seasons.ToLower() == "kış")
            //    Console.WriteLine($"{seasons} ayları:aralık ocak şubat");
            //else
            //    Console.WriteLine("yanlış bir şey girdiniz");
            #endregion
            #region km ücret hesaplama
            //double km = 0;
            //Console.Write("kaç km gitti:");
            //km = Convert.ToDouble(Console.ReadLine());
            //if (km <= 5)
            //    Console.WriteLine($"toplam alınacak ücret {km * 2} tl dir");
            //else if (km <= 12)
            //    Console.WriteLine($"toplam alınacak ücret {(km - 5) * 1 + 10} tl dir");
            //else
            //    Console.WriteLine($"toplam alınacak ücreti {(km - 12) * 0.5 + 17} tl dir");
            #endregion
            #region yaş ve cinsiyete göre sınıflandırma
            ///*
            //Kadınlar için yaş 5 ten küçükse bebek 10 dan küçükse çocuk 
            //35 ten küçükse genç 55 ten küçükse orta yaşlı diğer türlü emekli
            //Kullanıcıdan cinsiyet ve doğum tarihi istenecek Erkekler için  
            //yaş 5 ten küçükse bebek 10 dan küçükse çocuk  25 ten küçükse genç
            //50 ten küçükse orta yaşlı diğer türlü emekli
            //*/
            //string gender;
            //int age;
            //short birtyear;
            //Console.Write("cinsiyetiniz (Erkek/Kadın?) Yaz:");
            //gender = Console.ReadLine();
            //Console.WriteLine("doğum tarihinizi giriniz:");
            //birtyear = Convert.ToInt16(Console.ReadLine());
            //age = DateTime.Now.Year - birtyear;
            //Console.Write($"{age} yaşında ");
            //if (gender.ToUpper() == "ERKEK")
            //{
            //    if (age < 5)
            //        Console.WriteLine("erkek bebek");
            //    else if (age < 10)
            //        Console.WriteLine("erkek çocuk");
            //    else if (age < 25)
            //        Console.WriteLine("genç erkek");
            //    else if (age < 50)
            //        Console.WriteLine("orta yaşlı erkek");
            //    else
            //        Console.WriteLine("emekli");
            //}
            //else if (gender.ToUpper() == "KADIN")
            //{
            //    if (age < 5)
            //        Console.WriteLine("kız bebek");
            //    else if (age < 10)
            //        Console.WriteLine("kız çocuk");
            //    else if (age < 35)
            //        Console.WriteLine("genç kız");
            //    else if (age < 55)
            //        Console.WriteLine("orta yaşlı kadın");
            //    else
            //        Console.WriteLine("emekli");
            //}
            //else
            //    Console.WriteLine("cinsiyeti yanlış girdiniz");
            #endregion
            #region Mevsime bağlı olarak uygulanan hayali ve ters bir diyet programı
            ///*
            //  Mevsime bağlı olarak uygulanan hayali ve ters bir diyet programında 
            //aşağıdaki şartlara bağlı olarak mesaj veren iç içe if sorguları yazın.
            //- Bahar mevsimi ise:
            //-- kişi 70 ile 75 kilo arasında olmalıdır 
            //- Yaz mevsimi ise:
            //-- kişi 80 ile 85 kilo arasında olmalıdır
            //- Kış mevsimi ise: (diğer mevsimler de diyebiliriz)
            //-- kişi 60 ile 65 kilo arasında olmalıdır             
            // */
            //short weight;
            //string season;

            //Console.Write("kaç kilosunuz:");
            //weight = Convert.ToInt16(Console.ReadLine());
            //Console.Write("hangi mevsimdesiniz:");
            //season = Console.ReadLine();
            //if (season.ToLower() == "sonbahar" || season.ToLower() == "ilkbahar")
            //{
            //    if (weight >= 70 && weight <= 75)
            //        Console.WriteLine("bu mevsime göre kilonuz uygun");
            //    else if (weight < 70)
            //        Console.WriteLine("biraz kilo almalısınız");
            //    else
            //        Console.WriteLine("biraz kilo vermelisiniz");
            //}
            //else if (season.ToLower() == "kış")
            //{
            //    if (weight >= 60 && weight <= 65)
            //        Console.WriteLine("bu mevsime göre kilonuz uygun");
            //    else if (weight < 60)
            //        Console.WriteLine("biraz kilo almalısınız");
            //    else
            //        Console.WriteLine("biraz kilo vermelisiniz");
            //}
            //else if (season.ToLower() == "yaz")
            //{
            //    if (weight >= 80 && weight <= 85)
            //        Console.WriteLine("bu mevsime göre kilonuz uygun");
            //    else if (weight < 80)
            //        Console.WriteLine("biraz kilo almalısınız");
            //    else
            //        Console.WriteLine("biraz kilo vermelisiniz");
            //}
            //else
            //    Console.WriteLine("yanlış bir şeyler oldu");
            #endregion
            Console.ReadLine();
        }
    }
}
