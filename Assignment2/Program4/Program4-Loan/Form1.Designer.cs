﻿namespace Program4_Loan
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
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.nudLoanAmount = new System.Windows.Forms.NumericUpDown();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.nudAPR = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAPR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(64, 111);
            this.lblLoanAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(86, 16);
            this.lblLoanAmount.TabIndex = 0;
            this.lblLoanAmount.Text = "Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration of Loan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Annual Intrest Rate";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(232, 258);
            this.lblMonthlyPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(110, 16);
            this.lblMonthlyPayment.TabIndex = 6;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(68, 288);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 28);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(232, 294);
            this.lblPaymentAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(0, 16);
            this.lblPaymentAmount.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(68, 341);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(68, 437);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // nudLoanAmount
            // 
            this.nudLoanAmount.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudLoanAmount.Location = new System.Drawing.Point(236, 102);
            this.nudLoanAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudLoanAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLoanAmount.Name = "nudLoanAmount";
            this.nudLoanAmount.Size = new System.Drawing.Size(160, 22);
            this.nudLoanAmount.TabIndex = 11;
            this.nudLoanAmount.ThousandsSeparator = true;
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(236, 134);
            this.nudDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(160, 22);
            this.nudDuration.TabIndex = 12;
            // 
            // nudAPR
            // 
            this.nudAPR.DecimalPlaces = 2;
            this.nudAPR.Location = new System.Drawing.Point(236, 166);
            this.nudAPR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudAPR.Name = "nudAPR";
            this.nudAPR.Size = new System.Drawing.Size(160, 22);
            this.nudAPR.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.nudAPR);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.nudLoanAmount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoanAmount);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Loan Caluclation";
            ((System.ComponentModel.ISupportInitialize)(this.nudLoanAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAPR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudLoanAmount;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.NumericUpDown nudAPR;
    }
}

