using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    class CommissionEmployee
    {
		//property variables
		private int _employeeId;

		public int EmployeeID
		{
			get { return _employeeId; }
			set { _employeeId = value; }
		}

		private String _name;

		public String Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private double _grossSales;

		public double GrossSales
		{
			get { return _grossSales; }
			set {
				if(value < 0)
					throw new Exception("Gross sales cannot be negative");

				_grossSales = value; 
			}
		}

		private double _commissionRate;

		public double CommissionRate
		{
			get { return _commissionRate; }
			set {
				if ((value < 0.0) || value > 1.0)
					throw new Exception("Commission rate cannot be less than 0 or greater than 1");

				_commissionRate = value; 
			}
		}

		//public CommissionEmployee()
		//{
		//	Console.WriteLine("Base Class called");
		//}

		public CommissionEmployee(int employeeId, string name, double grossSales, double commissionRate)
		{
			//assigned the values on the properties
				//this is better because we have set constraints in the properties above
			EmployeeID = employeeId;
			Name = name;
			GrossSales = grossSales;
			CommissionRate = commissionRate; 
		}


		public double Earnings()
		{
			return GrossSales * CommissionRate;
		}

		public override string ToString()
		{
			return $"Employee Id:{EmployeeID}\nName is {Name}\nGross Sales is {GrossSales:C}\nCommission Rate: {CommissionRate:P}";
		}

	}
}
