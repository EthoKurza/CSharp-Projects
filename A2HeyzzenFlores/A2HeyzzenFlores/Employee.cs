using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2HeyzzenFlores
{
    public abstract class Employee
    {
        public enum EmployeeType
        {
            HourlyEmployee, CommissionEmployee, SalariedEmployee
        }

        public String Name { get; private set; }

        public EmployeeType TypeOfEmployee { get; private set; }

        public double Tax { get { return GrossEarnings() * 0.2; ; } }

        public Double NetEarnings { get { return GrossEarnings() - Tax; } }

        //constructor
        public Employee(String name, EmployeeType empType)
        {
            Name = name;
            TypeOfEmployee = empType;
        }

        //methods
        public abstract Double GrossEarnings();

    }
}
