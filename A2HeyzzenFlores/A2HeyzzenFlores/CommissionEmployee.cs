using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2HeyzzenFlores
{
    class CommissionEmployee : Employee
    {
        public Double GrossSales { get; private set; }

        public Double CommissionRate { get; private set; }

        public CommissionEmployee(Double grossSales, Double commissionRate, String name, EmployeeType empType) : base(name, empType)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate/100;
        }

        public override double GrossEarnings()
        {
            return GrossSales * CommissionRate;
        }
    }
}
