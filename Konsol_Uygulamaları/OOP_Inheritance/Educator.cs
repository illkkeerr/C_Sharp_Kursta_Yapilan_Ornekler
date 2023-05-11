using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Educator:Person
    {
       
        public Educator(int id, string name, string surname):base(id,name,surname)
        {
        }
        public Educator():base()
        {

        }
        public void KursOlustur()
        {
            Console.WriteLine("Kurs Oluşturuldu");
        }
    }
}
