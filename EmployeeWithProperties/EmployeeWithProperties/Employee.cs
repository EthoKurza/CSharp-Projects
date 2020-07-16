using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWithProperties
{
    class Employee
    {
        //fields & properties

        //auto impletment type prop and hit tab twice
        //public String Name { get; set; }

        private int _empID;

        public int EmployeeID
        {
            get { return _empID; }
            set {
                if(value < 1)
                {
                    throw new Exception("Employee ID cannot be less than 1");
                }
                _empID = value; 
            }
        }

        private String _empName;

        public String Name
        {
            get { return _empName; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name cannot be null/empty!");        
                _empName = value; }
        }

        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set {
                if (value < 100 || value > 10000)
                    throw new Exception("Salary must be within 100 and 10000");
                _salary = value; }
        }

        public override string ToString()
        {
            return $"Employee Id: {_empID} \nEmployee Name: {_empName}\n Salary: {_salary:C}";      //the _salary:C means it will convert the salary to type of currency
        }



    }
}
