using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Employeewaage
    {

        public const int Is_Fulltime = 1;
        public const int Is_Parttime = 2;
        public const int Is_Absent = 0;
        public int EmpDailywage = 0;
        public int Empwage = 20;

        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateEmpwage()
        {
            int Empworkinghours = 8;

            switch (IsEmployeePresent())
            {
                case Is_Fulltime:
                    Empworkinghours = 8;
                    break;
                case Is_Parttime:
                    Empworkinghours = 4;
                    break;
                case Is_Absent:
                    Empworkinghours = 0;
                    break;
            }
            EmpDailywage = Empworkinghours * Empwage;
            Console.WriteLine("Total Employee Wage =(0)", EmpDailywage);

        }
    }
}
