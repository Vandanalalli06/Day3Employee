using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Employeewaage
    {

        public int EmpPresent = 1;
        public int Fulltime = 1;
        public int Wage_Per_Hour = 20;
        public int Fullday_Hour = 8;
        public int Parttimeday_Hour = 4;
        public int Dailywage = 0;
        public void CheckParttimeEmpwage()
        {
            Random Empcheck = new Random();
            int value = Empcheck.Next(0, 2);
            if (value == EmpPresent)
            {
                Random Timecheck = new Random();
                int WorkingHours = Timecheck.Next(0, 2);
                if (WorkingHours == Fulltime)
                {
                    Dailywage = Fullday_Hour * Wage_Per_Hour;
                    Console.WriteLine("Employee is present in full time and Dailywage={0)", Dailywage);
                }
                else
                {
                    Dailywage -= Parttimeday_Hour * Wage_Per_Hour;
                    Console.WriteLine("Employee is present in part time and Dailywage={0)", Dailywage);
                }
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

    }
}
