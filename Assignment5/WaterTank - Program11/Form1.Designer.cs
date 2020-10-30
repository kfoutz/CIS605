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
            this.grpWaterTank = new System.Windows.Forms.GroupBox();
            this.btnCreateWaterTank = new System.Windows.Forms.Button();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.grpWaterTankData = new System.Windows.Forms.GroupBox();
            this.tbxMaximumCapacity = new System.Windows.Forms.TextBox();
            this.btnMaximumCapacity = new System.Windows.Forms.Button();
            this.tbxCurrentWaterLevel = new System.Windows.Forms.TextBox();
            this.btnCurrentWaterLevel = new System.Windows.Forms.Button();
            this.grpAddWithdraw = new System.Windows.Forms.GroupBox();
            this.btnAddWithdrawWater = new System.Windows.Forms.Button();
            this.nudLiters = new System.Windows.Forms.NumericUpDown();
            this.lblLiters = new System.Windows.Forms.Label();
            this.radWithdraw = new System.Windows.Forms.RadioButton();
            this.radAddWater = new System.Windows.Forms.RadioButton();
            this.grpFillDrainWater = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFillDrain = new System.Windows.Forms.Button();
            this.nudFillDrain = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFillDrain = new System.Windows.Forms.TextBox();
            this.radDrain = new System.Windows.Forms.RadioButton();
            this.radFill = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpWaterTank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            this.grpWaterTankData.SuspendLayout();
            this.grpAddWithdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiters)).BeginInit();
            this.grpFillDrainWater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFillDrain)).BeginInit();
            this.SuspendLayout();
            // 
            // grpWaterTank
            // 
            this.grpWaterTank.Controls.Add(this.btnCreateWaterTank);
            this.grpWaterTank.Controls.Add(this.nudDepth);
            this.grpWaterTank.Controls.Add(this.nudRadius);
            this.grpWaterTank.Controls.Add(this.lblDepth);
            this.grpWaterTank.Controls.Add(this.lblRadius);
            this.grpWaterTank.Location = new System.Drawing.Point(28, 34);
            this.grpWaterTank.Name = "grpWaterTank";
            this.grpWaterTank.Size = new System.Drawing.Size(258, 130);
            this.grpWaterTank.TabIndex = 0;
            this.grpWaterTank.TabStop = false;
            this.grpWaterTank.Text = "Water Tank Dimensions";
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
            // nudDepth
            // 
            this.nudDepth.Location = new System.Drawing.Point(124, 50);
            this.nudDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(120, 20);
            this.nudDepth.TabIndex = 3;
            this.nudDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(124, 20);
            this.nudRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(120, 20);
            this.nudRadius.TabIndex = 2;
            this.nudRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(7, 20);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius";
            // 
            // grpWaterTankData
            // 
            this.grpWaterTankData.Controls.Add(this.tbxMaximumCapacity);
            this.grpWaterTankData.Controls.Add(this.btnMaximumCapacity);
            this.grpWaterTankData.Controls.Add(this.tbxCurrentWaterLevel);
            this.grpWaterTankData.Controls.Add(this.btnCurrentWaterLevel);
            this.grpWaterTankData.Location = new System.Drawing.Point(28, 170);
            this.grpWaterTankData.Name = "grpWaterTankData";
            this.grpWaterTankData.Size = new System.Drawing.Size(258, 99);
            this.grpWaterTankData.TabIndex = 1;
            this.grpWaterTankData.TabStop = false;
            this.grpWaterTankData.Text = "Water Tank Data";
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
            // tbxCurrentWaterLevel
            // 
            this.tbxCurrentWaterLevel.Location = new System.Drawing.Point(124, 20);
            this.tbxCurrentWaterLevel.Name = "tbxCurrentWaterLevel";
            this.tbxCurrentWaterLevel.Size = new System.Drawing.Size(128, 20);
            this.tbxCurrentWaterLevel.TabIndex = 1;
            // 
            // btnCurrentWaterLevel
            // 
            this.btnCurrentWaterLevel.Location = new System.Drawing.Point(7, 20);
            this.btnCurrentWaterLevel.Name = "btnCurrentWaterLevel";
            this.btnCurrentWaterLevel.Size = new System.Drawing.Size(110, 23);
            this.btnCurrentWaterLevel.TabIndex = 0;
            this.btnCurrentWaterLevel.Text = "Current Water Level";
            this.btnCurrentWaterLevel.UseVisualStyleBackColor = true;
            this.btnCurrentWaterLevel.Click += new System.EventHandler(this.btnCurrentWaterLevel_Click);
            // 
            // grpAddWithdraw
            // 
            this.grpAddWithdraw.Controls.Add(this.btnAddWithdrawWater);
            this.grpAddWithdraw.Controls.Add(this.nudLiters);
            this.grpAddWithdraw.Controls.Add(this.lblLiters);
            this.grpAddWithdraw.Controls.Add(this.radWithdraw);
            this.grpAddWithdraw.Controls.Add(this.radAddWater);
            this.grpAddWithdraw.Location = new System.Drawing.Point(28, 276);
            this.grpAddWithdraw.Name = "grpAddWithdraw";
            this.grpAddWithdraw.Size = new System.Drawing.Size(258, 95);
            this.grpAddWithdraw.TabIndex = 2;
            this.grpAddWithdraw.TabStop = false;
            this.grpAddWithdraw.Text = "Add/Withdraw Water";
            // 
            // btnAddWithdrawWater
            // 
            this.btnAddWithdrawWater.Location = new System.Drawing.Point(124, 56);
            this.btnAddWithdrawWater.Name = "btnAddWithdrawWater";
            this.btnAddWithdrawWater.Size = new System.Drawing.Size(128, 23);
            this.btnAddWithdrawWater.TabIndex = 4;
            this.btnAddWithdrawWater.Text = "Add/ Withdraw Water";
            this.btnAddWithdrawWater.UseVisualStyleBackColor = true;
            this.btnAddWithdrawWater.Click += new System.EventHandler(this.btnAddWithdrawWater_Click);
            // 
            // nudLiters
            // 
            this.nudLiters.Location = new System.Drawing.Point(150, 17);
            this.nudLiters.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudLiters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLiters.Name = "nudLiters";
            this.nudLiters.Size = new System.Drawing.Size(102, 20);
            this.nudLiters.TabIndex = 3;
            this.nudLiters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // grpFillDrainWater
            // 
            this.grpFillDrainWater.Controls.Add(this.pictureBox1);
            this.grpFillDrainWater.Controls.Add(this.btnFillDrain);
            this.grpFillDrainWater.Controls.Add(this.nudFillDrain);
            this.grpFillDrainWater.Controls.Add(this.label1);
            this.grpFillDrainWater.Controls.Add(this.tbxFillDrain);
            this.grpFillDrainWater.Controls.Add(this.radDrain);
            this.grpFillDrainWater.Controls.Add(this.radFill);
            this.grpFillDrainWater.Location = new System.Drawing.Point(345, 34);
            this.grpFillDrainWater.Name = "grpFillDrainWater";
            this.grpFillDrainWater.Size = new System.Drawing.Size(387, 337);
            this.grpFillDrainWater.TabIndex = 3;
            this.grpFillDrainWater.TabStop = false;
            this.grpFillDrainWater.Text = "Fill/Drain Water";
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
            // btnFillDrain
            // 
            this.btnFillDrain.Location = new System.Drawing.Point(188, 93);
            this.btnFillDrain.Name = "btnFillDrain";
            this.btnFillDrain.Size = new System.Drawing.Size(75, 37);
            this.btnFillDrain.TabIndex = 5;
            this.btnFillDrain.Text = "Fill/Drain Water";
            this.btnFillDrain.UseVisualStyleBackColor = true;
            this.btnFillDrain.Click += new System.EventHandler(this.btnFillDrain_Click);
            // 
            // nudFillDrain
            // 
            this.nudFillDrain.Location = new System.Drawing.Point(246, 32);
            this.nudFillDrain.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudFillDrain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFillDrain.Name = "nudFillDrain";
            this.nudFillDrain.Size = new System.Drawing.Size(120, 20);
            this.nudFillDrain.TabIndex = 4;
            this.nudFillDrain.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // tbxFillDrain
            // 
            this.tbxFillDrain.Location = new System.Drawing.Point(17, 93);
            this.tbxFillDrain.Multiline = true;
            this.tbxFillDrain.Name = "tbxFillDrain";
            this.tbxFillDrain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxFillDrain.Size = new System.Drawing.Size(100, 228);
            this.tbxFillDrain.TabIndex = 2;
            
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
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(35, 378);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(0, 13);
            this.lblUpdate.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(575, 393);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 433);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpFillDrainWater);
            this.Controls.Add(this.grpAddWithdraw);
            this.Controls.Add(this.grpWaterTankData);
            this.Controls.Add(this.grpWaterTank);
            this.Name = "Form1";
            this.Text = "Water Tank Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpWaterTank.ResumeLayout(false);
            this.grpWaterTank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            this.grpWaterTankData.ResumeLayout(false);
            this.grpWaterTankData.PerformLayout();
            this.grpAddWithdraw.ResumeLayout(false);
            this.grpAddWithdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiters)).EndInit();
            this.grpFillDrainWater.ResumeLayout(false);
            this.grpFillDrainWater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFillDrain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWaterTank;
        private System.Windows.Forms.Button btnCreateWaterTank;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.GroupBox grpWaterTankData;
        private System.Windows.Forms.TextBox tbxMaximumCapacity;
        private System.Windows.Forms.Button btnMaximumCapacity;
        private System.Windows.Forms.TextBox tbxCurrentWaterLevel;
        private System.Windows.Forms.Button btnCurrentWaterLevel;
        private System.Windows.Forms.GroupBox grpAddWithdraw;
        private System.Windows.Forms.Button btnAddWithdrawWater;
        private System.Windows.Forms.NumericUpDown nudLiters;
        private System.Windows.Forms.Label lblLiters;
        private System.Windows.Forms.RadioButton radWithdraw;
        private System.Windows.Forms.RadioButton radAddWater;
        private System.Windows.Forms.GroupBox grpFillDrainWater;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFillDrain;
        private System.Windows.Forms.NumericUpDown nudFillDrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFillDrain;
        private System.Windows.Forms.RadioButton radDrain;
        private System.Windows.Forms.RadioButton radFill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button btnReset;
    }
}

