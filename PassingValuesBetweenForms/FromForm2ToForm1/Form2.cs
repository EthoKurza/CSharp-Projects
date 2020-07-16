using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromForm2ToForm1
{
    public partial class Form2 : Form
    {
        public static Employee EmployeeInfo { get; set; }
        public Form2()
        {
            InitializeComponent();
            EmployeeInfo = new Employee();
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Salary = double.Parse(txtSalary.Text);

            EmployeeInfo = emp;

            Close();

        }
    }
}
