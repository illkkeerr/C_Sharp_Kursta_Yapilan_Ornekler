using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_
{
    internal class Person
    {
        private string name;
        public string Name { get => name; set => name = value.ToUpper(); }
        private string surname;
        public string SurName { get => surname; set => surname = value.ToUpper(); }
        private int birtyear;
        public int BirtYear
        {
            get => birtyear; set
            {
                if (value > DateTime.Now.Year)
                {
                    birtyear = DateTime.Now.Year;
                }
                else if (value < 1900)
                {
                    birtyear = 1900;
                }
                else
                {
                    birtyear = value;
                }
            }
        }//Birtday
        public Person()
        {

        }
        public Person(string name, string surname, int birtyear)
        {
            this.Name = name;
            this.SurName = surname;
            this.BirtYear = birtyear;
        }

        private int AgeCalculator()
        {
            return DateTime.Now.Year - this.BirtYear;
        }

        public void AgePrint()
        {
            Console.WriteLine($"yaş:{AgeCalculator()}");
        }
    }
}
