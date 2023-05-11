using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quiz_
{
    internal class Question
    {
        public byte No { get; set; }
        public string Question_Text { get; set; }
        public List<string> Question_Choices { get; set; } = new List<string>();
        public List<string> True_Answers { get; set; }

        public Question()
        {

        }
        public Question(byte no, string question_text, List<string> question_choices, List<string> true_answers)
        {
            this.No = no;
            this.Question_Text = question_text;
            this.Question_Choices = question_choices;
            this.True_Answers = true_answers;
        }

        public bool isTrue(string answer)
        {
            if (this.True_Answers.Contains(answer)) return true;
            else return false;
        }
    }
}
