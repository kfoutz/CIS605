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
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCalcMaxHeight = new System.Windows.Forms.Button();
            this.btnCalcHangTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialVelocity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // nudInitialHeight
            // 
            this.nudInitialHeight.Location = new System.Drawing.Point(126, 71);
            this.nudInitialHeight.Name = "nudInitialHeight";
            this.nudInitialHeight.Size = new System.Drawing.Size(120, 20);
            this.nudInitialHeight.TabIndex = 2;
            // 
            // nudInitialVelocity
            // 
            this.nudInitialVelocity.Location = new System.Drawing.Point(126, 121);
            this.nudInitialVelocity.Name = "nudInitialVelocity";
            this.nudInitialVelocity.Size = new System.Drawing.Size(120, 20);
            this.nudInitialVelocity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(421, 78);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "label4";
            // 
            // btnCalcMaxHeight
            // 
            this.btnCalcMaxHeight.Location = new System.Drawing.Point(49, 197);
            this.btnCalcMaxHeight.Name = "btnCalcMaxHeight";
            this.btnCalcMaxHeight.Size = new System.Drawing.Size(75, 55);
            this.btnCalcMaxHeight.TabIndex = 6;
            this.btnCalcMaxHeight.Text = "Calculate Maximum Height";
            this.btnCalcMaxHeight.UseVisualStyleBackColor = true;
            this.btnCalcMaxHeight.Click += new System.EventHandler(this.btnCalcMaxHeight_Click);
            // 
            // btnCalcHangTime
            // 
            this.btnCalcHangTime.Location = new System.Drawing.Point(171, 197);
            this.btnCalcHangTime.Name = "btnCalcHangTime";
            this.btnCalcHangTime.Size = new System.Drawing.Size(75, 55);
            this.btnCalcHangTime.TabIndex = 7;
            this.btnCalcHangTime.Text = "Calculate Hang Time";
            this.btnCalcHangTime.UseVisualStyleBackColor = true;
            this.btnCalcHangTime.Click += new System.EventHandler(this.btnCalcHangTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcHangTime);
            this.Controls.Add(this.btnCalcMaxHeight);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudInitialVelocity);
            this.Controls.Add(this.nudInitialHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCalcMaxHeight;
        private System.Windows.Forms.Button btnCalcHangTime;
    }
}

