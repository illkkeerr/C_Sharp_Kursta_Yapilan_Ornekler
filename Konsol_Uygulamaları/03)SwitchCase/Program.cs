using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region haftanın günleri
            ////switch-case haftanın günleri
            //byte weekdays;
            //Console.Write("haftanın kaçıncı gününü öğrenmek istiyorsunuz:");
            //weekdays = Convert.ToByte(Console.ReadLine());
            //switch (weekdays)
            //{
            //    case 1:
            //        Console.WriteLine("pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("pazar");
            //        break;
            //    default:
            //        Console.WriteLine("yanlış değer girdiniz.");
            //        break;
            //}
            #endregion
            #region switch-case hesap makinesi
            //    //kullanıcı işlem seçsin hesap makinesi
            //    double number1, number2;
            //    char operations;

            //    Console.WriteLine("Hesap makinesi 4 işlem");
            //    Console.Write("toplama için:'+'\nçarpma için:'*'\nbölme için:'/'\nçıkarma için:'-' ");
            //go:
            //    Console.Write("tuşuna basınız:");
            //    operations = Convert.ToChar(Console.ReadLine());
            //    Console.Write("birinci sayıyı giriniz:");
            //    number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("ikinci sayıyı giriniz:");
            //    number2 = Convert.ToInt32(Console.ReadLine());
            //    if (operations == '/' && number2 == 0)
            //        Console.WriteLine("0'a bölme işlemi yapılmaz");
            //    else
            //    {
            //        switch (operations)
            //        {
            //            case '+':
            //                Console.WriteLine($"toplam={number1 + number2}");
            //                break;
            //            case '-':
            //                Console.WriteLine($"fark={number1 - number2}");
            //                break;
            //            case '*':
            //                Console.WriteLine($"çarpım={number1 * number2}");
            //                break;
            //            case '/':
            //                Console.WriteLine($"bölüm={number1 / number2}");
            //                break;
            //            default:
            //                Console.WriteLine("yanlış seçim");
            //                break;
            //        }
            //    }
            //    goto go;
            #endregion
            #region trafik ışığı
            //    string orders;
            //go:
            //    Console.Write("hangi ışık yanıyor:");
            //    orders = Console.ReadLine();
            //    if (orders.ToLower() == "kırmızı")
            //        Console.WriteLine("dur duruyorsan bekle");
            //    else if (orders.ToLower() == "yeşil")
            //        Console.WriteLine("geç");
            //    else if (orders.ToLower() == "sarı")
            //        Console.WriteLine("hazırlan");
            //    else
            //        Console.WriteLine("yazılan cevap anlaşılamadı");
            //    goto go;         
            #endregion

            Console.ReadLine();
        }
    }
}
