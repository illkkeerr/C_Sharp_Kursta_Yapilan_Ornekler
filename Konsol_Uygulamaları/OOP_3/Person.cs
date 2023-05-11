using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class Person
    {
        public string Name { get; set; }
        private string surname;
        public string Surname { get => surname.ToUpper(); set => surname = value; }
        private int birthYear;
        public int BirthYear { get => birthYear;
            set 
            { 
                if(value > DateTime.Now.Year)
                    birthYear = 2023;
                else if (value < 1900)
                    birthYear = 1900;
                else
                    birthYear= value;
            } 
        }
        public Person()
        {

        }
        public Person(string a,string s,int y)
        {
            Name= a;
            Surname= s;
            BirthYear= y;
        }
        private int AgeCalculate()
        {
            return DateTime.Now.Year-this.BirthYear;
        }

        public void AgePrint()
        {
            Console.WriteLine($"yaş : {AgeCalculate()}");
        }
      
    }
}
