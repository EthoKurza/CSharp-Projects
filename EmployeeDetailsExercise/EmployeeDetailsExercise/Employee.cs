using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetailsExercise
{  
    class Employee
    {
        //fields or variables
        private int _empID;
        private String _empName;
        private double _salary;


        ////constructor
        //public Employee()
        //{
        //    _empID = 1;
        //    _empName = "";
        //    _salary = 100;
        //}

        //public Employee(int id, String name, int salary)
        //{
        //    _empID = id;
        //    _empName = name;
        //    _salary = salary;
        //}

        //methods
        public void setEmpID(int id)
        {
            if (id < 0)
                throw new Exception("Employee id cannot be less than 1");

            _empID = id;
        }

        public int getEmpID()
        {

            return _empID;
        }


        public void SetName(String name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name cannot be null or empty");
           
            _empName = name;
        }

        public String GetName()
        {
            return _empName;
        }


        public void SetSalary(double sal)
        {
            if (sal < 100 || sal > 10000)
                throw new Exception("Salary must be within 100 and 10000");
            _salary = sal;
        }
        public double GetSalary()
        {
            return _salary;
        }

        public override string ToString()
        {
            return $"Employee Id: {_empID} \nEmployee Name: {_empName}\n Salary: {_salary:C}";      //the _salary:C means it will convert the salary to type of currency
        }

    }
}
