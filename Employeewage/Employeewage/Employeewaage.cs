using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Employeewaage
    {

        public int Emppresent = 1;
        public int FullTime = 1;
        public int wage_per_hour = 20;
        public int Full_day_hour = 8;
        public int PartTime_Day_Hour = 4;
        public int Dailywage = 0;
        public void CheckEmppresentabsent()
        {
            Random Empcheck = new Random(); //Random=class Empcheck=object
            int Value = Empcheck.Next(0, 2); //Next=method
            if (Value == Emppresent)
            {
                Random Timecheck = new Random();
                int workingHours = Timecheck.Next(0, 2);
                if (Value == Emppresent)
                {
                    Dailywage = wage_per_hour * Full_day_hour;
                    Console.WriteLine("Employee is present and his wage is* " + Dailywage);
                }
                else
                {
                    Dailywage = wage_per_hour * PartTime_Day_Hour;
                    Console.WriteLine("Employee is present for Parttime* " + Dailywage);
                }
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
