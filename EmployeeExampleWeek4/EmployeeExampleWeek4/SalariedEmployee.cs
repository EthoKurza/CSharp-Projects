using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExampleWeek4
{
    public class SalariedEmployee : Employee
    {
        //propg
        public double Salary { get; private set; }

        //constructor
        public SalariedEmployee(int id, String name, EmployeeType empType, double salary) : base(id,name,empType)
        {
            Salary = salary;
        }

        //methods
        public override double Earnings()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"Salaried Employee: \n\n{base.ToString()}Salary: {Salary:C}";
        }

    }
}
