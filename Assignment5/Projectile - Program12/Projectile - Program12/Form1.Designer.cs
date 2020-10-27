namespace Projectile___Program12
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
            this.nudInitialHeight = new System.Windows.Forms.NumericUpDown();
            this.nudInitialVelocity = new System.Windows.Forms.NumericUpDown();
            this.lblMaxHeight = new System.Windows.Forms.Label();
            this.lblHangTime = new System.Windows.Forms.Label();
            this.btnCalcMaxHeight = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialVelocity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Velocity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Initial Height";
            // 
            // nudInitialHeight
            // 
            this.nudInitialHeight.Location = new System.Drawing.Point(101, 40);
            this.nudInitialHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInitialHeight.Name = "nudInitialHeight";
            this.nudInitialHeight.Size = new System.Drawing.Size(120, 20);
            this.nudInitialHeight.TabIndex = 2;
            // 
            // nudInitialVelocity
            // 
            this.nudInitialVelocity.Location = new System.Drawing.Point(101, 90);
            this.nudInitialVelocity.Name = "nudInitialVelocity";
            this.nudInitialVelocity.Size = new System.Drawing.Size(120, 20);
            this.nudInitialVelocity.TabIndex = 3;
            // 
            // lblMaxHeight
            // 
            this.lblMaxHeight.AutoSize = true;
            this.lblMaxHeight.Location = new System.Drawing.Point(265, 42);
            this.lblMaxHeight.Name = "lblMaxHeight";
            this.lblMaxHeight.Size = new System.Drawing.Size(0, 13);
            this.lblMaxHeight.TabIndex = 4;
            // 
            // lblHangTime
            // 
            this.lblHangTime.AutoSize = true;
            this.lblHangTime.Location = new System.Drawing.Point(356, 40);
            this.lblHangTime.Name = "lblHangTime";
            this.lblHangTime.Size = new System.Drawing.Size(0, 13);
            this.lblHangTime.TabIndex = 5;
            // 
            // btnCalcMaxHeight
            // 
            this.btnCalcMaxHeight.Location = new System.Drawing.Point(65, 129);
            this.btnCalcMaxHeight.Name = "btnCalcMaxHeight";
            this.btnCalcMaxHeight.Size = new System.Drawing.Size(75, 23);
            this.btnCalcMaxHeight.TabIndex = 6;
            this.btnCalcMaxHeight.Text = "Calculate";
            this.btnCalcMaxHeight.UseVisualStyleBackColor = true;
            this.btnCalcMaxHeight.Click += new System.EventHandler(this.btnCalcMaxHeight_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(376, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maximum Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hang Time";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(146, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "KCF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 173);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalcMaxHeight);
            this.Controls.Add(this.lblHangTime);
            this.Controls.Add(this.lblMaxHeight);
            this.Controls.Add(this.nudInitialVelocity);
            this.Controls.Add(this.nudInitialHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Projectile Calculation";
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialVelocity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudInitialHeight;
        private System.Windows.Forms.NumericUpDown nudInitialVelocity;
        private System.Windows.Forms.Label lblMaxHeight;
        private System.Windows.Forms.Label lblHangTime;
        private System.Windows.Forms.Button btnCalcMaxHeight;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
    }
}

