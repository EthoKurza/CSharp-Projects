using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqWithWindowsForms
{
    public partial class Form1 : Form
    {
        private List<Employee> employees;

        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>
            {
                new Employee("Jason","Red", 3000),
                new Employee("Wendy","Indigo", 5000),
                new Employee("Matthew","Indigo", 2000),
                new Employee("James","Brown", 7000),
                new Employee("Pam","Indigo", 4000),
                new Employee("Lucas","Green", 6000),
                new Employee("Mike","Brown", 5500)

            };
        }

        private void btnShowAllEmployees_Click(object sender, EventArgs e)
        {
            var allEmps = from emp in employees
                          select emp;
            DisplayEmployees(allEmps);

        }

        private void btnEmployeesBetween4k6l_Click(object sender, EventArgs e)
        {
            var betweek4k6k = from emp in employees
                              where emp.Salary >= 4000 && emp.Salary <= 6000
                              select emp;


            DisplayEmployees(betweek4k6k);

        }

        private void btnSortEmployeesByLastName_Click(object sender, EventArgs e)
        {
            var sortedLastname = from emp in employees
                                orderby emp.LastName, emp.FirstName
                                 select emp;

            DisplayEmployees(sortedLastname);
        }

        private void DisplayEmployees(IEnumerable<Employee> emps )
        {
            lblFirstName.Text = lblLastName.Text = lblSalary.Text = "";
            foreach (var emp in emps)
            {
                lblFirstName.Text += emp.FirstName + "\n";
                lblLastName.Text += emp.LastName + "\n";
                lblSalary.Text += emp.Salary.ToString("C") + "\n";
            }
        }
    }
}
