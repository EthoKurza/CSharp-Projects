using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExampleWeek4
{
    //if no type is declared its internal, not public/private/protected
    public enum EmployeeType
    {
        SalariedEmployee, HourlyEmployee, CommissionEmployee, SalariedPlusCommissionEmployee
    }
    public abstract class Employee
    {
        public int Id { get; private set; }
        public String Name { get; private set; }

        public EmployeeType TypeOfEmployee { get; private set; }

        public Employee(int id, String name, EmployeeType empType)
        {
            Id = id;
            Name = name;
            TypeOfEmployee = empType;
        }

        //we use abstract because we dont know what type of employee this is
        public abstract double Earnings();

        public override string ToString()
        {
            return $"Name: {Name}\nID: {Id}\nType of Employee: {TypeOfEmployee}\n";
        }
    }
}
