using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDetailsExercise
{
    public partial class Form1 : Form
    {
        private Employee emp;
        public Form1()
        {
            emp = new Employee();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            emp.setEmpID(int.Parse(txtEmpID.Text));
            emp.SetName(txtName.Text);
            emp.SetSalary(double.Parse(txtSalary.Text));

            MessageBox.Show(emp.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
