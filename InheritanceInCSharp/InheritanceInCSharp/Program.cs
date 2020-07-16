using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CommissionEmployee ce = new CommissionEmployee();
            //SalaryPlusComissionEmployee sce = new SalaryPlusComissionEmployee();

            CommissionEmployee commEmp = new CommissionEmployee(101,"John",10000,0.12);
            //Console.WriteLine(commEmp.ToString());
            Console.WriteLine(commEmp);
            Console.WriteLine($"\nEarnings: {commEmp.Earnings():C}");


            Console.WriteLine("\n");

            SalaryPlusComissionEmployee salCommEmp = new SalaryPlusComissionEmployee(102, "Anna", 10000, 0.08, 500);
            Console.WriteLine(salCommEmp);
            Console.WriteLine($"Earnings: {salCommEmp.Earnings():C}");


        }
    }
}
