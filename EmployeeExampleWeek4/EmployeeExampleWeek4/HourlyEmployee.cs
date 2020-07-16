using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExampleWeek4
{
    public class HourlyEmployee : Employee
    {
        //propg
        public int NumHours { get; private set; }

        public double Wage { get; private set; }


        //constructor
        public HourlyEmployee(int id, String name, EmployeeType empType, int hours, double wage) : base(id, name, empType)
        {
            NumHours = hours;
            Wage = wage;
        }

        //methods
        public override double Earnings()
        {
            if (NumHours <= 40)
                return NumHours * Wage;
            else
                return (40 * Wage)+(NumHours-40) * Wage * 1.5;
        }

        public override string ToString()
        {
            return $"Hourly Employee: \n\n{base.ToString()}Hours: {NumHours}\nWage: {Wage}";
        }

    }
}
