using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1InvoiceTotal
{
    public partial class Form1 : Form
    {
        private double discountPercentage = 0.25;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double subtotal = double.Parse(txtSubtotal.Text);
            double discountAmount = subtotal * discountPercentage;
            double total = subtotal - discountAmount;


            
            txtDiscountA.Text = discountAmount.ToString("C");
            txtTotal.Text = total.ToString("C");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDiscountP.Text = discountPercentage.ToString("P0");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
