using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9_Example
{
    internal class Person : IEntity
    {
        public string Name { get; set; }//
        public string SurName { get; set; }
        

        public Person()
        {

        }

        public Person(string name,string surname)
        {
            this.Name = name;
            this.SurName = surname;

        }
    }
}
