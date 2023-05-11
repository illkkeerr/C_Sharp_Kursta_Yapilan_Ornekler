using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }//Cinsi
        public Gender Gender { get; set; }
        public abstract void Sound();
        //public void Sound()
        //{
        //    Console.WriteLine("değer");
        //}
        public Animal()
        {

        }
       
    }

    internal enum Gender
    {
        Unknown,
        Male,
        Female
    }
}
