using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2HeyzzenFlores
{
    public partial class Form1 : Form
    {
        private List<Employee> empList;
        private HourlyEmployee hEmp;
        private CommissionEmployee cEmp;
        private SalariedEmployee sEmp;


        public Form1()
        {
            InitializeComponent();
            empList = new List<Employee>();
            cmbEmployee.Items.Insert(0, "");
            cmbEmployee.SelectedIndex = 0;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset Textboxes
            txtEmpInfo2.Text = "";
            txtEmpInfo3.Text = "";
            txtEmpName.Text = "";
            txtGrossEanings.Text = "";
            txtLessTax.Text = "";
            txtNetEarnings.Text = "";

            //reset combo box
            cmbEmployee.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //check if inputs are valid
            if (validInput())
            {
                createEmployee();
            }

        }

        private void rbtnHourly_CheckedChanged(object sender, EventArgs e)
        {
            lblEmpInfo2.Text = "Hours Worked:";
            lblEmpInfo3.Text = "Hourly Wage:";

            //Display labels and textboxes
            lblEmpInfo3.Visible = true;
            txtEmpInfo2.Visible = true;
            txtEmpInfo3.Visible = true;

            btnClear_Click(sender, e);      //clear textboxes
        }//end of rbtnHourly

        private void rbtnCommission_CheckedChanged(object sender, EventArgs e)
        {
            lblEmpInfo2.Text = "Gross Sales: ";
            lblEmpInfo3.Text = "Commission Rate: ";

            //Display labels and textboxes
            lblEmpInfo3.Visible = true;
            txtEmpInfo2.Visible = true;
            txtEmpInfo3.Visible = true;

            btnClear_Click(sender, e);       //clear textboxes  
        }//end of rbtnCommission

        private void rbtnWeekly_CheckedChanged(object sender, EventArgs e)
        {
            lblEmpInfo2.Text = "Salary: ";

            //Display/Hide labels and textboxes
            lblEmpInfo3.Visible = false;
            txtEmpInfo3.Visible = false;

            btnClear_Click(sender, e);      //clear textboxes
        }//end of rbtnWeekly

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEmployee.SelectedIndex != 0)
            {
                int empIndex = (cmbEmployee.SelectedIndex-1);

                if (empList[empIndex].TypeOfEmployee == Employee.EmployeeType.HourlyEmployee)
                {
                    //update labels
                    rbtnHourly.Checked = true;
                    lblEmpInfo2.Text = "Hours Worked:";
                    lblEmpInfo3.Text = "Hourly Wage:";

                    txtEmpInfo2.Visible = true;
                    txtEmpInfo3.Visible = true;

                    hEmp = (HourlyEmployee)empList[empIndex];

                    //Display Calculated Wages
                    txtEmpName.Text = hEmp.Name;
                    txtEmpInfo2.Text = hEmp.HoursWorked.ToString();
                    txtEmpInfo3.Text = hEmp.HourlyWage.ToString();

                    txtGrossEanings.Text = hEmp.GrossEarnings().ToString("C");
                    txtLessTax.Text = hEmp.Tax.ToString("C");
                    txtNetEarnings.Text = hEmp.NetEarnings.ToString("C");

                }
                else if (empList[empIndex].TypeOfEmployee == Employee.EmployeeType.CommissionEmployee)
                {
                    //update labels
                    rbtnCommission.Checked = true;
                    lblEmpInfo2.Text = "Gross Sales: ";
                    lblEmpInfo3.Text = "Commission Rate: ";

                    txtEmpInfo2.Visible = true;
                    txtEmpInfo3.Visible = true;

                    cEmp = (CommissionEmployee)empList[empIndex];

                    //Display Calculated Wages
                    txtEmpName.Text = cEmp.Name;
                    txtEmpInfo2.Text = cEmp.GrossSales.ToString();
                    txtEmpInfo3.Text = (cEmp.CommissionRate*100).ToString();

                    txtGrossEanings.Text = cEmp.GrossEarnings().ToString("C");
                    txtLessTax.Text = cEmp.Tax.ToString("C");
                    txtNetEarnings.Text = cEmp.NetEarnings.ToString("C");
                }
                else if (empList[empIndex].TypeOfEmployee == Employee.EmployeeType.SalariedEmployee)
                {
                    //update labels
                    rbtnWeekly.Checked = true;
                    lblEmpInfo2.Text = "Salary: ";
                    lblEmpInfo3.Visible = false;
                    txtEmpInfo3.Visible = false;

                    sEmp = (SalariedEmployee)empList[empIndex];

                    //Display Calculated Wages
                    txtEmpName.Text = sEmp.Name;
                    txtEmpInfo2.Text = sEmp.WeeklySalary.ToString();

                    txtGrossEanings.Text = sEmp.GrossEarnings().ToString("C");
                    txtLessTax.Text = sEmp.Tax.ToString("C");
                    txtNetEarnings.Text = sEmp.NetEarnings.ToString("C");

                }
            }

        }//end of cmbEmployee

        //Methods

        //create employee based on what type of employee
        public void createEmployee()
        {
            //declare variables
            String name;

            //Dertermine type of employee
            if (rbtnHourly.Checked)
            {
                //create hourly employee
                name = txtEmpName.Text;
                int hours = int.Parse(txtEmpInfo2.Text);
                Double wage = double.Parse(txtEmpInfo3.Text);
                hEmp = new HourlyEmployee(hours, wage, name, Employee.EmployeeType.HourlyEmployee);

                //calculate wage
                txtGrossEanings.Text = hEmp.GrossEarnings().ToString("C");
                txtLessTax.Text = hEmp.Tax.ToString("C");
                txtNetEarnings.Text = hEmp.NetEarnings.ToString("C");


                empList.Add(hEmp);     //add employee to list
                cmbEmployee.Items.Add(hEmp.Name);       //add employee to combo box
            }
            else if (rbtnCommission.Checked)
            {
                //create commissioned employee
                name = txtEmpName.Text;
                Double grossSale = double.Parse(txtEmpInfo2.Text);
                Double commissionRate = double.Parse(txtEmpInfo3.Text);
                cEmp = new CommissionEmployee(grossSale, commissionRate, name, Employee.EmployeeType.CommissionEmployee);

                //calculate wage
                txtGrossEanings.Text = cEmp.GrossEarnings().ToString("C");
                txtLessTax.Text = cEmp.Tax.ToString("C");
                txtNetEarnings.Text = cEmp.NetEarnings.ToString("C");

                empList.Add(cEmp);      //add employee to list
                cmbEmployee.Items.Add(cEmp.Name);
            }
            else if (rbtnWeekly.Checked)
            {
                //create salaried employee
                name = txtEmpName.Text;
                Double sales = double.Parse(txtEmpInfo2.Text);
                sEmp = new SalariedEmployee(sales, name, Employee.EmployeeType.SalariedEmployee);

                //calculate wage
                txtGrossEanings.Text = sEmp.GrossEarnings().ToString("C");
                txtLessTax.Text = sEmp.Tax.ToString("C");
                txtNetEarnings.Text = sEmp.NetEarnings.ToString("C");

                empList.Add(sEmp);      //add employee to list
                cmbEmployee.Items.Add(sEmp.Name);   //display new employee to combobox
            }
        }//end of create employee

        //Exception handling
        public bool validInput()
        {
            bool result = true;
            String name = txtEmpName.Text;

            //check if all fields are valid
            if (EmployeeExist(name))
            {
                MessageBox.Show("Employee Exists, Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            else if((name == "") && (txtEmpInfo2.Text == "") && (txtEmpInfo3.Text == ""))
            {
                MessageBox.Show("Error, Fields cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            else if(name == "")
            {
                MessageBox.Show("Error, Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            else
            {
                if (rbtnHourly.Checked)
                {
                    //check if hours are valid
                    if((txtEmpInfo2.Text == "") && (txtEmpInfo3.Text == ""))
                    {
                        MessageBox.Show("Error, both Hours Worked and Hourly Wage cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = false;
                    }
                    else if(txtEmpInfo2.Text == "")
                    {
                        MessageBox.Show("Error, Hours Worked Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = false;
                    }
                    else if(txtEmpInfo3.Text == "")
                    {
                        MessageBox.Show("Error, Hourly wage cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = false;
                    }
                    else
                    {
                        int hours = int.Parse(txtEmpInfo2.Text);
                        //check if hours is within range
                        if ((hours < 0) || (hours > 80))
                        {
                            MessageBox.Show("Error, Hours Worked cannot be below 0 or above 80", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            result = false;
                        }
                    }

                }
                else if (rbtnCommission.Checked)
                {
                    //check if Gross Sales and Commission Rate are valid
                    if ((txtEmpInfo2.Text == "") && (txtEmpInfo3.Text == ""))
                    {
                        MessageBox.Show("Error, both Gross Sales and Commission Rate cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = false;
                    }
                    else if (txtEmpInfo2.Text == "")
                    {
                        MessageBox.Show("Error, Gross Sales cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = false;
                    }
                    else if (txtEmpInfo3.Text == "")
                    {
                        MessageBox.Show("Error, Commission Rate cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = false;
                    }
                    else
                    {
                        double grossSale = double.Parse(txtEmpInfo2.Text);
                        double commissionRate = double.Parse(txtEmpInfo3.Text);
                        if (grossSale < 0)
                        {
                            MessageBox.Show("Error, Gross Sale cannot be below 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            result = false;
                        }
                        else if (grossSale < 0)
                        {
                            MessageBox.Show("Error, Commission Rate cannot be below 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            result = false;
                        }
                    }
                }
                else if (rbtnWeekly.Checked)
                {
                    //check if Salary is valid
                    if (txtEmpInfo2.Text == "")
                    {
                        MessageBox.Show("Error, Salary cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = false;
                    }
                    else
                    {
                        double salary = double.Parse(txtEmpInfo2.Text);
                        if (salary < 0)
                        {
                            MessageBox.Show("Error, Salary cannot be below 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            result = false;
                        }
                    }
                }
            }
            
            return result;
        }//end of validInput


        //check if employee exists
        public bool EmployeeExist(String name)
        {
            bool result = false;
            foreach(Employee emp in empList)
            {
                if (emp.Name.Equals(name))
                {
                    result = true;
                }
            }
            return result;
        }

    }//end of form


}
