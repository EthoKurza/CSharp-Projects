using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeWithProperties
{
    public partial class Form1 : Form
    {
        private Employee emp;
        public Form1()
        {
            InitializeComponent();
            emp = new Employee();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            emp.EmployeeID = int.Parse(txtEmpID.Text);
            emp.Name = txtName.Text;
            emp.Salary = double.Parse(txtSalary.Text);

            MessageBox.Show(emp.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
