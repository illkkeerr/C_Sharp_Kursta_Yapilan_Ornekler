using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class car
    {
        //Encapculation
        //Ctrl+R+E
        private string marka;
        public string Marka { get => marka.ToUpper(); set => marka = value; }
        public string model { get; set; }

        public string renk { get; set; }
        public bool isauto { get; set; }
      
        private int yıl;
        public int Yıl { get => yıl; 
            set 
            {
                if (value > DateTime.Now.Year)
                    yıl = 2022;
                else if (value < 1990)
                    yıl = 1990;
                else
                    yıl = value;
            } 
        }



        public car()
        {

        }
        public car(string marka , string model)
        {
            this.Marka = marka;
            this.model = model; 
        }
        public void start()
        {
            Console.WriteLine($"{this.Marka} {this.model} {this.yıl} araç çalıştırıldı" );
        }
    }
}
