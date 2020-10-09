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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(33, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(33, 99);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(113, 18);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Weight (Lbs.)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(33, 137);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(129, 18);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (inches)";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(176, 62);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(114, 20);
            this.tbxName.TabIndex = 3;
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(176, 96);
            this.nudWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(114, 20);
            this.nudWeight.TabIndex = 4;
            // 
            // nudIn
            // 
            this.nudIn.Location = new System.Drawing.Point(176, 135);
            this.nudIn.Name = "nudIn";
            this.nudIn.Size = new System.Drawing.Size(114, 20);
            this.nudIn.TabIndex = 6;
            // 
            // btnCalcBMI
            // 
            this.btnCalcBMI.Location = new System.Drawing.Point(36, 220);
            this.btnCalcBMI.Name = "btnCalcBMI";
            this.btnCalcBMI.Size = new System.Drawing.Size(75, 35);
            this.btnCalcBMI.TabIndex = 9;
            this.btnCalcBMI.Text = "&Calculate BMI";
            this.btnCalcBMI.UseVisualStyleBackColor = true;
            this.btnCalcBMI.Click += new System.EventHandler(this.btnCalcBMI_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(71, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMI.Location = new System.Drawing.Point(33, 182);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(43, 18);
            this.lblBMI.TabIndex = 11;
            this.lblBMI.Text = "BMI:";
            // 
            // lblBMIcalc
            // 
            this.lblBMIcalc.AutoSize = true;
            this.lblBMIcalc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMIcalc.Location = new System.Drawing.Point(173, 182);
            this.lblBMIcalc.Name = "lblBMIcalc";
            this.lblBMIcalc.Size = new System.Drawing.Size(0, 18);
            this.lblBMIcalc.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "2020 Kerry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
            this.Name = "Form1";
            this.Text = "Body Mass Index Calculator";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

