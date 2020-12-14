namespace CIS605FinalExam
{
    partial class SalesPersonForm
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
            this.lblMonthlyCommission = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lstHighPerformers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblaverageMonthlyCommission = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCarsSold = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.grpSalesPersonData = new System.Windows.Forms.GroupBox();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarsSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.grpSalesPersonData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMonthlyCommission
            // 
            this.lblMonthlyCommission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonthlyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyCommission.Location = new System.Drawing.Point(222, 190);
            this.lblMonthlyCommission.Name = "lblMonthlyCommission";
            this.lblMonthlyCommission.Size = new System.Drawing.Size(201, 26);
            this.lblMonthlyCommission.TabIndex = 12;
            this.lblMonthlyCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lstHighPerformers);
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Controls.Add(this.lblaverageMonthlyCommission);
            this.grpSummary.Controls.Add(this.label8);
            this.grpSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSummary.Location = new System.Drawing.Point(10, 266);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(446, 292);
            this.grpSummary.TabIndex = 1;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary:";
            // 
            // lstHighPerformers
            // 
            this.lstHighPerformers.FormattingEnabled = true;
            this.lstHighPerformers.ItemHeight = 20;
            this.lstHighPerformers.Location = new System.Drawing.Point(161, 122);
            this.lstHighPerformers.Name = "lstHighPerformers";
            this.lstHighPerformers.Size = new System.Drawing.Size(148, 164);
            this.lstHighPerformers.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 44);
            this.label4.TabIndex = 23;
            this.label4.Text = "High Performer(s)";
            // 
            // lblaverageMonthlyCommission
            // 
            this.lblaverageMonthlyCommission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblaverageMonthlyCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverageMonthlyCommission.Location = new System.Drawing.Point(16, 70);
            this.lblaverageMonthlyCommission.Name = "lblaverageMonthlyCommission";
            this.lblaverageMonthlyCommission.Size = new System.Drawing.Size(127, 27);
            this.lblaverageMonthlyCommission.TabIndex = 18;
            this.lblaverageMonthlyCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Average Monthly Commission:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(327, 564);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(26, 564);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 28);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salesperson Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Cars Sold:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dollar Value of Cars Sold:";
            // 
            // nudCarsSold
            // 
            this.nudCarsSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCarsSold.Location = new System.Drawing.Point(222, 74);
            this.nudCarsSold.Name = "nudCarsSold";
            this.nudCarsSold.Size = new System.Drawing.Size(201, 26);
            this.nudCarsSold.TabIndex = 6;
            this.nudCarsSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(222, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 26);
            this.txtName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Monthly Commission:";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(222, 150);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(201, 28);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Salesperson";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // nudValue
            // 
            this.nudValue.DecimalPlaces = 2;
            this.nudValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValue.Location = new System.Drawing.Point(222, 112);
            this.nudValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(201, 26);
            this.nudValue.TabIndex = 14;
            this.nudValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpSalesPersonData
            // 
            this.grpSalesPersonData.Controls.Add(this.nudValue);
            this.grpSalesPersonData.Controls.Add(this.btnCreate);
            this.grpSalesPersonData.Controls.Add(this.label5);
            this.grpSalesPersonData.Controls.Add(this.txtName);
            this.grpSalesPersonData.Controls.Add(this.nudCarsSold);
            this.grpSalesPersonData.Controls.Add(this.label3);
            this.grpSalesPersonData.Controls.Add(this.label2);
            this.grpSalesPersonData.Controls.Add(this.label1);
            this.grpSalesPersonData.Controls.Add(this.lblMonthlyCommission);
            this.grpSalesPersonData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSalesPersonData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSalesPersonData.Location = new System.Drawing.Point(10, 26);
            this.grpSalesPersonData.Name = "grpSalesPersonData";
            this.grpSalesPersonData.Size = new System.Drawing.Size(446, 234);
            this.grpSalesPersonData.TabIndex = 0;
            this.grpSalesPersonData.TabStop = false;
            this.grpSalesPersonData.Text = "Salesperson Data:";
            // 
            // SalesPersonForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(476, 606);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpSalesPersonData);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SalesPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIS 605 - Final Exam";
            this.grpSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCarsSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.grpSalesPersonData.ResumeLayout(false);
            this.grpSalesPersonData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMonthlyCommission;
        private System.Windows.Forms.Label lblaverageMonthlyCommission;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCarsSold;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.GroupBox grpSalesPersonData;
        private System.Windows.Forms.ListBox lstHighPerformers;
        private System.Windows.Forms.Label label4;
    }
}

