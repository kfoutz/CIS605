namespace Program8_PaySlip
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
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreatePaySlip = new System.Windows.Forms.Button();
            this.btnDisplaySummary = new System.Windows.Forms.Button();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblResultNetPay = new System.Windows.Forms.Label();
            this.nudHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.nudPayRate = new System.Windows.Forms.NumericUpDown();
            this.tbxEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 18);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(12, 47);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(76, 13);
            this.lblHoursWorked.TabIndex = 1;
            this.lblHoursWorked.Text = "Hours Worked";
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(12, 76);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(51, 13);
            this.lblPayRate.TabIndex = 2;
            this.lblPayRate.Text = "Pay Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDisplaySummary);
            this.groupBox1.Controls.Add(this.tbxEmployeeName);
            this.groupBox1.Controls.Add(this.nudPayRate);
            this.groupBox1.Controls.Add(this.nudHoursWorked);
            this.groupBox1.Controls.Add(this.lblResultNetPay);
            this.groupBox1.Controls.Add(this.lblNetPay);
            this.groupBox1.Controls.Add(this.btnCreatePaySlip);
            this.groupBox1.Controls.Add(this.lblPayRate);
            this.groupBox1.Controls.Add(this.lblHoursWorked);
            this.groupBox1.Controls.Add(this.lblEmployeeName);
            this.groupBox1.Location = new System.Drawing.Point(20, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 217);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // btnCreatePaySlip
            // 
            this.btnCreatePaySlip.Location = new System.Drawing.Point(113, 128);
            this.btnCreatePaySlip.Name = "btnCreatePaySlip";
            this.btnCreatePaySlip.Size = new System.Drawing.Size(75, 39);
            this.btnCreatePaySlip.TabIndex = 4;
            this.btnCreatePaySlip.Text = "&Create Pay Slip";
            this.btnCreatePaySlip.UseVisualStyleBackColor = true;
            this.btnCreatePaySlip.Click += new System.EventHandler(this.btnCreatePaySlip_Click);
            // 
            // btnDisplaySummary
            // 
            this.btnDisplaySummary.Location = new System.Drawing.Point(21, 128);
            this.btnDisplaySummary.Name = "btnDisplaySummary";
            this.btnDisplaySummary.Size = new System.Drawing.Size(75, 39);
            this.btnDisplaySummary.TabIndex = 5;
            this.btnDisplaySummary.Text = "&Display Summary";
            this.btnDisplaySummary.UseVisualStyleBackColor = true;
            this.btnDisplaySummary.Click += new System.EventHandler(this.btnDisplaySummary_Click);
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(12, 102);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(45, 13);
            this.lblNetPay.TabIndex = 7;
            this.lblNetPay.Text = "Net Pay";
            // 
            // lblResultNetPay
            // 
            this.lblResultNetPay.AutoSize = true;
            this.lblResultNetPay.Location = new System.Drawing.Point(110, 102);
            this.lblResultNetPay.Name = "lblResultNetPay";
            this.lblResultNetPay.Size = new System.Drawing.Size(0, 13);
            this.lblResultNetPay.TabIndex = 8;
            // 
            // nudHoursWorked
            // 
            this.nudHoursWorked.Location = new System.Drawing.Point(113, 40);
            this.nudHoursWorked.Name = "nudHoursWorked";
            this.nudHoursWorked.Size = new System.Drawing.Size(120, 20);
            this.nudHoursWorked.TabIndex = 2;
            // 
            // nudPayRate
            // 
            this.nudPayRate.Location = new System.Drawing.Point(113, 69);
            this.nudPayRate.Name = "nudPayRate";
            this.nudPayRate.Size = new System.Drawing.Size(120, 20);
            this.nudPayRate.TabIndex = 3;
            // 
            // tbxEmployeeName
            // 
            this.tbxEmployeeName.Location = new System.Drawing.Point(113, 10);
            this.tbxEmployeeName.Name = "tbxEmployeeName";
            this.tbxEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kerry\'s Program";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pay Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultNetPay;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Button btnCreatePaySlip;
        private System.Windows.Forms.Button btnDisplaySummary;
        private System.Windows.Forms.TextBox tbxEmployeeName;
        private System.Windows.Forms.NumericUpDown nudPayRate;
        private System.Windows.Forms.NumericUpDown nudHoursWorked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

