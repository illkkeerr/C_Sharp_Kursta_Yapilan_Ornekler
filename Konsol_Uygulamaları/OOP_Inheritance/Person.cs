using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EnumGender Gender { get; set; }
        public Person()
        {

        }
        public Person(int id, string name, string surname)
        {
            Id= id;
            Name= name;
            Surname= surname;
        }
    }

    public enum EnumGender
    {
        UnKnow,
        Male,
        Female
    }
}
