namespace PropertyTax___Program10
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radCity = new System.Windows.Forms.RadioButton();
            this.radSuburb = new System.Windows.Forms.RadioButton();
            this.radRural = new System.Windows.Forms.RadioButton();
            this.tbxOwnersName = new System.Windows.Forms.TextBox();
            this.nudBuildingSquareFootage = new System.Windows.Forms.NumericUpDown();
            this.nudLandSquareFootage = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.btnCreateTax = new System.Windows.Forms.Button();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuildingSquareFootage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandSquareFootage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Owner\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Building Square Footage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Land Square Footage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year Built";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Poperty Location";
            // 
            // radCity
            // 
            this.radCity.AutoSize = true;
            this.radCity.Location = new System.Drawing.Point(39, 257);
            this.radCity.Name = "radCity";
            this.radCity.Size = new System.Drawing.Size(42, 17);
            this.radCity.TabIndex = 6;
            this.radCity.TabStop = true;
            this.radCity.Text = "City";
            this.radCity.UseVisualStyleBackColor = true;
            // 
            // radSuburb
            // 
            this.radSuburb.AutoSize = true;
            this.radSuburb.Location = new System.Drawing.Point(86, 257);
            this.radSuburb.Name = "radSuburb";
            this.radSuburb.Size = new System.Drawing.Size(59, 17);
            this.radSuburb.TabIndex = 7;
            this.radSuburb.TabStop = true;
            this.radSuburb.Text = "Suburb";
            this.radSuburb.UseVisualStyleBackColor = true;
            // 
            // radRural
            // 
            this.radRural.AutoSize = true;
            this.radRural.Location = new System.Drawing.Point(151, 257);
            this.radRural.Name = "radRural";
            this.radRural.Size = new System.Drawing.Size(50, 17);
            this.radRural.TabIndex = 8;
            this.radRural.TabStop = true;
            this.radRural.Text = "Rural";
            this.radRural.UseVisualStyleBackColor = true;
            // 
            // tbxOwnersName
            // 
            this.tbxOwnersName.Location = new System.Drawing.Point(175, 83);
            this.tbxOwnersName.MaxLength = 25;
            this.tbxOwnersName.Name = "tbxOwnersName";
            this.tbxOwnersName.Size = new System.Drawing.Size(100, 20);
            this.tbxOwnersName.TabIndex = 9;
            // 
            // nudBuildingSquareFootage
            // 
            this.nudBuildingSquareFootage.Location = new System.Drawing.Point(175, 123);
            this.nudBuildingSquareFootage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBuildingSquareFootage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBuildingSquareFootage.Name = "nudBuildingSquareFootage";
            this.nudBuildingSquareFootage.Size = new System.Drawing.Size(120, 20);
            this.nudBuildingSquareFootage.TabIndex = 10;
            this.nudBuildingSquareFootage.ThousandsSeparator = true;
            this.nudBuildingSquareFootage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudLandSquareFootage
            // 
            this.nudLandSquareFootage.Location = new System.Drawing.Point(175, 155);
            this.nudLandSquareFootage.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudLandSquareFootage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLandSquareFootage.Name = "nudLandSquareFootage";
            this.nudLandSquareFootage.Size = new System.Drawing.Size(120, 20);
            this.nudLandSquareFootage.TabIndex = 11;
            this.nudLandSquareFootage.ThousandsSeparator = true;
            this.nudLandSquareFootage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYear
            // 
            this.nudYear.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nudYear.Location = new System.Drawing.Point(175, 185);
            this.nudYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(120, 20);
            this.nudYear.TabIndex = 12;
            // 
            // btnCreateTax
            // 
            this.btnCreateTax.Location = new System.Drawing.Point(345, 14);
            this.btnCreateTax.Name = "btnCreateTax";
            this.btnCreateTax.Size = new System.Drawing.Size(75, 51);
            this.btnCreateTax.TabIndex = 13;
            this.btnCreateTax.Text = "Calculate Property Tax";
            this.btnCreateTax.UseVisualStyleBackColor = true;
            this.btnCreateTax.Click += new System.EventHandler(this.btnCreateTax_Click);
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(342, 114);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(0, 13);
            this.lblTaxes.TabIndex = 14;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(302, 273);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 28);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(392, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 343);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.btnCreateTax);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.nudLandSquareFootage);
            this.Controls.Add(this.nudBuildingSquareFootage);
            this.Controls.Add(this.tbxOwnersName);
            this.Controls.Add(this.radRural);
            this.Controls.Add(this.radSuburb);
            this.Controls.Add(this.radCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Property Tax Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBuildingSquareFootage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandSquareFootage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radCity;
        private System.Windows.Forms.RadioButton radSuburb;
        private System.Windows.Forms.RadioButton radRural;
        private System.Windows.Forms.TextBox tbxOwnersName;
        private System.Windows.Forms.NumericUpDown nudBuildingSquareFootage;
        private System.Windows.Forms.NumericUpDown nudLandSquareFootage;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Button btnCreateTax;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

