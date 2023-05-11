using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9_Example
{
    internal class Worker:Person
    {
        public double Maas { get; set; }
        public Worker():base()
        {

        }

        public Worker(string name,string surname,double maas):base(name,surname)
        {
            this.Maas = maas;
        }
    }
}
