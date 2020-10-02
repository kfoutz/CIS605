namespace BMI_Calulation
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
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.nudIn = new System.Windows.Forms.NumericUpDown();
            this.btnCalcBMI = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblBMIcalc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(44, 80);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(44, 122);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(139, 23);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight (Lbs.)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(44, 169);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(157, 23);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (inches)";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(235, 76);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(151, 22);
            this.tbxName.TabIndex = 3;
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(235, 118);
            this.nudWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(152, 22);
            this.nudWeight.TabIndex = 4;
            // 
            // nudIn
            // 
            this.nudIn.Location = new System.Drawing.Point(235, 166);
            this.nudIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudIn.Name = "nudIn";
            this.nudIn.Size = new System.Drawing.Size(152, 22);
            this.nudIn.TabIndex = 6;
            // 
            // btnCalcBMI
            // 
            this.btnCalcBMI.Location = new System.Drawing.Point(201, 306);
            this.btnCalcBMI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcBMI.Name = "btnCalcBMI";
            this.btnCalcBMI.Size = new System.Drawing.Size(100, 43);
            this.btnCalcBMI.TabIndex = 9;
            this.btnCalcBMI.Text = "&Calculate BMI";
            this.btnCalcBMI.UseVisualStyleBackColor = true;
            this.btnCalcBMI.Click += new System.EventHandler(this.btnCalcBMI_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(201, 357);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(44, 224);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(47, 23);
            this.lblBMI.TabIndex = 11;
            this.lblBMI.Text = "BMI";
            // 
            // lblBMIcalc
            // 
            this.lblBMIcalc.AutoSize = true;
            this.lblBMIcalc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMIcalc.Location = new System.Drawing.Point(231, 224);
            this.lblBMIcalc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBMIcalc.Name = "lblBMIcalc";
            this.lblBMIcalc.Size = new System.Drawing.Size(0, 23);
            this.lblBMIcalc.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 554);
            this.Controls.Add(this.lblBMIcalc);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalcBMI);
            this.Controls.Add(this.nudIn);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.NumericUpDown nudIn;
        private System.Windows.Forms.Button btnCalcBMI;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblBMIcalc;
    }
}

