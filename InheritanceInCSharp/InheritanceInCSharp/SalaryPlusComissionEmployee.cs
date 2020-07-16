using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    class SalaryPlusComissionEmployee : CommissionEmployee
    {
		private double _salary;

		public double Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}


		//public SalaryPlusComissionEmployee()
		//{
		//	Console.WriteLine("Child/Drive Class Called");
		//}


		//What base does is basically super(); from java
		//instead base(constructor parameters)
		public SalaryPlusComissionEmployee(int employeeId, string name, double grossSales, double commissionRate, double salary) : base(employeeId, name, grossSales, commissionRate)
		{

			Salary = salary;

			
		}


		public new double Earnings()		//this is polymorphism
		{
			return Salary + base.Earnings();
		}


		public override string ToString()
		{
			return base.ToString()+ $"\nSalary: {Salary:C}";
		}
	}
}
