using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExampleWeek4
{
    public class CommissionEmployee : Employee
    {

        //propg
        public double GrossSales { get; private set; }
        public double CommissionRate { get; private set; }

        //constructor
        public CommissionEmployee(int id, String name, EmployeeType empType, double grossSales, double commissionRate) : base(id, name, empType)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        //methods
        public override double Earnings()
        {
            return GrossSales * CommissionRate;
        }

        public override string ToString()
        {
            return $"Commission Employee: \n\n{base.ToString()}Gross Sale: {GrossSales:C}\nCommission Rate: {CommissionRate:P}";
        }
    }
}
