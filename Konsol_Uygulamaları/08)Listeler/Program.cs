using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            //Crud(Create)
            // List<int> dizi = new List<int>();
            //List<int> dizi2 = new List<int>() { 8, 14, 36 };
            ////Ekleme
            //dizi.Add(15);
            //dizi.Add(16);
            //dizi.AddRange(new[] { 23, 34, 27 });
            //dizi.AddRange(dizi2);

            //dizi.Insert(2,40);

            ////foreach (var item in dizi)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //dizi.ForEach(item => Console.WriteLine(item));
            //Console.WriteLine();

            ////Silme
            //dizi.Remove(34);
            //Console.WriteLine();
            //dizi.ForEach(item => Console.WriteLine(item));
            //dizi.RemoveAt(3);//index siler
            //Console.WriteLine();
            //dizi.ForEach(item => Console.WriteLine(item));
            //Console.WriteLine(dizi.IndexOf(16));
          
            //List<int> numbers = new List<int>();
            //for (int i = 1; i <= 100; i++)
            //{
            //    numbers.Add(i);
            //}
            ////List<int> negatives = new List<int>();
            ////negatives = numbers.Where(x => x < 0).ToList();
            ////negatives.ForEach(i => Console.WriteLine(i));

            //var onlys = new List<int>();
            //onlys = numbers.Where(x => x % 2 != 0).ToList();

            //onlys = onlys.OrderByDescending(x => x).ToList();
            //onlys.ForEach(i => Console.WriteLine(i));
            //Console.Read();
            #region -100 den +100 e sayıları dizilere yerleştir negatif olanları yazdır

            //List<int> numbers = new List<int>();

            //for (int i = -100; i < 100; i++)
            //{
            //    numbers.Add(i);
            //}
            //List<int> negatives = new List<int>();
            //negatives = numbers.Where(x => x < 0).ToList();
            //negatives.ForEach(x => Console.Write(x + ","));
            #endregion
            #region kalanların adedi notları ve ortalamsını yazdıran program
            ////13 kişinin notları rasgele girilsin Next(100)
            ////kalanların adedi ve notlarını, ortalama yazdırınız.< 50
            //var grades = new List<int>();
            //var leftovers = new List<int>();
            //Random random = new Random();
            //int pieces = 0;

            //int grade = 0;
            //for (int i = 0; i < 13; i++)
            //{
            //    grade = random.Next(100);
            //    grades.Add(grade);
            //    if(grade<50)
            //        pieces++;
            //}

            //leftovers = grades.Where(x => x < 50).ToList();
            //Console.WriteLine($"kalanların ortalaması:{leftovers.Average()}");
            //Console.WriteLine($"kalanların sayısı:{leftovers.Count} veya {pieces}");
            //Console.WriteLine("kalanlar");
            //foreach(var item in leftovers)
            //{
            //    Console.Write(item+" ");
            //}
            //Console.WriteLine();
            //leftovers.ForEach(x => Console.Write(x+" "));

            #endregion
            #region kullanıcıdan girilen sayının katlarını yazdıran bir program
            ////rastgele 1,100 arasında 20 sayı üretin.Bu sayılar arasında kullanıcıdan girilen sayının katlarını yazdırınız.
            ////6,2,34,,...
            ////6 12 24,..
            //var numbers = new List<int>();
            //Random random = new Random();
            //int number = 0;
            //int entry_number = 0;


            //for (int i = 0; i < 20; i++)
            //{
            //    number = random.Next(100);
            //    numbers.Add(number);
            //}
            //Console.WriteLine("bir sayi giriniz:");
            //entry_number = Convert.ToInt32(Console.ReadLine());           
            //numbers.ForEach(x => Console.Write(x+" "));
            //Console.WriteLine();
            //numbers = numbers.Where(x => x % entry_number == 0).ToList();
            //numbers.ForEach(x => Console.Write(x + " "));
            #endregion
            /* 1-22 dan forma numarası olsun 
                      1.takımı : gs
                      2.takımı : fb
                      rastgele 11 tanesini gs takımına
                      diğer kalan 11 tanesini de fb takımına atacak
                      gs ve fb takımlarınıu yazdırınız

                       */
            #region 1 den  22 ye forma numaraları takım oluşturma

            //var form_number = new List<int>();
            //var gs = new List<int>();
            //var fb = new List<int>();

            //for (int i = 0; i < 22; i++)
            //{
            //    form_number.Add(i + 1);
            //}
            //Random random = new Random();

            //int counter = 0;

            //while (form_number.Count > 0) 
            //{
            //    int index = random.Next(0, form_number.Count);
            //    if (counter % 2 == 0)
            //        gs.Add(form_number[index]);
            //    else
            //        fb.Add(form_number[index]);
            //    form_number.RemoveAt(index);
            //    counter++;
            //}
            //Console.Write("gs takımı numaraları:");
            //gs.ForEach(x => Console.Write(x + " "));
            //Console.WriteLine();
            //Console.Write("fb takımı numaraları:");
            //fb.ForEach(x => Console.Write(x + " "));

            #endregion
            #region Banknot uygulaması
            //Kullanıdan para çekecek 378
            /* 200 - 1 
             * 100 - 1
             * 50 -1
             * 20 - 1
             * 5 - 1
             * 1-3
             */

            //var banknote = new List<int>() { 200, 100, 50, 20, 10, 5, 1 };
            //int taking_money = 0;
            //int piece = 0;
            //Console.Write("çekmek istediğiniz para miktarını giriniz:");
            //taking_money = int.Parse(Console.ReadLine());

            //while (taking_money != 0)
            //{
            //    foreach (var item in banknote)
            //    {
            //        piece = Math.DivRem(taking_money, item, out taking_money);
            //        Console.WriteLine($"{item} tl den{piece} adet vardır ");
            //    }
            //}
            #endregion
            #region fibonacci sayıları 

            //var fibonacci = new List<int>() { 1, 1 };
            //int i = 0;


            //while (fibonacci.Max() <= 100)//fibonacci.Last()<=100
            //{
            //    fibonacci.Add(fibonacci[i] + fibonacci[i + 1]);
            //    i++;
            //}
            //fibonacci.Remove(fibonacci.Last());
            //fibonacci.ForEach(x => Console.Write(x + " "));

            #endregion
            #region Sinema Bileti
            //Sinema 1-30 boş koltuklar olsun
            /*
             tüm koltuklar : 1-2-(3)....30
            dolu koltuklar:(3)
            koltuk seçiniz : 3
            tüm  koltuklar : 1,2,(3)4,...
            dolu koltuklar: 3,..
             */

            var allseats = new List<int>();
            var fullseats = new List<int>();
            int choosing = 0;

            for (int i = 0; i < 30; i++)
            {
                allseats.Add(i + 1);
            }
            while (fullseats.Count <= 30)
            {



                Console.Write("tüm koltuklar:");
                //allseats.ForEach(i => Console.Write(i+""));
                foreach (var item in allseats)
                {
                    if (fullseats.Contains(item))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(item + " ");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(item + " ");
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write("dolu koltuklar:");
                fullseats.Sort();
                foreach (var item in fullseats)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(item + " ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.Write("koltuk seçiniz:");
                choosing = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (choosing > 0 && choosing <= 30)
                {
                    if (fullseats.Contains(choosing))
                    {
                        Console.WriteLine("bu koltuk dolu başka koltuk seçiniz\n");
                    }
                    else
                    {
                        fullseats.Add(choosing);

                    }
                }
                else
                {
                    Console.WriteLine("yanlış koltuk numarası girdiniz");
                }
            }

            #endregion
            Console.ReadLine();
        }
    }
}
