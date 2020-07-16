using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTHeyzzenFlores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            //go to form 2
            Form2 form2 = new Form2();
            form2.ShowDialog();

            //display values from form 2 into form 1
            Car vehicle = Form2.CarInfo;
            lblName.Text = ($"Name: \t{vehicle.Name}");
            lblPrice.Text = ($"Price: \t{vehicle.Price.ToString("C")}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //user close confirmation
            DialogResult result = MessageBox.Show("Do you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
