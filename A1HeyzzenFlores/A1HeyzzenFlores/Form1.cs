using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Name: Heyzzen Flores
 * Student ID: 991 452 883
 * Program Title: Restaurant Bill Calculator
 * Date: January 16, 2020
 */


namespace A1HeyzzenFlores
{
    public partial class Form1 : Form
    {
        
        //declare and initialize global variables
        static Double[] g_beverageCost = { 1.95, 1.50, 1.25, 2.95, 2.50 };
        static Double[] g_appetizerCost = { 5.95,6.95,8.95,10.95,6.95 };
        static Double[] g_mainCost = {13.95,11.95,20.95,13.95,14.95 };
        static Double[] g_dessertsCost = { 5.95,3.95,5.95,5.95};
        Double g_subTotal = 0.00;
        Double g_tax = 0.00;
        Double g_total=0.00;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   
            //clear and reset form
            Orders.Items.Clear();
            g_subTotal = 0.00;
            g_tax = 0.00;
            g_total = 0.00;
            txtSubtotal.Text = g_subTotal.ToString("C");
            txtTax.Text = g_tax.ToString("C");
            txtTotal.Text = g_total.ToString("C");

            //reset selection
            cmbBeverage.SelectedIndex = 0;
            cmbAppetizers.SelectedIndex = 0;
            cmbMain.SelectedIndex = 0;
            cmbDesserts.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //declare variables
            

            //set and initialize index 0 for all food items
            cmbBeverage.Items.Insert(0, "- Select Beverage - ");
            cmbBeverage.SelectedIndex = 0;

            cmbAppetizers.Items.Insert(0, "- Select Appetizers - ");
            cmbAppetizers.SelectedIndex = 0;

            cmbMain.Items.Insert(0, "- Select Main Course - ");
            cmbMain.SelectedIndex = 0;

            cmbDesserts.Items.Insert(0, "- Select Desserts - ");
            cmbDesserts.SelectedIndex = 0;

            txtSubtotal.Text = g_subTotal.ToString("C");
            txtTax.Text = g_tax.ToString("C");
            txtTotal.Text = g_total.ToString("C");

        }

        private void cmbBeverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBeverage.SelectedIndex > 0)
            {
                Orders.Items.Add(cmbBeverage.SelectedItem);

                //get beverage value and add it to subtotal
                if(cmbBeverage.SelectedIndex == 1)
                {
                    g_subTotal += g_beverageCost[0];
                }
                else if (cmbBeverage.SelectedIndex == 2)
                {
                    g_subTotal += g_beverageCost[1];
                }
                else if (cmbBeverage.SelectedIndex == 3)
                {
                    g_subTotal += g_beverageCost[2];
                }
                else if (cmbBeverage.SelectedIndex == 4)
                {
                    g_subTotal += g_beverageCost[3];
                }
                else if (cmbBeverage.SelectedIndex == 5)
                {
                    g_subTotal += g_beverageCost[4];
                }

                //calculate tax and totals
                g_tax = g_subTotal * 0.13;
                g_total = g_subTotal + g_tax;

                //output results onto the form
                txtSubtotal.Text = g_subTotal.ToString("C");
                txtTax.Text = g_tax.ToString("C");
                txtTotal.Text = g_total.ToString("C");
                
            }
        }//end of Beverage_SelectedIndexChange

        private void cmbAppetizers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAppetizers.SelectedIndex > 0)
            {
                Orders.Items.Add(cmbAppetizers.SelectedItem);
                
                //get Appetizer value and add it to subtotal
                if (cmbAppetizers.SelectedIndex == 1)
                {
                    g_subTotal += g_appetizerCost[0];
                }
                else if (cmbAppetizers.SelectedIndex == 2)
                {
                    g_subTotal += g_appetizerCost[1];
                }
                else if (cmbAppetizers.SelectedIndex == 3)
                {
                    g_subTotal += g_appetizerCost[2];
                }
                else if (cmbAppetizers.SelectedIndex == 4)
                {
                    g_subTotal += g_appetizerCost[3];
                }
                else if (cmbAppetizers.SelectedIndex == 5)
                {
                    g_subTotal += g_appetizerCost[4];
                }

                //calculate costs
                g_tax = g_subTotal * 0.13;
                g_total = g_subTotal + g_tax;

                //output costs
                txtSubtotal.Text = g_subTotal.ToString("C");
                txtTax.Text = g_tax.ToString("C");
                txtTotal.Text = g_total.ToString("C");
            }
        }//end of Appetizers_SelectedIndexChange

        private void cmbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMain.SelectedIndex > 0)
            {
                Orders.Items.Add(cmbMain.SelectedItem);

                //get Appetizer value and add it to subtotal
                if (cmbMain.SelectedIndex == 1)
                {
                    g_subTotal += g_mainCost[0];
                }
                else if (cmbMain.SelectedIndex == 2)
                {
                    g_subTotal += g_mainCost[1];
                }
                else if (cmbMain.SelectedIndex == 3)
                {
                    g_subTotal += g_mainCost[2];
                }
                else if (cmbMain.SelectedIndex == 4)
                {
                    g_subTotal += g_mainCost[3];
                }
                else if (cmbMain.SelectedIndex == 5)
                {
                    g_subTotal += g_mainCost[4];
                }

                //calculate costs
                g_tax = g_subTotal * 0.13;
                g_total = g_subTotal + g_tax;

                //output costs
                txtSubtotal.Text = g_subTotal.ToString("C");
                txtTax.Text = g_tax.ToString("C");
                txtTotal.Text = g_total.ToString("C");
            }
        }//end of Main_SelectedIndexChange

        private void cmbDesserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDesserts.SelectedIndex > 0)
            {
                Orders.Items.Add(cmbDesserts.SelectedItem);

                //get Appetizer value and add it to subtotal
                if (cmbDesserts.SelectedIndex == 1)
                {
                    g_subTotal += g_dessertsCost[0];
                }
                else if (cmbDesserts.SelectedIndex == 2)
                {
                    g_subTotal += g_dessertsCost[1];
                }
                else if (cmbDesserts.SelectedIndex == 3)
                {
                    g_subTotal += g_dessertsCost[2];
                }
                else if (cmbDesserts.SelectedIndex == 4)
                {
                    g_subTotal += g_dessertsCost[3];
                }
                else if (cmbDesserts.SelectedIndex == 5)
                {
                    g_subTotal += g_dessertsCost[4];
                }

                //calculate costs
                g_tax = g_subTotal * 0.13;
                g_total = g_subTotal + g_tax;

                //output costs
                txtSubtotal.Text = g_subTotal.ToString("C");
                txtTax.Text = g_tax.ToString("C");
                txtTotal.Text = g_total.ToString("C");
            }
        }//end of Desserts_SelectedIndexChange
    }
}
