using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9_Example_2
{
    internal class Person : IEntity
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SurName { get; set; };

    }
}
