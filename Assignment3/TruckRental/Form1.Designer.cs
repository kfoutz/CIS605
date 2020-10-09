namespace TruckRental
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBeginODO = new System.Windows.Forms.Label();
            this.lblEndODO = new System.Windows.Forms.Label();
            this.lblNumDays = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.nudBeginODO = new System.Windows.Forms.NumericUpDown();
            this.nudEndODO = new System.Windows.Forms.NumericUpDown();
            this.nudDaysRented = new System.Windows.Forms.NumericUpDown();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblRentalCharge = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeginODO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndODO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysRented)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblBeginODO
            // 
            this.lblBeginODO.AutoSize = true;
            this.lblBeginODO.Location = new System.Drawing.Point(45, 58);
            this.lblBeginODO.Name = "lblBeginODO";
            this.lblBeginODO.Size = new System.Drawing.Size(146, 13);
            this.lblBeginODO.TabIndex = 1;
            this.lblBeginODO.Text = "Beginning Odometer Reading";
            // 
            // lblEndODO
            // 
            this.lblEndODO.AutoSize = true;
            this.lblEndODO.Location = new System.Drawing.Point(59, 96);
            this.lblEndODO.Name = "lblEndODO";
            this.lblEndODO.Size = new System.Drawing.Size(132, 13);
            this.lblEndODO.TabIndex = 2;
            this.lblEndODO.Text = "Ending Odometer Reading";
            // 
            // lblNumDays
            // 
            this.lblNumDays.AutoSize = true;
            this.lblNumDays.Location = new System.Drawing.Point(70, 136);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(121, 13);
            this.lblNumDays.TabIndex = 3;
            this.lblNumDays.Text = "Number of Days Rented";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(205, 25);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 4;
            // 
            // nudBeginODO
            // 
            this.nudBeginODO.Location = new System.Drawing.Point(205, 59);
            this.nudBeginODO.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBeginODO.Name = "nudBeginODO";
            this.nudBeginODO.Size = new System.Drawing.Size(120, 20);
            this.nudBeginODO.TabIndex = 5;
            // 
            // nudEndODO
            // 
            this.nudEndODO.Location = new System.Drawing.Point(205, 96);
            this.nudEndODO.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudEndODO.Name = "nudEndODO";
            this.nudEndODO.Size = new System.Drawing.Size(120, 20);
            this.nudEndODO.TabIndex = 6;
            // 
            // nudDaysRented
            // 
            this.nudDaysRented.Location = new System.Drawing.Point(205, 136);
            this.nudDaysRented.Name = "nudDaysRented";
            this.nudDaysRented.Size = new System.Drawing.Size(120, 20);
            this.nudDaysRented.TabIndex = 7;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(117, 195);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(74, 13);
            this.lblAmountDue.TabIndex = 8;
            this.lblAmountDue.Text = "Ammount Due";
            // 
            // lblRentalCharge
            // 
            this.lblRentalCharge.AutoSize = true;
            this.lblRentalCharge.Location = new System.Drawing.Point(202, 195);
            this.lblRentalCharge.Name = "lblRentalCharge";
            this.lblRentalCharge.Size = new System.Drawing.Size(0, 13);
            this.lblRentalCharge.TabIndex = 9;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(205, 226);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "&Calulate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(205, 272);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(205, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Brought to you by Kerry";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(385, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblRentalCharge);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.nudDaysRented);
            this.Controls.Add(this.nudEndODO);
            this.Controls.Add(this.nudBeginODO);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblNumDays);
            this.Controls.Add(this.lblEndODO);
            this.Controls.Add(this.lblBeginODO);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Kerry\'s Truck Rental";
            ((System.ComponentModel.ISupportInitialize)(this.nudBeginODO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndODO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysRented)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBeginODO;
        private System.Windows.Forms.Label lblEndODO;
        private System.Windows.Forms.Label lblNumDays;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.NumericUpDown nudBeginODO;
        private System.Windows.Forms.NumericUpDown nudEndODO;
        private System.Windows.Forms.NumericUpDown nudDaysRented;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblRentalCharge;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

