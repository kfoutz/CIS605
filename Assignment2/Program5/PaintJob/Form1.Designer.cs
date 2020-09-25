namespace Program5_PaintJob
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.nudSqFt = new System.Windows.Forms.NumericUpDown();
            this.nudCostGallon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSqFt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostGallon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Square footage to be painted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost of 1 gallon of paint";
            // 
            // btnEstimate
            // 
            this.btnEstimate.Location = new System.Drawing.Point(262, 146);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(75, 42);
            this.btnEstimate.TabIndex = 4;
            this.btnEstimate.Text = "Estimate Cost";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEtimate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(262, 194);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(262, 232);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(77, 159);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 16);
            this.lblTotalCost.TabIndex = 7;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(13, 232);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(114, 16);
            this.lblCredit.TabIndex = 8;
            this.lblCredit.Text = "Powered by Kerry";
            // 
            // nudSqFt
            // 
            this.nudSqFt.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSqFt.Location = new System.Drawing.Point(262, 69);
            this.nudSqFt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSqFt.Name = "nudSqFt";
            this.nudSqFt.Size = new System.Drawing.Size(75, 22);
            this.nudSqFt.TabIndex = 9;
            this.nudSqFt.ValueChanged += new System.EventHandler(this.nudSqFt_ValueChanged);
            // 
            // nudCostGallon
            // 
            this.nudCostGallon.DecimalPlaces = 2;
            this.nudCostGallon.Location = new System.Drawing.Point(262, 106);
            this.nudCostGallon.Name = "nudCostGallon";
            this.nudCostGallon.Size = new System.Drawing.Size(75, 22);
            this.nudCostGallon.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(391, 296);
            this.Controls.Add(this.nudCostGallon);
            this.Controls.Add(this.nudSqFt);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painting Est-O-Matic";
            ((System.ComponentModel.ISupportInitialize)(this.nudSqFt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostGallon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.NumericUpDown nudSqFt;
        private System.Windows.Forms.NumericUpDown nudCostGallon;
    }
}

