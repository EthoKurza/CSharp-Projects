using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithClassObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Jason","Red", 3000),
                new Employee("Wendy","Indigo", 5000),
                new Employee("Matthew","Indigo", 2000),
                new Employee("James","Brown", 7000),
                new Employee("Pam","Indigo", 4000),
                new Employee("Lucas","Green", 6000),
                new Employee("Mike","Brown", 5500)

            };

            foreach (var e in employees)
                Console.WriteLine(e.ToString());


            //Employees between 4000 and 6000
            var between4k6k = from emp in employees
                              where emp.Salary >= 4000 && emp.Salary <= 6000
                              select emp;

            

            if (between4k6k.Any())
            {
                Console.WriteLine("\n\nEmployees between 4k and 6k");
                foreach (var e in between4k6k)      //theres a .first() , .last() which only gets either the first/last record
                    Console.WriteLine(e.ToString());
            }
            else
            {
                Console.WriteLine("No records fetched");
            }

            //sort employees by lastname
            var sorted = from emp in employees
                         orderby emp.LastName, emp.FirstName        //if emp.lastname is the same then sort by first name
                         select emp;

            Console.WriteLine("\n\nEmployees ordered by last name");
            foreach (var e in sorted)
                Console.WriteLine(e.ToString());

            //fetch only lastnames
            var lastnames = from emp in employees
                            select emp.LastName;

            Console.WriteLine("\n\nEmployees last name");
            foreach (var e in lastnames.Distinct())     //will only get disticnt(unique) last names
                Console.WriteLine(e.ToString());


            //create a new employee object
            var empFullNmaes = from emp in employees
                               select new {  emp.FirstName, Last = emp.LastName };

            Console.WriteLine("\n\nNew Employee object");
            foreach (var e in empFullNmaes)
                Console.WriteLine(e.ToString());

        }
    }
}
