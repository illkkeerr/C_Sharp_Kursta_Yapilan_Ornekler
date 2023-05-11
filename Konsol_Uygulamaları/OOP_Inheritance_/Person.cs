using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_
{
    internal class Person
    {
        public short Id { get; set; }
        private string name;
        public string Name { get => name; set => name = value.ToUpper(); }

        private string surname;
        public string Surname { get => surname; set => surname = value.ToUpper(); }
        public EnumGender Gender { get; set; }
        

        public Person()
        {

        }
        public Person(string name, string surname)
        {

            Name = name;
            Surname = surname;
        }
        public Person(short id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }
        public Person(short id, string name, string surname, EnumGender gender)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;

        }

    }
    public enum EnumGender
    {
        Male,
        Female,
        Unknown
    }
   
}
