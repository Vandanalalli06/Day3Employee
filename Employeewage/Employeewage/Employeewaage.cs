using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Employeewaage
    {
        
            public int Is_EmpPresent = 1;
            public int Wage_Per_Hour = 20;
            public int Fullday_Hour = 8;
            public int Dailywage = 0;
            public void CheckDailyEmpwage()
            {
                Random Empcheck = new Random();
                int value = Empcheck.Next(0, 2);
                if (value == Is_EmpPresent)
                {
                    Dailywage = Fullday_Hour * Wage_Per_Hour;
                    Console.WriteLine("Employee is present and Dailywage={0)", Dailywage);
                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                }
            }
        
    }
}
