namespace LinqWithWindowsForms
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
            this.btnShowAllEmployees = new System.Windows.Forms.Button();
            this.btnEmployeesBetween4k6l = new System.Windows.Forms.Button();
            this.btnSortEmployeesByLastName = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowAllEmployees
            // 
            this.btnShowAllEmployees.Location = new System.Drawing.Point(39, 33);
            this.btnShowAllEmployees.Name = "btnShowAllEmployees";
            this.btnShowAllEmployees.Size = new System.Drawing.Size(117, 52);
            this.btnShowAllEmployees.TabIndex = 0;
            this.btnShowAllEmployees.Text = "Show All Employees";
            this.btnShowAllEmployees.UseVisualStyleBackColor = true;
            this.btnShowAllEmployees.Click += new System.EventHandler(this.btnShowAllEmployees_Click);
            // 
            // btnEmployeesBetween4k6l
            // 
            this.btnEmployeesBetween4k6l.Location = new System.Drawing.Point(214, 33);
            this.btnEmployeesBetween4k6l.Name = "btnEmployeesBetween4k6l";
            this.btnEmployeesBetween4k6l.Size = new System.Drawing.Size(117, 52);
            this.btnEmployeesBetween4k6l.TabIndex = 1;
            this.btnEmployeesBetween4k6l.Text = "Employees Between 4k and 6k";
            this.btnEmployeesBetween4k6l.UseVisualStyleBackColor = true;
            this.btnEmployeesBetween4k6l.Click += new System.EventHandler(this.btnEmployeesBetween4k6l_Click);
            // 
            // btnSortEmployeesByLastName
            // 
            this.btnSortEmployeesByLastName.Location = new System.Drawing.Point(381, 33);
            this.btnSortEmployeesByLastName.Name = "btnSortEmployeesByLastName";
            this.btnSortEmployeesByLastName.Size = new System.Drawing.Size(117, 52);
            this.btnSortEmployeesByLastName.TabIndex = 2;
            this.btnSortEmployeesByLastName.Text = "Sort Employees by Lastname";
            this.btnSortEmployeesByLastName.UseVisualStyleBackColor = true;
            this.btnSortEmployeesByLastName.Click += new System.EventHandler(this.btnSortEmployeesByLastName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstName.Location = new System.Drawing.Point(39, 118);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(117, 217);
            this.lblFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastName.Location = new System.Drawing.Point(214, 118);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(117, 217);
            this.lblLastName.TabIndex = 4;
            // 
            // lblSalary
            // 
            this.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalary.Location = new System.Drawing.Point(381, 118);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(117, 217);
            this.lblSalary.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FirstName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "LastName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salary: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnSortEmployeesByLastName);
            this.Controls.Add(this.btnEmployeesBetween4k6l);
            this.Controls.Add(this.btnShowAllEmployees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllEmployees;
        private System.Windows.Forms.Button btnEmployeesBetween4k6l;
        private System.Windows.Forms.Button btnSortEmployeesByLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

