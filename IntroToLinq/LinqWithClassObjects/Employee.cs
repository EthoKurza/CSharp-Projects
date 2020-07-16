using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithClassObjects
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

        public override string ToString()
        {
                            //-10 (alignment)
            return $"Name: {FirstName,-10} {LastName,-10} {Salary, 10:C}";
        }
    }
}
