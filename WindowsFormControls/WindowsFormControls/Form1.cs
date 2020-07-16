using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMessageBox_Click(object sender, EventArgs e)
        {
            //message box:
            
            /*   MessageBox.Show(<message>,<title>,<button>,<icon>);       */

            /*
            MessageBox.Show("This is a message box","Title of Message Box", MessageBoxButtons.YesNo,MessageBoxIcon.Information);           //displays a popup/message box 
            */

            DialogResult result = MessageBox.Show("Do you want to exit?", "Title of Message Box", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                Close();
            }


        }//end of button function

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbPhones.Items.Add("Apple");
            //cmbPhones.Items.Add("Samsung");
            //cmbPhones.Items.Add("LG");
            //cmbPhones.Items.Add("Sony");
            //cmbPhones.Items.Add("Google");
            //cmbPhones.Items.Add("Huwawei");
            //cmbPhones.Items.Add("Nokia");

            String[] phones = { "Apple", "Samsung", "LG", "Sony", "Google", "Huwawei", "Nokia" };

            cmbPhones.Items.AddRange(phones);

            cmbPhones.Items.Insert(0, "- Select Phone -");
            //this.cmbPhones.SelectedIndexChanged -= new System.EventHandler(this.cmbPhones_SelectedIndexChanged);
            
            cmbPhones.SelectedIndex = 0;

            //this.cmbPhones.SelectedIndexChanged += new System.EventHandler(this.cmbPhones_SelectedIndexChanged);


            /**
             * 
             * Week 2 - combo box Exercise
             * 
             */

            
            
            //set day
            for (int i = 1; i <= 30; i++) {
                cmbDay.Items.Add(i);
            }

            //set year
            int startYear = DateTime.Today.Year;
            int endYear = startYear - 100;

            while (startYear > endYear)
            {
                cmbYear.Items.Add(startYear);
                startYear--;
            }
            //set initial combo box text
            cmbMonth.Items.Insert(0, "- Month -");
            cmbDay.Items.Insert(0, "- Day -");
            cmbYear.Items.Insert(0, "- Year -");

            //set the selected item in the combo box 
            cmbMonth.SelectedIndex = 0;
            cmbDay.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;

            /**
             * 
             * Image form setup
             * 
             */

            //picCar.Image = "<path>";

            //picCar.Image = Properties.Resources.monsterHunter;
            picCar.Image = Properties.Resources.shield;

            //dateTimePicker setting dates
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(2);



        }//end of form initialization

        private void cmbPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPhones.SelectedIndex > 0)
            {
                MessageBox.Show("You selected: " + cmbPhones.Text);
            }
        }//end of combobox

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex == 0 || cmbDay.SelectedIndex == 0 || cmbYear.SelectedIndex == 0)
            {
                MessageBox.Show("Error, Please Select a Month,Day, and Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Your date of birth is: " + cmbMonth.Text +","+ cmbDay.Text+","+ cmbYear.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReadRadioButton_Click(object sender, EventArgs e)
        {
            // Method 1 - if/else

            //if (rdoFemale.Checked)
            //    MessageBox.Show("You've selected " + rdoFemale.Text);
            //else if (rdoMale.Checked)
            //    MessageBox.Show("You've selected "+ rdoMale.Text);
            //else if (rdoOther.Checked)
            //    MessageBox.Show("You've selected "+ rdoOther.Text);
            //else
            //    MessageBox.Show("Please select your gender");

            //Method 2 - using loop

            //foreach(Control control in Controls)
            //{
            //    if(control is RadioButton) {
            //        //RadioButton radio = (RadioButton)control;
            //        RadioButton radio = control as RadioButton;       //samthing but can only be used for reference

            //        if (radio.Checked){
            //            MessageBox.Show("You've selected " + radio.Text);
            //            break;
            //        }

            //    }
            //}//end of for each

            //method 3 - loop with filter

            foreach(RadioButton radio in Controls.OfType<RadioButton>())
            {
                if (radio.Checked)
                {
                    MessageBox.Show("You've selected " + radio.Text);
                    break;
                }
            }
            

        }//end of btnReadRadioButton_click

        private void btnReadCheckBox_Click(object sender, EventArgs e)
        {
            String accessories = null;
            
            foreach(CheckBox chk in Controls.OfType<CheckBox>())
            {
                if (chk.Checked)
                    accessories += chk.Text + ", \n";
            }//end of for each loop

            if (accessories == null)
                MessageBox.Show("Please select your accessories");
            else
                MessageBox.Show("You've selected: " + accessories.TrimEnd(' ', ','));        //it will remove space and the comma

        } //end of btnReadCheckBox_Click  
       
        
        
        private bool isShield = true;
        private void btnSwap_Click(object sender, EventArgs e)
        {
            if (isShield)
                picCar.Image = Properties.Resources.sword;
            else
                picCar.Image = Properties.Resources.shield;
            isShield  = !isShield;
        }
    }
}
