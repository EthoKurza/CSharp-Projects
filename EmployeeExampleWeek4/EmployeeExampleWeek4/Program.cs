using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExampleWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            //SalariedEmployee salEmp = new SalariedEmployee(101, "John", EmployeeType.SalariedEmployee, 800.0);
            //CommissionEmployee comEmp = new CommissionEmployee(103, "Mark", EmployeeType.CommissionEmployee, 10000, 0.08);
            //HourlyEmployee hrEmp = new HourlyEmployee(102, "Anna", EmployeeType.HourlyEmployee, 50, 15.0);

            //Console.WriteLine(salEmp+"\n");
            //Console.WriteLine($"Earnings: {salEmp.Earnings().ToString("C")}\n\n");


            //Console.WriteLine(hrEmp + "\n");
            //Console.WriteLine($"Earnings: {hrEmp.Earnings().ToString("C")}\n\n");


            //Console.WriteLine(comEmp + "\n");
            //Console.WriteLine($"Earnings: {comEmp.Earnings().ToString("C")}\n\n");


            /** 
             * Polymorphism
             */
            //variable has to be type parent class
            //Employee emp = new SalariedEmployee(101, "John", EmployeeType.SalariedEmployee, 800.0);
            //Console.WriteLine(emp);
            //Console.WriteLine($"Earnings: {emp.Earnings().ToString("C")}\n\n");

            //emp = new HourlyEmployee(102, "Anna", EmployeeType.HourlyEmployee, 50, 15.0);
            //Console.WriteLine(emp);
            //Console.WriteLine($"Earnings: {emp.Earnings().ToString("C")}\n\n");

            //emp = new CommissionEmployee(103, "Mark", EmployeeType.CommissionEmployee, 10000, 0.08);
            //Console.WriteLine(emp);
            //Console.WriteLine($"Earnings: {emp.Earnings().ToString("C")}\n\n");



            /**
             *          ---Using Arrays---
             */

            Employee[] employees = new Employee[3];
            employees[0] = new SalariedEmployee(101, "John", EmployeeType.SalariedEmployee, 800.0);
            employees[1] = new HourlyEmployee(102, "Anna", EmployeeType.HourlyEmployee, 50, 15.0);
            employees[2] = new CommissionEmployee(103, "Mark", EmployeeType.CommissionEmployee, 10000, 0.08);


            foreach(Employee emp in employees){
                Console.WriteLine(emp);
                Console.WriteLine($"Earnings: {emp.Earnings().ToString("C")}\n\n");
            }
        }
    }
}
