namespace A1HeyzzenFlores
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBeverage = new System.Windows.Forms.ComboBox();
            this.cmbAppetizers = new System.Windows.Forms.ComboBox();
            this.cmbMain = new System.Windows.Forms.ComboBox();
            this.cmbDesserts = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Restauran Bill Calculator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Beverage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Appetizer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Main Course";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Desserts";
            // 
            // cmbBeverage
            // 
            this.cmbBeverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeverage.FormattingEnabled = true;
            this.cmbBeverage.Items.AddRange(new object[] {
            "Soda - $1.95",
            "Tea - $1.50",
            "Coffee - $1.25",
            "Mineral Water - $2.95",
            "Juice - $2.50"});
            this.cmbBeverage.Location = new System.Drawing.Point(165, 103);
            this.cmbBeverage.Name = "cmbBeverage";
            this.cmbBeverage.Size = new System.Drawing.Size(125, 21);
            this.cmbBeverage.TabIndex = 6;
            this.cmbBeverage.SelectedIndexChanged += new System.EventHandler(this.cmbBeverage_SelectedIndexChanged);
            // 
            // cmbAppetizers
            // 
            this.cmbAppetizers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppetizers.FormattingEnabled = true;
            this.cmbAppetizers.Items.AddRange(new object[] {
            "Buffalo Wings - $5.95",
            "Buffalo Fingers - $6.95",
            "Nachos - $8,95",
            "Mushroom Caps - $10.95",
            "Chips and Salsa - $6.95"});
            this.cmbAppetizers.Location = new System.Drawing.Point(165, 138);
            this.cmbAppetizers.Name = "cmbAppetizers";
            this.cmbAppetizers.Size = new System.Drawing.Size(125, 21);
            this.cmbAppetizers.TabIndex = 7;
            this.cmbAppetizers.SelectedIndexChanged += new System.EventHandler(this.cmbAppetizers_SelectedIndexChanged);
            // 
            // cmbMain
            // 
            this.cmbMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMain.FormattingEnabled = true;
            this.cmbMain.Items.AddRange(new object[] {
            "Chicken Alfredo - $ 13.95",
            "Turkey Club - $11.95",
            "Prime Rib - $10.95",
            "Turkey Dinner - $13.95",
            "Stuffed Chicken - $14.95"});
            this.cmbMain.Location = new System.Drawing.Point(165, 174);
            this.cmbMain.Name = "cmbMain";
            this.cmbMain.Size = new System.Drawing.Size(125, 21);
            this.cmbMain.TabIndex = 8;
            this.cmbMain.SelectedIndexChanged += new System.EventHandler(this.cmbMain_SelectedIndexChanged);
            // 
            // cmbDesserts
            // 
            this.cmbDesserts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesserts.FormattingEnabled = true;
            this.cmbDesserts.Items.AddRange(new object[] {
            "Apple Pie - $5.95",
            "Sundae - $3.95",
            "Carrot Cake - $5.95",
            "Apple Crisp - $5.95"});
            this.cmbDesserts.Location = new System.Drawing.Point(165, 207);
            this.cmbDesserts.Name = "cmbDesserts";
            this.cmbDesserts.Size = new System.Drawing.Size(125, 21);
            this.cmbDesserts.TabIndex = 9;
            this.cmbDesserts.SelectedIndexChanged += new System.EventHandler(this.cmbDesserts_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Student Info:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(445, 295);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 12;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(445, 325);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(445, 355);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Subtotal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tax (13%):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total: ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(445, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "ClearBill";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Orders
            // 
            this.Orders.FormattingEnabled = true;
            this.Orders.Items.AddRange(new object[] {
            ""});
            this.Orders.Location = new System.Drawing.Point(361, 76);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(184, 186);
            this.Orders.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Name: Heyzzen Flores";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Student ID: 991 452 883";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(606, 442);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.cmbDesserts);
            this.Controls.Add(this.cmbMain);
            this.Controls.Add(this.cmbAppetizers);
            this.Controls.Add(this.cmbBeverage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBeverage;
        private System.Windows.Forms.ComboBox cmbAppetizers;
        private System.Windows.Forms.ComboBox cmbMain;
        private System.Windows.Forms.ComboBox cmbDesserts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox Orders;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

