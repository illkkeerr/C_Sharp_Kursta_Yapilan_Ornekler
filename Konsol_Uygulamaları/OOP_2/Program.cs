using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
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

            var renault = new car("renault", "clio");
            renault.Yıl = 2028;
            var opel = new car() {
            Marka = "opel",
            model = "corsa"
            };
            renault.start();
            opel.start();
            Console.ReadLine();
        }
    }
}
