using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2HeyzzenFlores
{
    class SalariedEmployee : Employee
    {
        public Double WeeklySalary { get; private set; }

        public SalariedEmployee(Double salary, String name, EmployeeType empType) : base(name, empType)
        {
            WeeklySalary = salary;
        }

        //method
        public override double GrossEarnings()
        {
            return WeeklySalary;
        }
    }
}
