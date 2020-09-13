namespace Program4_Loan
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
            this.intLoanAmount = new System.Windows.Forms.MaskedTextBox();
            this.intDurationLoan = new System.Windows.Forms.MaskedTextBox();
            this.intAPR = new System.Windows.Forms.MaskedTextBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(48, 90);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(70, 13);
            this.lblLoanAmount.TabIndex = 0;
            this.lblLoanAmount.Text = "Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration of Loan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Annual Intrest Rate";
            // 
            // intLoanAmount
            // 
            this.intLoanAmount.Location = new System.Drawing.Point(172, 90);
            this.intLoanAmount.Name = "intLoanAmount";
            this.intLoanAmount.Size = new System.Drawing.Size(100, 20);
            this.intLoanAmount.TabIndex = 3;
            // 
            // intDurationLoan
            // 
            this.intDurationLoan.Location = new System.Drawing.Point(172, 116);
            this.intDurationLoan.Name = "intDurationLoan";
            this.intDurationLoan.Size = new System.Drawing.Size(100, 20);
            this.intDurationLoan.TabIndex = 4;
            // 
            // intAPR
            // 
            this.intAPR.Location = new System.Drawing.Point(172, 142);
            this.intAPR.Name = "intAPR";
            this.intAPR.Size = new System.Drawing.Size(100, 20);
            this.intAPR.TabIndex = 5;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(174, 210);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(88, 13);
            this.lblMonthlyPayment.TabIndex = 6;
            this.lblMonthlyPayment.Text = "Monthly Payment";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(51, 234);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(174, 239);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(0, 13);
            this.lblPaymentAmount.TabIndex = 8;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(51, 277);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(51, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.intAPR);
            this.Controls.Add(this.intDurationLoan);
            this.Controls.Add(this.intLoanAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoanAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox intLoanAmount;
        private System.Windows.Forms.MaskedTextBox intDurationLoan;
        private System.Windows.Forms.MaskedTextBox intAPR;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

