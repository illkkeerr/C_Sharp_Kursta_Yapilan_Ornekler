using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2_
{
    internal class car
    {
        //Encapculation
        //Ctrl+R+E
        private string brand;
        public string Brand { get => brand; set => brand = value.ToUpper(); }

        private string model;
        public string Model { get => model; set => model = value.ToUpper(); }

        public string Color { get; set; }
        public bool IsAuto { get; set; }
        private int year;
        public int Year
        {
            get => year; set
            {
                if (value > DateTime.Now.Year) year = DateTime.Now.Year - 1;
                else if (value < 1990) year = 1990;
                else value = year;

            }

        }

        public car()
        {

        }
        public car(string brand, string model, string color, bool isAuto, int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.IsAuto = isAuto;
            this.Year = year;
        }

        public void start()
        {
            Console.WriteLine($"{this.Year} {this.Model} model {this.Brand} çalıştırıldı");
        }

        public bool isAuto()
        {
            if (this.IsAuto) return true;
            else return false;
        }
    }
}
