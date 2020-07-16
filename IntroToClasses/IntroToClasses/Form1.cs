using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroToClasses
{
    public partial class Form1 : Form
    {
        private Account _account;
        public Form1()
        {
            InitializeComponent();
            _account = new Account();
            _account.Balance = 100M;
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            //lblMessage.Text = _account.GetBalance().ToString("C");
            lblMessage.Text = _account.Balance.ToString("C");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            _account.Deposit(numAmount.Value);
            lblMessage.Text = _account.Balance.ToString("C");
            //lblMessage.Text = _account.GetBalance().ToString("C");
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                _account.Withdraw(numAmount.Value);
                lblMessage.Text = _account.Balance.ToString("C");
                //lblMessage.Text = _account.GetBalance().ToString("C");
            }
            catch(Exception ex)
            {
                lblMessage.Text = ex.Message;
                lblMessage.ForeColor = Color.Red;
            }
            
            
        }
    }
}
