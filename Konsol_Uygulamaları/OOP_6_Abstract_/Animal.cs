using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6_Abstract_
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public EnumGender Gender { get; set; }
        public Animal()
        {

        }
        public abstract void Sound();

    }
    enum EnumGender
    {
        Male,
        Female
    }
}
