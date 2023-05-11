using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quiz_
{
    internal static class Question_Manager
    {
        public static List<Question> Questions = new List<Question>();

        static Question_Manager()
        {
            Questions = new List<Question>()
            {
                new Question(1,"-10. Osmanlı padişahı hangi sultandır?",
                new List<string>(){"A-Kanuni Sultan Süleyman","B-Yavuz Sultan Selim","C-Çelebi Mehmet","D-Fatih Sultan Mehmet" },
                new List<string>(){"A","KANUNİ SULTAN SÜLEYMAN"}) ,

                new Question(2,"-ABD'nin başkenti hangi şehirdir?",
                new List<string>(){"A-New York","B-Londra","C-Washington","D-Dallas" },
                new List<string>(){"C","WASHİNGTON"}) ,

                new Question(3,"-Aşağıdaki ülkelerden hangisi Türkiye'nin kara komşusudur?",
                new List<string>(){"A-ABD","B-Almanya","C-KKTC","D-Gürcistan" },
                new List<string>(){"D","GÜRCİSTAN"}) ,
            };
        }

        public static void DisplayQuestion()
        {
            string answer;
            short point = 0;
            byte true_pieces = 0, wrong_pieces = 0;
            byte choose;
            Console.WriteLine("bilgi yarışmamıza hoşgeldiniz");
            Console.WriteLine($"toplam {Questions.Count} soru var");
            Console.WriteLine("doğru yapılan her soru 10 puan yanlış yapılan sorular -5 puan olacak ");
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"{Questions[i].No}{Questions[i].Question_Text}");
                Questions[i].Question_Choices.ForEach(choice => Console.Write(choice + " "));
                Console.Write("\ndoğru cevabı yazın:");
                answer = Console.ReadLine();
                if (Questions[i].True_Answers.Contains(answer.ToUpper()))
                {
                    Console.WriteLine("doğru cevap 10 puan kazandınız");
                    point += 10;
                    true_pieces++;
                }
                else
                {
                    Console.WriteLine("yanlış cevap 5 puan kaybettiniz");
                    point -= 5;
                    wrong_pieces++;
                }
            }
            Console.WriteLine($"yarışma bitti. Doğru sayısı={true_pieces} yanlış sayısı={wrong_pieces}");
            Console.WriteLine($"toplam puan={point}");
            Console.Write("tekrar testi çözmek isterseniz 1'e çıkış yapmak için 2'ye basın:");
            choose = Convert.ToByte(Console.ReadLine());
            if (choose == 1)
                DisplayQuestion();
            else
            {
                Console.WriteLine("çıkış yapılıyor.......");
                System.Threading.Thread.Sleep(1350);
                Environment.Exit(0);
            }

        }

    }
}
