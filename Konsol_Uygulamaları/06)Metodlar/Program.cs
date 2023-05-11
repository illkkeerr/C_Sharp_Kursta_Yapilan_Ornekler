using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write()
            //Console.WriteLine("merhaba");
            //Write();            
            #endregion
            #region Write(string text,int repeat)
            //string text; int repeat;
            //Console.Write("ne yazdırmak istiyorsun:");
            //text = Console.ReadLine();
            //Console.Write("kaç defa yazdırmak istiyorsun:");
            //repeat = int.Parse(Console.ReadLine());
            //Write(text, repeat);
            #endregion
            #region iki sayıyı toplayan metod Sum()
            //Sum();
            #endregion
            #region sayının tek mi çift mi olduğunu bulan program evenOrOdd()
            //evenOrOdd();
            #endregion
            #region girilen üç sayıdan büyük ve küçüğü yazdıran metod big_small_finder()
            //big_small_finder();
            #endregion
            #region 25 yarış atından en hızlı 3 atı bulma fasterhorses()
            //fasterhorses();
            #endregion
            #region hesap makinesi calculator()
            //calculator();
            #endregion
            #region silindirin ve küpün hacmi cube_volume()
            //cube_volume();
            #endregion
            /*Turnuva maçları örnek kod
             int[] takımlar = new int[8];
            for (int i = 0; i < 8; i++)
            {
                takımlar[i] = i + 1;
            }
            int sayac = 0, sayac2 = 0, sayac3 = 0, sayac4 = 0;
            Random ran = new Random();
            int[] dizi2 = new int[takımlar.Length / 2];
            int[] dizi3 = new int[takımlar.Length / 2];
            for (int i = 0; i < takımlar.Length;)
            {
                int eleman = ran.Next(1, 9);
                for (int j = 0; j < dizi2.Length; j++)
                {
                    if (eleman == dizi2[j])
                    {
                        sayac++;
                    }
                    if (eleman == dizi3[j])
                    {
                        sayac++;
                    }
                }
                if (sayac2 % 2 == 1)
                {
                    if (sayac == 0)
                    {
                        dizi2[sayac3] = eleman;
                        i++;
                        sayac3++;
                        sayac2++;
                    }
                }
                else if (sayac2 % 2 == 0)
                {
                    if (sayac == 0)
                    {
                        dizi3[sayac4] = eleman;
                        i++;
                        sayac4++;
                        sayac2++;
                    }
                }
                sayac = 0;
            }
            Console.WriteLine("İlk Turnuva Maçları\n----------------------");
            for (int i = 0; i < dizi2.Length; i++)
            {
                Console.WriteLine("Takım" + dizi2[i] + " Vs " + "Takım" + dizi3[i]);
            }
            for (int i = 0; i < dizi2.Length; i++)
            {
                int mac = ran.Next(1, 3);
                if (mac == 1)
                {
                    dizi2[i] = 0;
                }
                else if (mac == 2)
                {
                    dizi3[i] = 0;
                }
            }
            int[] dizi4 = new int[4];
            int sayac5 = 0;
            Console.WriteLine("Maçlar Başlasın mı ?");
            Console.Read();
            Console.WriteLine("!!!!!...Turnuva 1 Başlıyor...!!!!");
            for (int i = 0; i < dizi2.Length; i++)
            {
                Console.Write((i + 1) + ". Maç Yapılıyor.");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".\n");
                System.Threading.Thread.Sleep(1000);
                if (dizi2[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi2[i]);
                    dizi4[sayac5] = dizi2[i];
                    sayac5++;
                }
                else if (dizi3[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi3[i]);
                    dizi4[sayac5] = dizi3[i];
                    sayac5++;
                }
            }

            int[] dizi5 = new int[2];
            int[] dizi6 = new int[2];
            sayac4 = 0;
            sayac3 = 0;
            sayac5 = 0;
            sayac2 = 0;
            for (int i = 0; i < 4;)
            {
                int eleman = ran.Next(0, 4);
                for (int j = 0; j < dizi5.Length; j++)
                {
                    if (dizi4[eleman] == dizi5[j])
                    {
                        sayac++;
                    }
                    if (dizi4[eleman] == dizi6[j])
                    {
                        sayac++;
                    }
                }
                if (sayac2 % 2 == 1)
                {
                    if (sayac == 0)
                    {
                        dizi5[sayac3] = dizi4[eleman];
                        i++;
                        sayac3++;
                        sayac2++;
                    }
                }
                else if (sayac2 % 2 == 0)
                {
                    if (sayac == 0)
                    {
                        dizi6[sayac4] = dizi4[eleman];
                        i++;
                        sayac4++;
                        sayac2++;
                    }
                }
                sayac = 0;
            }
            Console.WriteLine("5 Sn Sonra 1. Tur Turnuva Maçları Bitiyor");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("2. Turnuva Maçları\n----------------------");
            for (int i = 0; i < dizi5.Length; i++)
            {
                Console.WriteLine("Takım" + dizi5[i] + " Vs " + "Takım" + dizi6[i]);
            }
            for (int i = 0; i < dizi6.Length; i++)
            {
                int mac = ran.Next(1, 2);
                if (mac == 1)
                {
                    dizi5[i] = 0;
                }
                else if (mac == 2)
                {
                    dizi6[i] = 0;
                }
            }
            Console.WriteLine();
            sayac5 = 0;
            int[] dizi7 = new int[2];
            Console.WriteLine("!!!!!...Turnuva 2 Başlıyor...!!!!");
            Console.WriteLine("5 Sn Sonra 2. Turnuva Maçları Başlıyor");
            System.Threading.Thread.Sleep(5000);
            for (int i = 0; i < dizi5.Length; i++)
            {
                Console.Write((i + 1) + ". Maç Yapılıyor.");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
                System.Threading.Thread.Sleep(1000);
                Console.Write(".\n");
                System.Threading.Thread.Sleep(1000);
                if (dizi2[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi5[i]);
                    dizi7[sayac5] = dizi5[i];
                    sayac5++;
                }
                else if (dizi3[i] != 0)
                {
                    Console.WriteLine((i + 1) + ". Maçın Kazananı = Takım" + dizi6[i]);
                    dizi7[sayac5] = dizi6[i];
                    sayac5++;
                }
            }
            Console.WriteLine("!!!! Final !!!!\n----------------");
            Console.WriteLine("Takım" + dizi7[0] + " Vs " + "Takım" + dizi7[1]);
            Console.WriteLine("Final 5 Sn sonra Başlıyacak ?");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("!!!!!...Final Başlıyor...!!!!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Maç Yapılıyor " + "Takım" + dizi7[0] + " Vs " + "Takım" + dizi7[1]);
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            int mac2 = ran.Next(3, 5);
            if (mac2 == 3)
            {
                Console.WriteLine("Final Maçın Kazananı = Takım" + dizi7[0]);
            }
            else if (mac2 == 4)
            {
                Console.WriteLine("Final Maçın Kazananı = Takım" + dizi7[1]);
            }
            Console.ReadKey();

            */
            //parametreli metotlar
            #region girilen mesajı istenildiği kadar yazdıran metod WriteMessage(string text, int piece)
            //Console.Write("bir mesaj giriniz:");
            //string message = Console.ReadLine().Trim();
            //WriteMessage(message, 2);
            #endregion
            #region EnterNumbers()
            //EnterNumbers();
            #endregion
            #region tek mi çift mi? EvenOrOdd(int number)
            //int num;
            //Console.Write("bir sayı gir:");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine(EvenOrOdd(num));
            #endregion
            #region Üs alma ExponentOfNumber(double number, double power)
            //Console.Write("bir sayı girin:");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("üs girin:");
            //int power = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"iki sayının üssü={ExponentOfNumber(number, power)}");
            #endregion
            #region silindirin hacmi CylinderVolume(double radius, double height) ve CylinderVolume()
            ////double radius, height;
            ////Console.Write("yarıçap uzunluğu gir");
            ////radius = double.Parse(Console.ReadLine());
            ////Console.Write("yükseklik gir:");
            ////height = Convert.ToDouble(Console.ReadLine());
            ////Console.WriteLine($"silindirin hacmi={CylinderVolume(radius, height)}");
            //CylinderVolume();
            #endregion
            #region kullanıcıdan alınan mesajı geri döndürme ReturnText(string text)
            ////string message;
            ////Console.WriteLine("bir şeyler yaz:");
            ////message = Console.ReadLine();
            ////Console.WriteLine(ReturnText(message));
            //Console.WriteLine(ReturnText());

            #endregion
            #region iki sayının toplamını dödüren metod
            //Console.WriteLine(Sum_());
            #endregion
            #region hız zaman yol hesaplama metodu Velocity_Time_Way()
            //Console.WriteLine(Velocity_Time_Way());
            #endregion
            #region sipariş isteme GetAccount(string order) 
            //string order;
            //Console.WriteLine("ne sipariş vermek istersiniz?");
            //Console.WriteLine("Yiyecekler:Hamburger,Çiğköfte,Tavuk Döner,Et Döner");
            //Console.WriteLine("İçecekler:Kola,ayran,çay,soda,su");
            //Console.WriteLine("tatlılar:supangle,baklava,pasta");
            //Console.WriteLine("boşluk bırakarak yazın");
            //Console.Write("lütfen seçiminizi yazınız:");
            //order = Console.ReadLine();
            //Console.WriteLine(GetAccount(order));
            #endregion
            /*sipariş isteme örnekler 1
             HESAP ALMA SORUSU(YİYECEK/İÇECEK) 

            static void Main(string[] args)
        {
            Console.WriteLine("Hesap = " + HesapAl(Yiyecek(), Icecek())+" TL");

            Console.Read();

        }
        static int Yiyecek()
        {
            Console.WriteLine("Ne Yemek İstiyorsunuz?\n");

            Console.WriteLine("Yiyecek Menüsü:");
            Console.WriteLine("1-Hamburger Menüsü:");
            Console.WriteLine("2-Çiğköfte Menüsü:");
            Console.WriteLine("3-Kebap/İskender Menüsü:");
            int fiyat = 0;
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                fiyat = 80;
            }
            else if (menu == 2)
            {
                fiyat = 30;
            }
            else if (menu == 3)
            {
                fiyat = 70;
            }

            return fiyat;

        }
        static int Icecek()
        {
            Console.WriteLine("Ne İçmek İstiyorsunuz?\n");

            Console.WriteLine("İçecek Menüsü:");
            Console.WriteLine("1-Kola");
            Console.WriteLine("2-Şalgam");
            Console.WriteLine("3-Ayran");
            Console.WriteLine("4-Ice Tea");
            Console.WriteLine("5-Limonata");
            int fiyat = 0;
            int menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                fiyat = 15;
            }
            else if (menu == 2)
            {
                fiyat = 10;
            }
            else if (menu == 3)
            {
                fiyat = 7;
            }
            else if (menu == 4)
            {
                fiyat = 12;
            }
            else if (menu == 5)
            {
                fiyat = 20;
            }

            return fiyat;

        }

        static int HesapAl(int y, int i)
        {
            return y + i;
        }

        }
              
              
             */
            #region öğrenci ve kitap bilgileri gönderip alma
            ////öğrenci ve kitap bilgileri gönderip alma
            ////KİTABIN ADI, SAYFA SAYISI, KİTABIN YAZARI VE FİYATI
            ////string bookname, numofpages, author;
            ////double price;
            ////Console.Write("kitabın adı:");
            ////bookname = Console.ReadLine();
            ////Console.Write("kitabın sayfası:");
            ////numofpages = Console.ReadLine();
            ////Console.Write("kitabın yazarı:");
            ////author = Console.ReadLine();
            ////Console.Write("kitabın fiyatı:");
            ////price = double.Parse(Console.ReadLine());
            ////Book(bookname, numofpages, author, price);
            //Book("sefiller", "154", "victor Hugo", 85.75);
            #endregion
            #region Karenin alanını dönüşlü ve parametreli yapma
            //double side;
            //Console.Write("kenar uzunluğu gir:");
            //side = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"karenin alanı:{square_area(side)} br^2");
            #endregion
            #region araç kiralama
            //rent_car(choose_car());
            #endregion
            //overloading
            #region overloading
            //Write1();
            //Write1("Hello World!!");
            //Write1("Hello Good Peoples!!", 5);
            #endregion
            #region sum overloading methods
            //Sum1(8, 5, 3);
            //Sum1(8, 5);
            //Sum1();
            #endregion
            //string format önemli
            #region string format metodu(önemli)
            //////Console.WriteLine("-------------------------------------------------------");
            //////Console.WriteLine("Sıra No | Adınız | Soyadınız");
            //////Console.WriteLine("-------------------------------------------------------");
            //////Console.WriteLine(string.Format("{0,7}|{1,-8}|{2,10}", 1, "Ömer", "ERTÜRK"));
            //////Console.WriteLine(string.Format("{0,7}|{1,-8}|{2,10}", 2, "Tevfik", "ULUÇ"));
            //////Console.WriteLine(string.Format("{0,7}|{1,-8}|{2,10}", 3, "Yücel", "CAN"));
            //////Console.WriteLine("-------------------------------------------------------");
            ////Console.WriteLine(string.Format("{0:00000}", 15));
            ////Console.WriteLine(string.Format("{0:00000}", -15));
            ////Console.WriteLine(string.Format("{0,5}", 15));
            ////Console.WriteLine(string.Format("{0,-5}", 15));
            //// Console.WriteLine(string.Format("{0:### ### ## ##}", 5343053092));
            //String.Format("{0:00000}", 15); // "00015"
            ///*ifadesiyle 15 sayısı ekrana başına 3 adet 0 eklenerek toplamda 5 karakter olarak yazılır.*/

            //String.Format("{0:00000}", -15); // "-00015"
            ///*ifadesiyle -15 sayısı ekrana başına 3 adet 0 eklenerek toplamda 5 karakter olarak yazılır.*/

            //String.Format("{0,5}", 15); // " 15"
            ///*ifadesiyle 15 sayısı ekrana başına 3 adet boşluk eklenerek toplamda 5 karakterlik bir alana sağa hizalı olarak yazılır.*/

            //String.Format("{0,-5}", 15); // "15 "
            ///*ifadesiyle 15 sayısı ekrana başına 3 adet boşluk eklenerek toplamda 5 karakterlik bir alana sola hizalı olarak yazılır.*/

            //String.Format("{0,5:000}", 15); // " 015"
            ///*ifadesiyle 15 sayısı ekrana başına bir adet 0 ve iki adet boşluk eklenerek toplamda 5 karakterlik bir alana sağa hizalı olarak yazılır.*/

            //String.Format("{0,-5:000}", 15); // "015 "
            ///*ifadesiyle 15 sayısı ekrana başına bir adet 0 ve iki adet boşluk eklenerek toplamda 5 karakterlik bir alana sola hizalı olarak yazılır.*/

            //Console.WriteLine(String.Format("{0:### ## ##}", 1234567)); ; // 123 45 67
            //Console.WriteLine(String.Format("{0:(#) ###-##-##}", 12345678)); ; //(1) 234-56-78
            ///* Ondalıklı sayılarda virgülden (programlamada nokta) sonra kaç basamak görünsün istiyorsak köşeli parantezler ({ }) içerisindeki biçimleme kısmında noktadan sonra o kadar sıfır (0) koymamız gerekir;*/
            //String.Format("{0:0.00}", 123.4567); // "123.46"
            //String.Format("{0:0.00}", 123.4); // "123.40"
            //String.Format("{0:0.00}", 123); // "123.00"

            ///*Eğer ondalıklı sayının en fazla kaç basamağının ekranda çıkmasını istiyorsak, bu sefer sıfır yerine o kadar sayıda diyez (#) işareti kullanmamız gerekir;*/
            //String.Format("{0:0.##}", 123.4567); // "123.46"
            //String.Format("{0:0.##}", 123.4); // "123.4"
            //String.Format("{0:0.##}", 123); // "123"

            ///*Ondalıklı sayılarda virgülden önce kaç basamak görüntülemek istiyorsak biçimlendirme yaparken, noktadan önce kaç basamak istiyorsak o kadar sıfır (0) kullanmamız gerekir;*/
            //String.Format("{0:000.0}", 123.4567); // "123.5"
            //String.Format("{0:000.0}", 23.4567); // "023.5"
            //String.Format("{0:00.00}", 3.4567); // "03.46"
            //String.Format("{0:00.00}", -3.4567); // "-03.46"

            ////Eğer sayıların görüntülenmesinde bin ayracı kullanılmak isteniyorsa;
            //String.Format("{0:0,0.0}", 12345.678); // "12,345.7"
            //String.Format("{0:0,0.00}", 12345.678); // "12,345.68"
            //String.Format("{0:0,0}", 12345.678); // "12,346"

            ///*0 ile 1 arasındaki ondalıklı sayıların gösterimi iki şekilde olur. Birincisinde sayının tam kısmı 0 ve noktadan sonra ondalıklı kısmı gelir (Örn: 0.123 şeklinde), bir diğer gösterim şeklinde ise sayının tam kısmı yazılmaz sadece nokta ve sonrasındaki ondalıklı kısım yazılır (Örn: .123 şeklinde).İşte bu durumlardaki sayıların gösterimi ise şu şekilde gerçekleştirilir;*/
            //String.Format("{0:0.0}", 0.0); // "0.0"
            //String.Format("{0:0.#}", 0.0); // "0"
            //String.Format("{0:#.0}", 0.0); // ".0"
            //String.Format("{0:#.#}", 0.0); // ""

            ///*Bütün bu formların dışında sayılarımızı aşağıdaki gibi istediğimiz metinler ile birlikte yazmamız da mümkündür;*/
            //String.Format("{0:sonuç 0.0}", 12.3); // "sonuç 12.3"
            //String.Format("{0:x0x.yy0yy}", 12.3); // "x12x.yy3yy"


            #endregion
            //Date Time metodu
            #region Date time
            ////DateTime time = DateTime.Now;
            ////Console.WriteLine(time);
            ////Console.WriteLine($"{time.Year} yılındayız");
            ////Console.WriteLine($"yılın {time.Month}. ayındayız");
            ////Console.WriteLine($"ayın {time.Day}. günündeyiz");
            ////Console.WriteLine($"haftanın {time.DayOfWeek} günündeyiz");
            //DateTime zaman = DateTime.Now;
            //DateTime tarih = zaman.Date;
            //int ay = zaman.Month;
            //int gün = zaman.Day;
            //int yıl = zaman.Year;
            //DayOfWeek haftanıngünü = zaman.DayOfWeek;
            //int yılınkaçıncıgünü = zaman.DayOfYear;
            //TimeSpan süre = zaman.TimeOfDay;//time span iki tarih arasındaki zaman farkını yazar
            //int saat = zaman.Hour;
            //int dakika = zaman.Minute;
            //int saniye = zaman.Second;
            //int salise = zaman.Millisecond;
            //Console.WriteLine("Şu andaki zaman : {0}", zaman);
            //Console.WriteLine("Tarih bilgisi : {0}", tarih);
            //Console.WriteLine("Ay bilgisi : {0}", ay);
            //Console.WriteLine("gün bilgisi : {0}", gün);
            //Console.WriteLine("yıl bilgisi : {0}", yıl);
            //Console.WriteLine("Haftanın günü : {0}", gün);
            //Console.WriteLine("Yılın kaçıncı günü : {0}", yılınkaçıncıgünü);
            //Console.WriteLine("Süre : {0}", süre);
            //Console.WriteLine("Saat : {0}", saat);
            //Console.WriteLine("dakika : {0}", dakika);
            //Console.WriteLine("saniye : {0}", saniye);
            //Console.WriteLine("salise : {0}", salise);
            //Console.ReadLine();
            #endregion
            //TimeSpan iki tarih arasındaki farkı alır
            #region birtday();
            //birtday();
            #endregion
            #region date time süre ekleme
            ///* 12 / 07 / 2008  20:12:23:33(saat: dakika:saniye: salise) tarihinden
            // 5 yıl, 6 ay, 28 gün, 23 saat, 29 dakika, 33 saniye ve 43 salise sonrasının
            // tarihini ekrana yazan program.*/
            //DateTime date = new DateTime(2008, 07, 12, 20, 12, 23, 33);
            //Console.WriteLine(date);
            //date = date.AddDays(28).AddMonths(6).AddYears(5).AddHours(23).AddMinutes(29).AddSeconds(33).AddMilliseconds(33);
            //Console.WriteLine(date);
            #endregion
            #region classa giriş uygulaması
            ////string[] ilker = new string[] { "ilker", "şenel", "balık", "c#" };
            ////string[] fatih = new string[] { "fatih miraç", "polat", "yengeç", "c#" };
            ////string[] beyza = new string[] { "beyza", "daldal", "aslan", "c#" };


            ////object[] array2 = new object[] { ilker,fatih,beyza };
            //string[] array = new string[3];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("ad gir:");
            //    array[i] = Console.ReadLine();
            //    Console.Write("soyad gir:");
            //    array[i] += " " + Console.ReadLine();
            //    Console.Write("burç gir:");
            //    array[i] += " " + Console.ReadLine();
            //    Console.Write("yetenek gir:");
            //    array[i] += " " + Console.ReadLine();
            //}
            #endregion


            Console.ReadLine();
        }
        static void birtday()
        {
            DateTime bugün; TimeSpan süre;
            bugün = DateTime.Now;
            Console.WriteLine("Doğum tarihinizi girin: ");
            DateTime doğumtarihiniz = DateTime.Parse(Console.ReadLine());
            süre = bugün.Subtract(doğumtarihiniz);
            Console.WriteLine("Dünya üzerine geleli {0} yıl olmuş.", süre.TotalDays / 365);
            Console.WriteLine("Dünya üzerine geleli {0} gün olmuş.", süre.TotalDays);
            Console.WriteLine("Dünya üzerine geleli {0} saat olmuş.", süre.TotalHours);
            Console.WriteLine("Dünya üzerine geleli {0} dakika olmuş.", süre.TotalMinutes);
            Console.WriteLine("Dünya üzerine geleli {0} saniye olmuş.", süre.TotalSeconds);
            Console.WriteLine("Dünya üzerine geleli {0} salise olmuş.", süre.TotalMilliseconds);
            Console.ReadLine();

        }
        static void Sum1(double a, double b, double c)
        {
            Console.WriteLine($"{a}+{b}+{c}={a + b + c}");
        }
        static void Sum1(double a, double b)
        {
            Console.WriteLine($"{a}+{b}={a + b}");
        }
        static void Sum1()
        {
            Console.Write("sayı 1:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("sayı 2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}");
        }
        static void Write1(string message, int repeat)
        {
            int i = 0;
            while (i < repeat)
            {
                Console.WriteLine(message);
                i++;
            }
        }
        static void Write1(string message)
        {
            Console.WriteLine(message);
        }
        static void Write1()
        {
            Console.WriteLine("merhaba");
        }
        //overloading üstteki metotlar ↑↑↑↑↑↑↑↑
        static void rent_car(string car)
        {
            double price = 0;
            Console.Write("kaç saat kiralamak istiyorsunuz:");
            double hour = Convert.ToDouble(Console.ReadLine());
            if (car == "tofaş".ToUpper())
                price = hour * 800;
            else if (car == "Mercedes".ToUpper())
                price = hour * 150;
            else if (car == "AuDi".ToUpper())
                price = hour * 200;
            else if (car == "TOyoTA".ToUpper())
                price = hour * 600;
            else if (car == "volvo".ToUpper())
                price = hour * 50;
            /* else bloğu
            else
            {
                string key;
                Console.Clear();
                Console.WriteLine("yanlış veri girişi yapıldı.");
                Console.Write("çıkış yapmak için herhangi bir tuşa devam etmek için 1'e basınız:");
                key = Console.ReadLine();
                if (key == "1")
                    rent_car(choose_car());
                else Environment.Exit(0);

            }            
            */
            if (price > 1500)
                Console.WriteLine($"yüzde 20 indirim yapıldı ücret {price}TL'den {price * 0.8}Tl'ye düştü");
            else
                Console.WriteLine($"{car} kiraladınız.ödemeniz gereken ücret {price}TL dir.");
        }
        static string choose_car()
        {
            string car;
            string[] cars = new string[] { "tofaş".ToUpper(), "mercedes".ToUpper(), "audi".ToUpper(), "toyota".ToUpper(), "VOLVO" };
            double[] price = new double[] { 800, 150, 200, 600, 50 };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{cars[i]} saatlik kiralama ücreti: {price[i]} TL dir.");
            }
            Console.Write("\nHangi marka aracı kiralamak istiyorsunuz yazınız:");
            car = Console.ReadLine().ToUpper();
            switch (car)
            {
                case "MERCEDES": return "MERCEDES";
                case "TOFAŞ": return "TOFAŞ";
                case "AUDİ": return "AUDİ";
                case "TOYOTA": return "TOYOTA";
                case "VOLVO": return "VOLVO";
                default:
                    Console.Clear();
                    Console.WriteLine("Yanlış seçim");
                    return choose_car();
            }


        }
        static double square_area(double side)
        {
            return side * side;
        }
        static void Book(string bookname, string num_of_pages, string author, double price)
        {
            Console.WriteLine($"{bookname.ToUpper()} {num_of_pages} sayfa {author.ToUpper()} {price}TL  ");
        }
        static object GetAccount(string order)
        {
            string[] foods = new string[] { "HAMBURGER", "ÇİĞKÖFTE", "TAVUK", "ET", "KOLA", "AYRAN", "ÇAY", "SODA", "SU",
                "SUPANGLE","BAKLAVA","PASTA" };
            double[] prices = new double[] { 45.99, 25.85, 30.00, 50.45, 15.00, 10.00, 8.00, 9.50, 3.50, 13.00, 18.00, 30.00 };
            double price = 0;
            order = order.ToUpper().Trim();
            string[] orders;
            orders = order.Split(' ');

            for (int i = 0; i < foods.Length; i++)
            {
                if (orders.Contains(foods[i]))
                {
                    price = price + prices[i];
                }
            }

            return "Toplam ücret=" + price + "TL";
        }
        static object Velocity_Time_Way()
        {
            string text;
            double way, time, velocity;


            Console.WriteLine("hangi sonucu bulmak istiyorsun");
            Console.WriteLine("Hız,Zaman,Yol");
            Console.Write("seçimini yaz:");
            text = Console.ReadLine().ToUpper();
            if (text == "Hız".ToUpper())
            {
                Console.Write("Yolu gir(km):");
                way = Convert.ToInt32(Console.ReadLine());
                Console.Write("Zamanı gir(saat):");
                time = Convert.ToInt32(Console.ReadLine());
                return (way / time) + " km/h";
            }
            else if (text == "Zaman".ToUpper())
            {
                Console.Write("Yolu gir(km):");
                way = Convert.ToInt32(Console.ReadLine());
                Console.Write("Hızı gir(km/h):");
                velocity = Convert.ToInt32(Console.ReadLine());
                return (way / velocity) + " saat";
            }
            else if (text == "Yol".ToUpper())
            {
                Console.Write("Zamanı gir(saat):");
                time = Convert.ToInt32(Console.ReadLine());
                Console.Write("Hızı gir(km/h):");
                velocity = Convert.ToInt32(Console.ReadLine());
                return (time * velocity) + " km";
            }
            else
            {
                Console.Clear();
                Console.WriteLine("hatalı seçim tekrar dene");
                return Velocity_Time_Way();

            }





        }
        static int Sum_()
        {
            int a, b;
            Console.Write("birinci sayıyı gir:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayıyı gir:");
            b = Convert.ToInt32(Console.ReadLine());
            return a + b;
        }
        static string ReturnText()
        {
            string message;
            Console.WriteLine("bir şeyler yaz:");
            message = Console.ReadLine();
            return message.ToUpper();
        }
        static string ReturnText(string text)
        {
            return text.ToUpper();
        }
        static void CylinderVolume()
        {
            double radius, height, result = 0;
            Console.Write("yarıçap uzunluğu gir:");
            radius = double.Parse(Console.ReadLine());
            Console.Write("yükseklik gir:");
            height = Convert.ToDouble(Console.ReadLine());
            result = Math.PI * Math.Pow(radius, 2) * height;
            result = Math.Round(result, 2);
            Console.WriteLine($"silindirin hacmi={result}");
        }
        static double Cylindervolume(double radius, double height)
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2) * height, 2);
        }
        static double ExponentOfNumber(double number, double power)
        {
            return Math.Pow(number, power);
        }
        static string EvenOrOdd(int number)
        {
            if (number < 0)
                return "0 dan küçük sayılarda teklik çiftlik olmaz";
            else
            {
                if (number % 2 == 1)
                    return "sayı tektir";
                else
                    return "sayı çifttir";
            }

        }
        static void EnterNumbers()
        {
            int num1, num2;
            Console.Write("birinci sayıyı gir:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayıyı gir:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Sum(num1, num2);
        }
        static void Sum(int number1, int number2)
        {
            Console.WriteLine(number1 + "+" + number2 + "=" + (number1 + number2));
        }
        static void WriteMessage(string text, int piece)
        {
            for (int i = 0; i < piece; i++)
            {
                Console.WriteLine(text);
            }
        }
        static void cube_volume()
        {
            double cube_side = 0, volume = 0;
            Console.Write("küpün kenar uzunluğunu girin:");
            cube_side = Convert.ToDouble(Console.ReadLine());
            volume = Math.Pow(cube_side, 3);
            volume = Math.Round(volume, 2);
            Console.WriteLine($"küpün hacmi={volume}");
        }
        static void calculator()
        {
            int number1, number2;
            char transactions;
            Console.WriteLine("----Hesap Makinesi----");
            while (true)
            {

                try
                {
                    Console.Write("birinci sayıyı gir:");
                    number1 = int.Parse(Console.ReadLine());
                    Console.Write("işlem('+' '-' '*' '/')?:");
                    transactions = char.Parse(Console.ReadLine());
                    Console.Write("ikinci sayıyı gir:");
                    number2 = int.Parse(Console.ReadLine());

                    switch (transactions)
                    {
                        case '+':
                            Console.WriteLine($"{number1}+{number2}={number1 + number2}");
                            break;
                        case '-':
                            Console.WriteLine($"{number1}+{number2}={number1 - number2}");
                            break;
                        case '*':
                            Console.WriteLine($"{number1}+{number2}={number1 * number2}");
                            break;
                        case '/':
                            Console.WriteLine($"{number1}+{number2}={number1 / number2}");
                            break;
                        default: Console.WriteLine("yanlış bir şeyler oldu"); break;

                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("Hata " + e.Message);
                    calculator();
                }
            }
        }
        static void fasterhorses()
        {
            int[] horses;
            int step = 0, limit = 0;
            int joker = 0;
            int bigger = int.MinValue;
            horses = new int[25];
            for (int i = 24; i > -1; i--)
            {
                horses[i] = i + 1;
            }
        loop:
            while (step < 21)
            {
                for (int i = step; i < step + 5; i++)
                {
                    if (horses[i] > bigger)
                    {
                        bigger = horses[i];
                        joker = i;
                    }
                }
                step += 5;
            }
            Console.WriteLine($"{bigger}");
            horses[joker] = 0;
            bigger = 0;
            limit++;
            step = 0;
            if (limit > 2)
                goto down;
            goto loop;
        down:;
        }
        static void Write()
        {
            Console.WriteLine("merhaba");
            Console.WriteLine("uğur");
        }
        static void Write(string text, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(text);
            }
        }
        static void Sum()
        {
            Console.Write("birinci sayı:");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayı:");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num_1}+{num_2}={num_1 + num_2}");
        }
        static void evenOrOdd()
        {
            int number;
            Console.Write("sayıyı gir:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("negatif sayıda teklik çiftlik olmaz");
                evenOrOdd();
            }
            else if (number % 2 == 0)
                Console.WriteLine("bu sayı çifttir");
            else
                Console.WriteLine("bu sayı tektir");
        }
        static void big_small_finder()
        {
            int[] array = new int[3];
            int big = int.MinValue;
            int small = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("sayı gir:");
                array[i] = Convert.ToInt32(Console.ReadLine());
                //if (array[i] > big)
                //    big = array[i];
                //if (array[i] < small)
                //    small = array[i];
            }
            Console.WriteLine($"en büyük sayı:{array.Max()}   "); //{big}
            Console.WriteLine($"en küçük sayı:{array.Min()}   ");//{small}
        }
    }
}
