using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArithmeticApp
{
    public partial class Form1 : Form
    {
        int num1=5, num2=4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int solution = num1 + num2;
            int userSolution = int.Parse(textBox1.Text);

            if(solution == userSolution)
            {
                label2.ForeColor = Color.Green;
                label2.Text = "Correct";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Wrong";
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            Random rNum = new Random();
            num1 = rNum.Next(1, 10);
            num2 = rNum.Next(1, 10);

            label1.Text = num1 + "+" + num2 + "=";

        }
    }
}
