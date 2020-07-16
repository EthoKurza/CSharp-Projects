using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromForm1ToForm2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Employee emp = Form1.empInfo;
            txtFirstName.Text = emp.FirstName;
            txtLastName.Text = emp.LastName;
            txtSalary.Text = emp.Salary.ToString("C");
        }
    }
}
