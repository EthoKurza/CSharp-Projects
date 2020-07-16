using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithWindowsForms
{
    class Employee
    {
        //properties
        public String FirstName { get; private set; }
        public String LastName { get; private set; }

        public double Salary { get; private set; }

        //constructor
        public Employee(string fname, string lname, double salary)
        {
            FirstName = fname;
            LastName = lname;
            Salary = salary;
        }
    }
}
