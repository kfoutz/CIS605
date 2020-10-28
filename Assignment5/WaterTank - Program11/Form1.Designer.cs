namespace WaterTank___Program11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.btnCreateWaterTank = new System.Windows.Forms.Button();
            this.gbxWaterTankData = new System.Windows.Forms.GroupBox();
            this.btnCurrentWaterLevel = new System.Windows.Forms.Button();
            this.tbxCurrentWaterLevel = new System.Windows.Forms.TextBox();
            this.tbxMaximumCapacity = new System.Windows.Forms.TextBox();
            this.btnMaximumCapacity = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radAddWater = new System.Windows.Forms.RadioButton();
            this.radWithdraw = new System.Windows.Forms.RadioButton();
            this.lblLiters = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.btn = new System.Windows.Forms.Button();
            this.gbxFillDrainWater = new System.Windows.Forms.GroupBox();
            this.radFill = new System.Windows.Forms.RadioButton();
            this.radDrain = new System.Windows.Forms.RadioButton();
            this.tbxFillDrain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFillDrain = new System.Windows.Forms.NumericUpDown();
            this.btnFillDrain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            this.gbxWaterTankData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.gbxFillDrainWater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFillDrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateWaterTank);
            this.groupBox1.Controls.Add(this.nudDepth);
            this.groupBox1.Controls.Add(this.nudRadius);
            this.groupBox1.Controls.Add(this.lblDepth);
            this.groupBox1.Controls.Add(this.lblRadius);
            this.groupBox1.Location = new System.Drawing.Point(28, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Water Tank Dimensions";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(7, 20);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(7, 50);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(36, 13);
            this.lblDepth.TabIndex = 1;
            this.lblDepth.Text = "Depth";
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(124, 20);
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(120, 20);
            this.nudRadius.TabIndex = 2;
            // 
            // nudDepth
            // 
            this.nudDepth.Location = new System.Drawing.Point(124, 50);
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(120, 20);
            this.nudDepth.TabIndex = 3;
            // 
            // btnCreateWaterTank
            // 
            this.btnCreateWaterTank.Location = new System.Drawing.Point(69, 93);
            this.btnCreateWaterTank.Name = "btnCreateWaterTank";
            this.btnCreateWaterTank.Size = new System.Drawing.Size(107, 23);
            this.btnCreateWaterTank.TabIndex = 4;
            this.btnCreateWaterTank.Text = "Create Water Tank";
            this.btnCreateWaterTank.UseVisualStyleBackColor = true;
            this.btnCreateWaterTank.Click += new System.EventHandler(this.btnCreateWaterTank_Click);
            // 
            // gbxWaterTankData
            // 
            this.gbxWaterTankData.Controls.Add(this.tbxMaximumCapacity);
            this.gbxWaterTankData.Controls.Add(this.btnMaximumCapacity);
            this.gbxWaterTankData.Controls.Add(this.tbxCurrentWaterLevel);
            this.gbxWaterTankData.Controls.Add(this.btnCurrentWaterLevel);
            this.gbxWaterTankData.Location = new System.Drawing.Point(28, 170);
            this.gbxWaterTankData.Name = "gbxWaterTankData";
            this.gbxWaterTankData.Size = new System.Drawing.Size(258, 99);
            this.gbxWaterTankData.TabIndex = 1;
            this.gbxWaterTankData.TabStop = false;
            this.gbxWaterTankData.Text = "Water Tank Data";
            // 
            // btnCurrentWaterLevel
            // 
            this.btnCurrentWaterLevel.Location = new System.Drawing.Point(7, 20);
            this.btnCurrentWaterLevel.Name = "btnCurrentWaterLevel";
            this.btnCurrentWaterLevel.Size = new System.Drawing.Size(110, 23);
            this.btnCurrentWaterLevel.TabIndex = 0;
            this.btnCurrentWaterLevel.Text = "Current Water Level";
            this.btnCurrentWaterLevel.UseVisualStyleBackColor = true;
            // 
            // tbxCurrentWaterLevel
            // 
            this.tbxCurrentWaterLevel.Location = new System.Drawing.Point(124, 20);
            this.tbxCurrentWaterLevel.Name = "tbxCurrentWaterLevel";
            this.tbxCurrentWaterLevel.Size = new System.Drawing.Size(128, 20);
            this.tbxCurrentWaterLevel.TabIndex = 1;
            // 
            // tbxMaximumCapacity
            // 
            this.tbxMaximumCapacity.Location = new System.Drawing.Point(124, 49);
            this.tbxMaximumCapacity.Name = "tbxMaximumCapacity";
            this.tbxMaximumCapacity.Size = new System.Drawing.Size(128, 20);
            this.tbxMaximumCapacity.TabIndex = 3;
            // 
            // btnMaximumCapacity
            // 
            this.btnMaximumCapacity.Location = new System.Drawing.Point(7, 49);
            this.btnMaximumCapacity.Name = "btnMaximumCapacity";
            this.btnMaximumCapacity.Size = new System.Drawing.Size(110, 23);
            this.btnMaximumCapacity.TabIndex = 2;
            this.btnMaximumCapacity.Text = "Maximum Capacity";
            this.btnMaximumCapacity.UseVisualStyleBackColor = true;
            this.btnMaximumCapacity.Click += new System.EventHandler(this.btnMaximumCapacity_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn);
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.lblLiters);
            this.groupBox2.Controls.Add(this.radWithdraw);
            this.groupBox2.Controls.Add(this.radAddWater);
            this.groupBox2.Location = new System.Drawing.Point(28, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add/Withdraw Water";
            // 
            // radAddWater
            // 
            this.radAddWater.AutoSize = true;
            this.radAddWater.Location = new System.Drawing.Point(10, 20);
            this.radAddWater.Name = "radAddWater";
            this.radAddWater.Size = new System.Drawing.Size(44, 17);
            this.radAddWater.TabIndex = 0;
            this.radAddWater.TabStop = true;
            this.radAddWater.Text = "Add";
            this.radAddWater.UseVisualStyleBackColor = true;
            // 
            // radWithdraw
            // 
            this.radWithdraw.AutoSize = true;
            this.radWithdraw.Location = new System.Drawing.Point(10, 56);
            this.radWithdraw.Name = "radWithdraw";
            this.radWithdraw.Size = new System.Drawing.Size(70, 17);
            this.radWithdraw.TabIndex = 1;
            this.radWithdraw.TabStop = true;
            this.radWithdraw.Text = "Withdraw";
            this.radWithdraw.UseVisualStyleBackColor = true;
            // 
            // lblLiters
            // 
            this.lblLiters.AutoSize = true;
            this.lblLiters.Location = new System.Drawing.Point(109, 20);
            this.lblLiters.Name = "lblLiters";
            this.lblLiters.Size = new System.Drawing.Size(35, 13);
            this.lblLiters.TabIndex = 2;
            this.lblLiters.Text = "Liters:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(150, 17);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown3.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(124, 56);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(128, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "Add/ Withdraw Water";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // gbxFillDrainWater
            // 
            this.gbxFillDrainWater.Controls.Add(this.pictureBox1);
            this.gbxFillDrainWater.Controls.Add(this.btnFillDrain);
            this.gbxFillDrainWater.Controls.Add(this.nudFillDrain);
            this.gbxFillDrainWater.Controls.Add(this.label1);
            this.gbxFillDrainWater.Controls.Add(this.tbxFillDrain);
            this.gbxFillDrainWater.Controls.Add(this.radDrain);
            this.gbxFillDrainWater.Controls.Add(this.radFill);
            this.gbxFillDrainWater.Location = new System.Drawing.Point(345, 34);
            this.gbxFillDrainWater.Name = "gbxFillDrainWater";
            this.gbxFillDrainWater.Size = new System.Drawing.Size(387, 337);
            this.gbxFillDrainWater.TabIndex = 3;
            this.gbxFillDrainWater.TabStop = false;
            this.gbxFillDrainWater.Text = "Fill/Drain Water";
            // 
            // radFill
            // 
            this.radFill.AutoSize = true;
            this.radFill.Location = new System.Drawing.Point(17, 32);
            this.radFill.Name = "radFill";
            this.radFill.Size = new System.Drawing.Size(37, 17);
            this.radFill.TabIndex = 0;
            this.radFill.TabStop = true;
            this.radFill.Text = "Fill";
            this.radFill.UseVisualStyleBackColor = true;
            // 
            // radDrain
            // 
            this.radDrain.AutoSize = true;
            this.radDrain.Location = new System.Drawing.Point(17, 55);
            this.radDrain.Name = "radDrain";
            this.radDrain.Size = new System.Drawing.Size(50, 17);
            this.radDrain.TabIndex = 1;
            this.radDrain.TabStop = true;
            this.radDrain.Text = "Drain";
            this.radDrain.UseVisualStyleBackColor = true;
            // 
            // tbxFillDrain
            // 
            this.tbxFillDrain.Location = new System.Drawing.Point(17, 93);
            this.tbxFillDrain.Multiline = true;
            this.tbxFillDrain.Name = "tbxFillDrain";
            this.tbxFillDrain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxFillDrain.Size = new System.Drawing.Size(100, 228);
            this.tbxFillDrain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liters per Second";
            // 
            // nudFillDrain
            // 
            this.nudFillDrain.Location = new System.Drawing.Point(246, 32);
            this.nudFillDrain.Name = "nudFillDrain";
            this.nudFillDrain.Size = new System.Drawing.Size(120, 20);
            this.nudFillDrain.TabIndex = 4;
            // 
            // btnFillDrain
            // 
            this.btnFillDrain.Location = new System.Drawing.Point(188, 93);
            this.btnFillDrain.Name = "btnFillDrain";
            this.btnFillDrain.Size = new System.Drawing.Size(75, 37);
            this.btnFillDrain.TabIndex = 5;
            this.btnFillDrain.Text = "Fill/Drain Water";
            this.btnFillDrain.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(656, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 433);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbxFillDrainWater);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxWaterTankData);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Water Tank Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            this.gbxWaterTankData.ResumeLayout(false);
            this.gbxWaterTankData.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.gbxFillDrainWater.ResumeLayout(false);
            this.gbxFillDrainWater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFillDrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateWaterTank;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.GroupBox gbxWaterTankData;
        private System.Windows.Forms.TextBox tbxMaximumCapacity;
        private System.Windows.Forms.Button btnMaximumCapacity;
        private System.Windows.Forms.TextBox tbxCurrentWaterLevel;
        private System.Windows.Forms.Button btnCurrentWaterLevel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label lblLiters;
        private System.Windows.Forms.RadioButton radWithdraw;
        private System.Windows.Forms.RadioButton radAddWater;
        private System.Windows.Forms.GroupBox gbxFillDrainWater;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFillDrain;
        private System.Windows.Forms.NumericUpDown nudFillDrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFillDrain;
        private System.Windows.Forms.RadioButton radDrain;
        private System.Windows.Forms.RadioButton radFill;
        private System.Windows.Forms.Button btnExit;
    }
}

