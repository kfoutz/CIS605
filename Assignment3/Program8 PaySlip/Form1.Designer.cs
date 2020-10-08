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
            this.lblTotalNumberPaySlips = new System.Windows.Forms.Label();
            this.lblTotalGrossPay = new System.Windows.Forms.Label();
            this.lblTotalNetPay = new System.Windows.Forms.Label();
            this.lblAverageNetPay = new System.Windows.Forms.Label();
            this.lblResultTotalNumberPaySlips = new System.Windows.Forms.Label();
            this.lblResultTotalGrossPay = new System.Windows.Forms.Label();
            this.lblResultTotalNetPay = new System.Windows.Forms.Label();
            this.lblResultAverageNetPay = new System.Windows.Forms.Label();
            this.btnCreatePaySlip = new System.Windows.Forms.Button();
            this.btnDisplaySummary = new System.Windows.Forms.Button();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblResultNetPay = new System.Windows.Forms.Label();
            this.nudHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.nudPayRate = new System.Windows.Forms.NumericUpDown();
            this.tbxEmployeeName = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Size = new System.Drawing.Size(239, 194);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lblTotalNumberPaySlips
            // 
            this.lblTotalNumberPaySlips.AutoSize = true;
            this.lblTotalNumberPaySlips.Location = new System.Drawing.Point(331, 71);
            this.lblTotalNumberPaySlips.Name = "lblTotalNumberPaySlips";
            this.lblTotalNumberPaySlips.Size = new System.Drawing.Size(129, 13);
            this.lblTotalNumberPaySlips.TabIndex = 7;
            this.lblTotalNumberPaySlips.Text = "Total Number of Pay Slips";
            // 
            // lblTotalGrossPay
            // 
            this.lblTotalGrossPay.AutoSize = true;
            this.lblTotalGrossPay.Location = new System.Drawing.Point(331, 100);
            this.lblTotalGrossPay.Name = "lblTotalGrossPay";
            this.lblTotalGrossPay.Size = new System.Drawing.Size(87, 13);
            this.lblTotalGrossPay.TabIndex = 8;
            this.lblTotalGrossPay.Text = "Total Gross Pays";
            // 
            // lblTotalNetPay
            // 
            this.lblTotalNetPay.AutoSize = true;
            this.lblTotalNetPay.Location = new System.Drawing.Point(331, 129);
            this.lblTotalNetPay.Name = "lblTotalNetPay";
            this.lblTotalNetPay.Size = new System.Drawing.Size(72, 13);
            this.lblTotalNetPay.TabIndex = 9;
            this.lblTotalNetPay.Text = "Total Net Pay";
            // 
            // lblAverageNetPay
            // 
            this.lblAverageNetPay.AutoSize = true;
            this.lblAverageNetPay.Location = new System.Drawing.Point(331, 155);
            this.lblAverageNetPay.Name = "lblAverageNetPay";
            this.lblAverageNetPay.Size = new System.Drawing.Size(88, 13);
            this.lblAverageNetPay.TabIndex = 10;
            this.lblAverageNetPay.Text = "Average Net Pay";
            // 
            // lblResultTotalNumberPaySlips
            // 
            this.lblResultTotalNumberPaySlips.AutoSize = true;
            this.lblResultTotalNumberPaySlips.Location = new System.Drawing.Point(507, 71);
            this.lblResultTotalNumberPaySlips.Name = "lblResultTotalNumberPaySlips";
            this.lblResultTotalNumberPaySlips.Size = new System.Drawing.Size(0, 13);
            this.lblResultTotalNumberPaySlips.TabIndex = 11;
            // 
            // lblResultTotalGrossPay
            // 
            this.lblResultTotalGrossPay.AutoSize = true;
            this.lblResultTotalGrossPay.Location = new System.Drawing.Point(507, 100);
            this.lblResultTotalGrossPay.Name = "lblResultTotalGrossPay";
            this.lblResultTotalGrossPay.Size = new System.Drawing.Size(0, 13);
            this.lblResultTotalGrossPay.TabIndex = 12;
            // 
            // lblResultTotalNetPay
            // 
            this.lblResultTotalNetPay.AutoSize = true;
            this.lblResultTotalNetPay.Location = new System.Drawing.Point(507, 129);
            this.lblResultTotalNetPay.Name = "lblResultTotalNetPay";
            this.lblResultTotalNetPay.Size = new System.Drawing.Size(0, 13);
            this.lblResultTotalNetPay.TabIndex = 13;
            // 
            // lblResultAverageNetPay
            // 
            this.lblResultAverageNetPay.AutoSize = true;
            this.lblResultAverageNetPay.Location = new System.Drawing.Point(507, 155);
            this.lblResultAverageNetPay.Name = "lblResultAverageNetPay";
            this.lblResultAverageNetPay.Size = new System.Drawing.Size(0, 13);
            this.lblResultAverageNetPay.TabIndex = 14;
            // 
            // btnCreatePaySlip
            // 
            this.btnCreatePaySlip.Location = new System.Drawing.Point(113, 128);
            this.btnCreatePaySlip.Name = "btnCreatePaySlip";
            this.btnCreatePaySlip.Size = new System.Drawing.Size(75, 39);
            this.btnCreatePaySlip.TabIndex = 6;
            this.btnCreatePaySlip.Text = "Create Pay Slip";
            this.btnCreatePaySlip.UseVisualStyleBackColor = true;
            this.btnCreatePaySlip.Click += new System.EventHandler(this.btnCreatePaySlip_Click);
            // 
            // btnDisplaySummary
            // 
            this.btnDisplaySummary.Location = new System.Drawing.Point(334, 181);
            this.btnDisplaySummary.Name = "btnDisplaySummary";
            this.btnDisplaySummary.Size = new System.Drawing.Size(75, 39);
            this.btnDisplaySummary.TabIndex = 15;
            this.btnDisplaySummary.Text = "Display Summary";
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
            this.nudHoursWorked.TabIndex = 10;
            // 
            // nudPayRate
            // 
            this.nudPayRate.Location = new System.Drawing.Point(113, 69);
            this.nudPayRate.Name = "nudPayRate";
            this.nudPayRate.Size = new System.Drawing.Size(120, 20);
            this.nudPayRate.TabIndex = 11;
            // 
            // tbxEmployeeName
            // 
            this.tbxEmployeeName.Location = new System.Drawing.Point(113, 10);
            this.tbxEmployeeName.Name = "tbxEmployeeName";
            this.tbxEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.tbxEmployeeName.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplaySummary);
            this.Controls.Add(this.lblResultAverageNetPay);
            this.Controls.Add(this.lblResultTotalNetPay);
            this.Controls.Add(this.lblResultTotalGrossPay);
            this.Controls.Add(this.lblResultTotalNumberPaySlips);
            this.Controls.Add(this.lblAverageNetPay);
            this.Controls.Add(this.lblTotalNetPay);
            this.Controls.Add(this.lblTotalGrossPay);
            this.Controls.Add(this.lblTotalNumberPaySlips);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lblTotalNumberPaySlips;
        private System.Windows.Forms.Label lblTotalGrossPay;
        private System.Windows.Forms.Label lblTotalNetPay;
        private System.Windows.Forms.Label lblAverageNetPay;
        private System.Windows.Forms.Label lblResultTotalNumberPaySlips;
        private System.Windows.Forms.Label lblResultTotalGrossPay;
        private System.Windows.Forms.Label lblResultTotalNetPay;
        private System.Windows.Forms.Label lblResultAverageNetPay;
        private System.Windows.Forms.Label lblResultNetPay;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Button btnCreatePaySlip;
        private System.Windows.Forms.Button btnDisplaySummary;
        private System.Windows.Forms.TextBox tbxEmployeeName;
        private System.Windows.Forms.NumericUpDown nudPayRate;
        private System.Windows.Forms.NumericUpDown nudHoursWorked;
    }
}

