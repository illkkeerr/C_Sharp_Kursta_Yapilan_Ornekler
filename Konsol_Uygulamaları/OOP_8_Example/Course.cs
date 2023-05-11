using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8_Example
{
    internal class Course
    {
        private string name;//Ctrl+R+E

        public string Name
        {
            get => name.ToUpper(); set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException();
                }
                else
                    name = value;
            }


        }
        public int TotalHour { get; set; }
        public int WeeklyHour { get; set; }
        private DateTime startDate;

        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if (value.AddMinutes(2) <= DateTime.Now)
                    throw new ArgumentException();
                else
                    startDate = value;
            }
        }

        public DateTime EndDate { get; set; }
        public List<Student> Students { get; set; }

        public Educator Educator { get; set; }

        public Course()
        {
            Students = new List<Student>();
            this.EndDate = EndDateCalculate();

        }
        public Course(string name, int totalHour, int weeklyHour, DateTime StartDate)
        {

            this.Name = name;
            this.TotalHour = totalHour;
            this.WeeklyHour = weeklyHour;
            this.startDate = StartDate;
            Students = new List<Student>();
            this.EndDate = EndDateCalculate();
        }

        private DateTime EndDateCalculate()
        {
            int day = (this.TotalHour / this.WeeklyHour) * 7;
            return this.StartDate.AddDays(day);
        }
    }
}
