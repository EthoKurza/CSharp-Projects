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
    public partial class Form1 : Form
    {
        //public static Employee empInfo { get; set; }      //two ways to fix this error, declare class to public or set this to internam

        public static Employee empInfo { get; set; }        //class set to public

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            //go to form 2
            //Form2 form2 = new Form2();
            //form2.Show();
            //form2.ShowDialog();         //this prevents the user to go back to the other form
            
            //set values into of type employee
            Employee emp = new Employee();

            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Salary = double.Parse(txtSalary.Text);

            empInfo = emp;

            //go to form 2
            Form2 form2 = new Form2();
            form2.Show();
            //form2.ShowDialog();         //this prevents the user to go back to the other form
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
