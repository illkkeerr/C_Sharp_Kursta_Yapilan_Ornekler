using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quiz_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question question = new Question(1, "-10. Osmanlı padişahı hangi sultandır?",
               new List<string>() { "A-Kanuni Sultan Süleyman", "B-Yavuz Sultan Selim", "C-Çelebi Mehmet", "D-Fatih Sultan Mehmet" },
               new List<string>() { "A", "KANUNİ SULTAN SÜLEYMAN" });
            string return_ = question.isTrue("KANUNİ SULTAN SÜLEYMAN").ToString();
            Console.WriteLine(return_);

            Question_Manager.DisplayQuestion();

            Console.ReadLine();
        }
    }
}
