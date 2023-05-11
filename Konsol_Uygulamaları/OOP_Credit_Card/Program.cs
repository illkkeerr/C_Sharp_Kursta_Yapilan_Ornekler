using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Credit_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreditCard card = new CreditCard("1234567890123456", "5678", new DateTime(2025, 12, 05));
            //card = null;
            Console.WriteLine("Kart numarası:" + card.CardNo);
            Console.WriteLine("Cvv numarası:" + card.CVV);
            Console.WriteLine("Son kullanma tarihi:" + card.LastDate);

            Console.ReadLine();

        }
    }
}
