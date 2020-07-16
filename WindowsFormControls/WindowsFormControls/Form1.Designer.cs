namespace WindowsFormControls
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
            this.btnShowMessageBox = new System.Windows.Forms.Button();
            this.cmbCars = new System.Windows.Forms.ComboBox();
            this.cmbPhones = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.btnReadRadioButton = new System.Windows.Forms.Button();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkMobile = new System.Windows.Forms.CheckBox();
            this.chkTablet = new System.Windows.Forms.CheckBox();
            this.chkWatch = new System.Windows.Forms.CheckBox();
            this.btnReadCheckBox = new System.Windows.Forms.Button();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowMessageBox
            // 
            this.btnShowMessageBox.Location = new System.Drawing.Point(44, 45);
            this.btnShowMessageBox.Name = "btnShowMessageBox";
            this.btnShowMessageBox.Size = new System.Drawing.Size(83, 43);
            this.btnShowMessageBox.TabIndex = 0;
            this.btnShowMessageBox.Text = "Show Message Box";
            this.btnShowMessageBox.UseVisualStyleBackColor = true;
            this.btnShowMessageBox.Click += new System.EventHandler(this.btnShowMessageBox_Click);
            // 
            // cmbCars
            // 
            this.cmbCars.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCars.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCars.FormattingEnabled = true;
            this.cmbCars.Items.AddRange(new object[] {
            "Ford",
            "Honda",
            "Hyundai",
            "Kia",
            "Nissan",
            "Toyota"});
            this.cmbCars.Location = new System.Drawing.Point(151, 57);
            this.cmbCars.Name = "cmbCars";
            this.cmbCars.Size = new System.Drawing.Size(121, 21);
            this.cmbCars.Sorted = true;
            this.cmbCars.TabIndex = 1;
            // 
            // cmbPhones
            // 
            this.cmbPhones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhones.FormattingEnabled = true;
            this.cmbPhones.Location = new System.Drawing.Point(298, 57);
            this.cmbPhones.Name = "cmbPhones";
            this.cmbPhones.Size = new System.Drawing.Size(121, 21);
            this.cmbPhones.Sorted = true;
            this.cmbPhones.TabIndex = 2;
            this.cmbPhones.SelectedIndexChanged += new System.EventHandler(this.cmbPhones_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(120, 221);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July ",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(41, 184);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbMonth.TabIndex = 5;
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(168, 184);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(121, 21);
            this.cmbDay.TabIndex = 6;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(295, 184);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Date of Birth:";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(481, 48);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 9;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(481, 71);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 10;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(481, 94);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(51, 17);
            this.rdoOther.TabIndex = 11;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // btnReadRadioButton
            // 
            this.btnReadRadioButton.Location = new System.Drawing.Point(546, 57);
            this.btnReadRadioButton.Name = "btnReadRadioButton";
            this.btnReadRadioButton.Size = new System.Drawing.Size(74, 45);
            this.btnReadRadioButton.TabIndex = 12;
            this.btnReadRadioButton.Text = "Read Radio Button";
            this.btnReadRadioButton.UseVisualStyleBackColor = true;
            this.btnReadRadioButton.Click += new System.EventHandler(this.btnReadRadioButton_Click);
            // 
            // chkLaptop
            // 
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location = new System.Drawing.Point(481, 175);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.Size = new System.Drawing.Size(59, 17);
            this.chkLaptop.TabIndex = 13;
            this.chkLaptop.Text = "Laptop";
            this.chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkMobile
            // 
            this.chkMobile.AutoSize = true;
            this.chkMobile.Location = new System.Drawing.Point(481, 198);
            this.chkMobile.Name = "chkMobile";
            this.chkMobile.Size = new System.Drawing.Size(57, 17);
            this.chkMobile.TabIndex = 14;
            this.chkMobile.Text = "Mobile";
            this.chkMobile.UseVisualStyleBackColor = true;
            // 
            // chkTablet
            // 
            this.chkTablet.AutoSize = true;
            this.chkTablet.Location = new System.Drawing.Point(481, 221);
            this.chkTablet.Name = "chkTablet";
            this.chkTablet.Size = new System.Drawing.Size(56, 17);
            this.chkTablet.TabIndex = 15;
            this.chkTablet.Text = "Tablet";
            this.chkTablet.UseVisualStyleBackColor = true;
            // 
            // chkWatch
            // 
            this.chkWatch.AutoSize = true;
            this.chkWatch.Location = new System.Drawing.Point(481, 250);
            this.chkWatch.Name = "chkWatch";
            this.chkWatch.Size = new System.Drawing.Size(58, 17);
            this.chkWatch.TabIndex = 16;
            this.chkWatch.Text = "Watch";
            this.chkWatch.UseVisualStyleBackColor = true;
            // 
            // btnReadCheckBox
            // 
            this.btnReadCheckBox.Location = new System.Drawing.Point(567, 198);
            this.btnReadCheckBox.Name = "btnReadCheckBox";
            this.btnReadCheckBox.Size = new System.Drawing.Size(74, 46);
            this.btnReadCheckBox.TabIndex = 17;
            this.btnReadCheckBox.Text = "Read CheckBox";
            this.btnReadCheckBox.UseVisualStyleBackColor = true;
            this.btnReadCheckBox.Click += new System.EventHandler(this.btnReadCheckBox_Click);
            // 
            // picCar
            // 
            this.picCar.Location = new System.Drawing.Point(667, 48);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(130, 124);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCar.TabIndex = 18;
            this.picCar.TabStop = false;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(743, 184);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(75, 23);
            this.btnSwap.TabIndex = 19;
            this.btnSwap.Text = "Swap";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(608, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 385);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.btnReadCheckBox);
            this.Controls.Add(this.chkWatch);
            this.Controls.Add(this.chkTablet);
            this.Controls.Add(this.chkMobile);
            this.Controls.Add(this.chkLaptop);
            this.Controls.Add(this.btnReadRadioButton);
            this.Controls.Add(this.rdoOther);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbPhones);
            this.Controls.Add(this.cmbCars);
            this.Controls.Add(this.btnShowMessageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowMessageBox;
        private System.Windows.Forms.ComboBox cmbCars;
        private System.Windows.Forms.ComboBox cmbPhones;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.Button btnReadRadioButton;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkMobile;
        private System.Windows.Forms.CheckBox chkTablet;
        private System.Windows.Forms.CheckBox chkWatch;
        private System.Windows.Forms.Button btnReadCheckBox;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

