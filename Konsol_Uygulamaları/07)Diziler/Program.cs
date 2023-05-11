using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
            1-Veri Tipi Dizileri
            2-List Diziler**

            v-//1-Veri Tipi Diziler
            // */
            ////Değer Girme Yöntemleri
            //1. yöntem
            //int[] dizi = new int[5];
            //dizi[0] = 1;
            //dizi[1] = 2;
            //dizi[2] = 3;
            //dizi[3] = 4;
            //dizi[4] = 5;

            //2. yöntem
            //int[] dizi_2 = { 1, 2, 3, 4, 5 };

            //foreach(var item in dizi_2)//listelerdede kullanılabilir
            //{
            //    Console.WriteLine(item);
            //}

            //Dizi Metotları
            ////Dizi Metorları
            //1-Length veya Count - dizinin uzunluğunu verir
            //dizi.Length
            //2-Clear - temizler
            //Array.Clear(dizi,0,dizi.Length);
            ////dizide ki tüm harfleri siler.
            //3-Reverse ters çevirir
            //Array.Reverse
            //Sort sıralama yapar küçükten büyüğe sıralar
            //IndexOf Array.IndexOf(dizi)

            //int[] dizi2 = { 1, 2, 3, 4, 5 };
            //Array.Clear(dizi2, 0, 2);
            //Array.Reverse(dizi2);

            //foreach (var item in dizi2)
            //{
            //    Console.WriteLine(item);
            //}
            #region rastgele_10_sayı_üretip_sıralama
            //Rastgele 10 sayı üretip sıralayalım
            //Random random = new Random();
            //int[] dizi = new int[10];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = random.Next(100);
            //}
            //Array.Sort(dizi);
            //Array.Reverse(dizi);
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region kullanıcıadı_şifre_uygulaması
            //3 kişinin kaydı yapılcak.name şifresi si birer dizide tutulacak 
            /*Login
             * name:?
             * sifre:?
             * giriş başarılı
             
             */
            //string[] user_name = new string[3];
            //string[] user_password = new string[3];
            //string kullanıcı_adi = "";
            //string sifre = "";

            //for (int i = 0; i < user_name.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.kullanıcı adı:");
            //    user_name[i] = Console.ReadLine();
            //    Console.WriteLine($"{i + 1}.şifre:");
            //    user_password[i] = Console.ReadLine();
            //}
            //Console.Clear();

            //Console.WriteLine("login");
            //Console.WriteLine("kullanıcı adı:");
            //kullanıcı_adi = Console.ReadLine();
            //Console.WriteLine("şifre:");
            //sifre = Console.ReadLine();
            //int index = Array.IndexOf(user_name, kullanıcı_adi);
            //if (index > -1)
            //{
            //    if (user_password[index] == sifre)
            //    {
            //        Console.WriteLine("giriş başarılı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("şifre yanlış");
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("böyle bir kullanıcı bulunamadı");
            //}

            #endregion
            #region Rastgele_Sayı_Üretme
            ////1-10 arası rastgele sayı üretilecek kullanıcını seçtiği
            ////sayının kaç kere tekrar ettiği yazacak
            //Random rnd = new Random();
            //int[] dizi = new int[10];
            //int sayac = 0;
            //Console.WriteLine("bir sayi giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(10);
            //    if (dizi[i] == sayi)
            //        sayac++;
            //}
            //Console.WriteLine($"kullanıcının seçtiği sayıdan {sayac} tane vardır");
            //foreach (var item in dizi)
            //{
            //    Console.Write(item);
            //    Console.Write(' ');
            //}

            //Rastgele 10 tane sayı üretip diziyi sıralayalım.
            //Random random= new Random();
            //int[] dizi = new int[10];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = random.Next(100);
            //}
            //Console.WriteLine("Dizi Elemanları");
            //foreach (var item in dizi)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Array.Sort(dizi);
            //Console.WriteLine("Sıralı Dizi küçükten büyüğe");
            //foreach (var item in dizi)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("Sıralı Dizi büyükten küçüğe");
            //Array.Reverse(dizi);
            //foreach (var item in dizi)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine("Dizinin ortalaması");
            //Console.WriteLine(dizi.Average());
            //Console.WriteLine("Dizinin ilk elamnı");
            //Console.WriteLine(dizi.First());
            //Console.WriteLine("Dizinin son elamnı");
            //Console.WriteLine(dizi.Last());
            //Console.WriteLine("Dizinin Max elamnı");
            //Console.WriteLine(dizi.Max());
            //Console.WriteLine("Dizinin Min elamnı");
            //Console.WriteLine(dizi.Min());
            //Console.WriteLine("Dizinin Toplamı elamnı");
            //Console.WriteLine(dizi.Sum());


            #endregion
            #region Rastgele_10_sayı_üretip_toplama

            ////rastgele -100,100 sayılar üretsin 10 sayı
            ////negatif/Pozitif dizileri yazdırınız,toplayınız,kaç adet
            //Random rnd = new Random();
            //int[] dizi = new int[10];
            ////int[] negatif_dizi = new int[10];
            ////int[] pozitif_dizi = new int[10];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i]=rnd.Next(-100,100);                
            //}

            //Console.Write("dizinin toplamı=");
            //Console.Write(dizi.Sum());
            //Console.WriteLine();
            //foreach(var item in dizi)
            //{
            //    Console.Write(item+" ");
            //}


            #endregion
            #region dizi_ort_bulma
            ////dizinin(int) boyutu ve elemanları kullanıdan girilsin dizinin ortalamasını bulunuz
            //Console.Write("dizinin boyutunu giriniz:");
            //int boyut = int.Parse(Console.ReadLine());
            //int[] dizi = new int[boyut];
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.Write($"{i + 1}.değeri giriniz:");
            //    dizi[i] = int.Parse(Console.ReadLine());


            //}
            //Console.Write($"dizinin ortalaması={dizi.Average()}\n");
            //foreach (var item in dizi)
            //{

            //    Console.Write(item + " ");
            //}

            #endregion
            #region girilen_metinde_kaç_sesli_harf_var
            ////girilen metin içerisnde kaç adet sesli harf var ?
            //string metin = "";
            //Console.WriteLine("bir şeyler yazın kafanıza göre");
            //metin = Console.ReadLine();
            //int adet = 0;

            //char[] sesli_harfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            //metin = metin.ToLower();
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (sesli_harfler.Contains(metin[i]))
            //    {
            //        adet++;
            //    }

            //}
            //Console.WriteLine($"toplam sesli harf sayısı={adet}");

            #endregion
            #region sayısal_loto
            //sayısal loto çekilişi 6 adet 1 - 50
            //6 - 14 - 25 - 40 - 45 - 49
            //int[] loto = new int[6];
            //int index = 0;
            //Random random = new Random();
            //do
            //{

            //    int x = random.Next(50);
            //    if (Array.IndexOf(loto, x) < 0)
            //    {
            //        loto[index] = x;
            //        index++;

            //    }
            //}
            //while (index < 6);


            //Array.Sort(loto);
            //foreach (var item in loto)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion
            #region dizide_rastgele_kaç_sayı_üretildiğini_bulma
            //rastgele 1 ile 10 arasında 10 tane sayı üretip diziye atacaksınız.Kullanıcıdan bir sayı istenilecek.
            //Dizide bu elaman kaç kez kullanılmış?
            //int[] dizi = new int[10];
            //Random random = new Random();
            //int sayi = 0;
            //int adet = 0;
            //int r = 0;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = random.Next(1,10);
            //}
            //Console.Write("1-10 arası bir sayı giriniz:");
            //sayi = int.Parse(Console.ReadLine());

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    r = dizi[i];
            //    if(r==sayi)
            //        adet++;
            //}
            //Console.WriteLine($"toplam:{adet} adet vardır");
            //foreach(int i in dizi)
            //{
            //    Console.Write(i+" ");
            //}
            #endregion
            #region  en uzun string değeri yazdıran algoritma
            ////5 adet string değer girilecek bunlar içerisinde en uzun kelimeyi yazdıracak alg?

            //string[] kelimeler = new string[5];
            //int harf_sayisi = 0;

            //for (int i = 0; i < kelimeler.Length; i++)
            //{
            //    Console.Write($"{i + 1}.kelimeyi giriniz:");
            //    kelimeler[i] = Console.ReadLine();
            //    if (kelimeler[i].Length > harf_sayisi)
            //    {
            //        harf_sayisi = kelimeler[i].Length;
            //    }
            //}

            //Console.WriteLine($"en uzun kelime {harf_sayisi} harflidir");
            //foreach (var s in kelimeler)
            //{   if(s.Length == harf_sayisi)//!kelimeler.Contains(s)
            //        Console.WriteLine(s);
            //}


            #endregion
            #region kullanıcı şifre kaydı yapma
            //3 kişinin kaydı yapılcak.name şifresi si birer dizide tutulacak 
            /*Login
             * name:?
             * sifre:?
             * giriş başarılı
             
             */

            //var User_Id = new string[3];
            //var Password = new string[3];
            //var Entry_Id = "";
            //var Entry_Password = "";

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i + 1}. kullanıcının adını giriniz:");
            //    User_Id[i] = Console.ReadLine();
            //    Console.WriteLine($"{i + 1}. kullanıcının şifresini giriniz: ");
            //    Password[i] = Console.ReadLine();
            //}
            //Console.Clear();

            //Console.WriteLine("kullanıcı adını giriniz:");
            //Entry_Id = Console.ReadLine();
            //Console.WriteLine("şifreyi giriniz: ");
            //Entry_Password = Console.ReadLine();
            //int index = Array.IndexOf(User_Id, Entry_Id);
            //if (index > -1)
            //{

            //    if (Password[index].Contains(Entry_Password))
            //    {
            //        Console.WriteLine("giriş başarılı");
            //    }
            //    else
            //    {
            //        Console.WriteLine("yanlış şifre girdiniz:");
            //        Console.WriteLine("tekrar deneyin");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("böyle bir kullanıcı bulunamadı.");
            //    Console.WriteLine("tekrar deneyin");
            //}

            #endregion
            #region negatif ve pozitif sayılar üretip toplamı ve adetlerini bulmak
            //var positive = new int[10];
            //var negative = new int[10];
            //Random rand = new Random();
            //int number = 0;
            //int positive_piece = 0;
            //int negative_piece = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    number = rand.Next(-100, 100);
            //    if (number > 0)
            //    {
            //        positive[positive_piece] = number;
            //        positive_piece++;
            //    }
            //    else if (number < 0)
            //    {
            //        negative[negative_piece] = number;
            //        negative_piece++;
            //    }

            //}

            //Console.WriteLine("pozitif sayılar: ");
            //foreach (var item in positive)
            //{
            //    if (item > 0)
            //        Console.Write(item + " ");
            //}
            //Console.WriteLine($"üretilen pozitif sayı adeti:{positive_piece}");
            //Console.WriteLine($"ortalaması:{positive.Average()}");

            //Console.WriteLine("negatif sayılar: ");
            //foreach (var item in negative)
            //{
            //    if (item < 0)
            //        Console.Write(item + " ");
            //}
            //Console.WriteLine($"üretilen pozitif sayı adeti:{negative_piece}");
            //Console.WriteLine($"ortalaması:{negative.Average()}");

            #endregion
            Console.ReadLine();

        }
    }
}
