using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2HeyzzenFlores
{
    class HourlyEmployee : Employee
    {

        public int HoursWorked { get; private set; }

        public Double HourlyWage { get; private set; }


        //constructor
        public HourlyEmployee(int hours, double wage, String name, EmployeeType empType) : base(name, empType)
        {
            HoursWorked = hours;
            HourlyWage = wage;
        }

        //methods
        public override double GrossEarnings()
        {
            if (HoursWorked <= 40)
                return HoursWorked * HourlyWage;
            else
                return (HourlyWage * 40) + (HoursWorked - 40) * HourlyWage * 1.5;
        }


    }
}
