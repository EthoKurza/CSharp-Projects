namespace A2HeyzzenFlores
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnHourly = new System.Windows.Forms.RadioButton();
            this.rbtnCommission = new System.Windows.Forms.RadioButton();
            this.rbtnWeekly = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGrossEanings = new System.Windows.Forms.TextBox();
            this.txtLessTax = new System.Windows.Forms.TextBox();
            this.txtNetEarnings = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEmpInfo2 = new System.Windows.Forms.Label();
            this.lblEmpInfo3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpInfo2 = new System.Windows.Forms.TextBox();
            this.txtEmpInfo3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select type of employee:";
            // 
            // rbtnHourly
            // 
            this.rbtnHourly.AutoSize = true;
            this.rbtnHourly.Checked = true;
            this.rbtnHourly.Location = new System.Drawing.Point(37, 56);
            this.rbtnHourly.Name = "rbtnHourly";
            this.rbtnHourly.Size = new System.Drawing.Size(79, 17);
            this.rbtnHourly.TabIndex = 1;
            this.rbtnHourly.TabStop = true;
            this.rbtnHourly.Text = "Hourly Paid";
            this.rbtnHourly.UseVisualStyleBackColor = true;
            this.rbtnHourly.CheckedChanged += new System.EventHandler(this.rbtnHourly_CheckedChanged);
            // 
            // rbtnCommission
            // 
            this.rbtnCommission.AutoSize = true;
            this.rbtnCommission.Location = new System.Drawing.Point(142, 56);
            this.rbtnCommission.Name = "rbtnCommission";
            this.rbtnCommission.Size = new System.Drawing.Size(113, 17);
            this.rbtnCommission.TabIndex = 2;
            this.rbtnCommission.Text = "Commission Based";
            this.rbtnCommission.UseVisualStyleBackColor = true;
            this.rbtnCommission.CheckedChanged += new System.EventHandler(this.rbtnCommission_CheckedChanged);
            // 
            // rbtnWeekly
            // 
            this.rbtnWeekly.AutoSize = true;
            this.rbtnWeekly.Location = new System.Drawing.Point(276, 56);
            this.rbtnWeekly.Name = "rbtnWeekly";
            this.rbtnWeekly.Size = new System.Drawing.Size(93, 17);
            this.rbtnWeekly.TabIndex = 3;
            this.rbtnWeekly.Text = "Weekly Salary";
            this.rbtnWeekly.UseVisualStyleBackColor = true;
            this.rbtnWeekly.CheckedChanged += new System.EventHandler(this.rbtnWeekly_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 116);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Information:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(22, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 108);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calculated Wage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employees: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gross Earnings:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(117, 401);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(251, 21);
            this.cmbEmployee.TabIndex = 8;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Less Tax:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Net Earnings:";
            // 
            // txtGrossEanings
            // 
            this.txtGrossEanings.Enabled = false;
            this.txtGrossEanings.Location = new System.Drawing.Point(121, 290);
            this.txtGrossEanings.Name = "txtGrossEanings";
            this.txtGrossEanings.ReadOnly = true;
            this.txtGrossEanings.Size = new System.Drawing.Size(214, 20);
            this.txtGrossEanings.TabIndex = 11;
            // 
            // txtLessTax
            // 
            this.txtLessTax.Enabled = false;
            this.txtLessTax.Location = new System.Drawing.Point(121, 317);
            this.txtLessTax.Name = "txtLessTax";
            this.txtLessTax.ReadOnly = true;
            this.txtLessTax.Size = new System.Drawing.Size(214, 20);
            this.txtLessTax.TabIndex = 12;
            // 
            // txtNetEarnings
            // 
            this.txtNetEarnings.Enabled = false;
            this.txtNetEarnings.Location = new System.Drawing.Point(121, 343);
            this.txtNetEarnings.Name = "txtNetEarnings";
            this.txtNetEarnings.ReadOnly = true;
            this.txtNetEarnings.Size = new System.Drawing.Size(214, 20);
            this.txtNetEarnings.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name:";
            // 
            // lblEmpInfo2
            // 
            this.lblEmpInfo2.AutoSize = true;
            this.lblEmpInfo2.Location = new System.Drawing.Point(38, 185);
            this.lblEmpInfo2.Name = "lblEmpInfo2";
            this.lblEmpInfo2.Size = new System.Drawing.Size(81, 13);
            this.lblEmpInfo2.TabIndex = 15;
            this.lblEmpInfo2.Text = "Hourly Worked:";
            // 
            // lblEmpInfo3
            // 
            this.lblEmpInfo3.AutoSize = true;
            this.lblEmpInfo3.Location = new System.Drawing.Point(38, 212);
            this.lblEmpInfo3.Name = "lblEmpInfo3";
            this.lblEmpInfo3.Size = new System.Drawing.Size(72, 13);
            this.lblEmpInfo3.TabIndex = 16;
            this.lblEmpInfo3.Text = "Hourly Wage:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(307, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(74, 22);
            this.btnCalculate.TabIndex = 17;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(307, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 22);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(308, 211);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 22);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(142, 152);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(127, 20);
            this.txtEmpName.TabIndex = 20;
            // 
            // txtEmpInfo2
            // 
            this.txtEmpInfo2.Location = new System.Drawing.Point(142, 180);
            this.txtEmpInfo2.Name = "txtEmpInfo2";
            this.txtEmpInfo2.Size = new System.Drawing.Size(127, 20);
            this.txtEmpInfo2.TabIndex = 21;
            // 
            // txtEmpInfo3
            // 
            this.txtEmpInfo3.Location = new System.Drawing.Point(142, 208);
            this.txtEmpInfo3.Name = "txtEmpInfo3";
            this.txtEmpInfo3.Size = new System.Drawing.Size(127, 20);
            this.txtEmpInfo3.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.txtEmpInfo3);
            this.Controls.Add(this.txtEmpInfo2);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblEmpInfo3);
            this.Controls.Add(this.lblEmpInfo2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNetEarnings);
            this.Controls.Add(this.txtLessTax);
            this.Controls.Add(this.txtGrossEanings);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnWeekly);
            this.Controls.Add(this.rbtnCommission);
            this.Controls.Add(this.rbtnHourly);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnHourly;
        private System.Windows.Forms.RadioButton rbtnCommission;
        private System.Windows.Forms.RadioButton rbtnWeekly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGrossEanings;
        private System.Windows.Forms.TextBox txtLessTax;
        private System.Windows.Forms.TextBox txtNetEarnings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEmpInfo2;
        private System.Windows.Forms.Label lblEmpInfo3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpInfo2;
        private System.Windows.Forms.TextBox txtEmpInfo3;
    }
}

