using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Car class
             * 
             Property 
                brand
                model
                color
                isAuto
                yılı
            Metotları
                start()
                    reno clio çalıştırıldı
                Stop()
                SpeedUp
                SLow

            //Main
            iki araç nesnesi üretin ve metotları çağırın
             */
            bool value;
            var renault = new car("Renault", "Megane", "Kırmızı", true, 1880);
            car mercedes = new car("Mercedes", "benZ", "beyaz", false, 2026);

            Console.WriteLine("oto mu manuel mi sorgu metodu");
            value = renault.isAuto();
            Console.WriteLine(value);
            value = mercedes.isAuto();
            Console.WriteLine(value);
            Console.WriteLine("araba start metodu");
            renault.start();
            mercedes.start();

            car opel = new car()
            {
                Brand = "opel",
                //Model = "corsa"
            };
            opel.Year = 1222;

            opel.start();



            Console.ReadLine();

        }
    }
}
