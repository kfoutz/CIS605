namespace CSU_Conference_Serivices___Program_9
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
            this.tbxConferenceName = new System.Windows.Forms.TextBox();
            this.nudNumAttendees = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNumNights = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radSingle = new System.Windows.Forms.RadioButton();
            this.radDouble = new System.Windows.Forms.RadioButton();
            this.radSuite = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxInternet = new System.Windows.Forms.CheckBox();
            this.cbxGym = new System.Windows.Forms.CheckBox();
            this.btnCreateConf = new System.Windows.Forms.Button();
            this.btnModifyConf = new System.Windows.Forms.Button();
            this.lblCharges = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumAttendees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumNights)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conference Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Attendees";
            // 
            // tbxConferenceName
            // 
            this.tbxConferenceName.Location = new System.Drawing.Point(130, 46);
            this.tbxConferenceName.Name = "tbxConferenceName";
            this.tbxConferenceName.Size = new System.Drawing.Size(100, 20);
            this.tbxConferenceName.TabIndex = 2;
            // 
            // nudNumAttendees
            // 
            this.nudNumAttendees.Location = new System.Drawing.Point(130, 73);
            this.nudNumAttendees.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumAttendees.Name = "nudNumAttendees";
            this.nudNumAttendees.Size = new System.Drawing.Size(120, 20);
            this.nudNumAttendees.TabIndex = 3;
            this.nudNumAttendees.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Nights";
            // 
            // nudNumNights
            // 
            this.nudNumNights.Location = new System.Drawing.Point(130, 109);
            this.nudNumNights.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumNights.Name = "nudNumNights";
            this.nudNumNights.Size = new System.Drawing.Size(120, 20);
            this.nudNumNights.TabIndex = 5;
            this.nudNumNights.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Room Type";
            // 
            // radSingle
            // 
            this.radSingle.AutoSize = true;
            this.radSingle.Location = new System.Drawing.Point(98, 16);
            this.radSingle.Name = "radSingle";
            this.radSingle.Size = new System.Drawing.Size(85, 17);
            this.radSingle.TabIndex = 9;
            this.radSingle.TabStop = true;
            this.radSingle.Text = "Single Room";
            this.radSingle.UseVisualStyleBackColor = true;
            // 
            // radDouble
            // 
            this.radDouble.AutoSize = true;
            this.radDouble.Location = new System.Drawing.Point(98, 46);
            this.radDouble.Name = "radDouble";
            this.radDouble.Size = new System.Drawing.Size(90, 17);
            this.radDouble.TabIndex = 10;
            this.radDouble.TabStop = true;
            this.radDouble.Text = "Double Room";
            this.radDouble.UseVisualStyleBackColor = true;
            // 
            // radSuite
            // 
            this.radSuite.AutoSize = true;
            this.radSuite.Location = new System.Drawing.Point(98, 79);
            this.radSuite.Name = "radSuite";
            this.radSuite.Size = new System.Drawing.Size(49, 17);
            this.radSuite.TabIndex = 11;
            this.radSuite.TabStop = true;
            this.radSuite.Text = "Suite";
            this.radSuite.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ammenities";
            // 
            // cbxInternet
            // 
            this.cbxInternet.AutoSize = true;
            this.cbxInternet.Location = new System.Drawing.Point(76, 28);
            this.cbxInternet.Name = "cbxInternet";
            this.cbxInternet.Size = new System.Drawing.Size(100, 17);
            this.cbxInternet.TabIndex = 14;
            this.cbxInternet.Text = "Internet Access";
            this.cbxInternet.UseVisualStyleBackColor = true;
            // 
            // cbxGym
            // 
            this.cbxGym.AutoSize = true;
            this.cbxGym.Location = new System.Drawing.Point(76, 64);
            this.cbxGym.Name = "cbxGym";
            this.cbxGym.Size = new System.Drawing.Size(118, 17);
            this.cbxGym.TabIndex = 15;
            this.cbxGym.Text = "Rec Center Access";
            this.cbxGym.UseVisualStyleBackColor = true;
            // 
            // btnCreateConf
            // 
            this.btnCreateConf.Location = new System.Drawing.Point(66, 354);
            this.btnCreateConf.Name = "btnCreateConf";
            this.btnCreateConf.Size = new System.Drawing.Size(75, 23);
            this.btnCreateConf.TabIndex = 16;
            this.btnCreateConf.Text = "Reserve";
            this.btnCreateConf.UseVisualStyleBackColor = true;
            this.btnCreateConf.Click += new System.EventHandler(this.btnCreateConf_Click);
            // 
            // btnModifyConf
            // 
            this.btnModifyConf.Location = new System.Drawing.Point(167, 354);
            this.btnModifyConf.Name = "btnModifyConf";
            this.btnModifyConf.Size = new System.Drawing.Size(75, 23);
            this.btnModifyConf.TabIndex = 17;
            this.btnModifyConf.Text = "Modify";
            this.btnModifyConf.UseVisualStyleBackColor = true;
            this.btnModifyConf.Click += new System.EventHandler(this.btnModifyConf_Click);
            // 
            // lblCharges
            // 
            this.lblCharges.AutoSize = true;
            this.lblCharges.Location = new System.Drawing.Point(281, 72);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(0, 13);
            this.lblCharges.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radSingle);
            this.groupBox1.Controls.Add(this.radDouble);
            this.groupBox1.Controls.Add(this.radSuite);
            this.groupBox1.Location = new System.Drawing.Point(48, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accomodations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxInternet);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbxGym);
            this.groupBox2.Location = new System.Drawing.Point(48, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(120, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Reservation Summary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCharges);
            this.Controls.Add(this.btnModifyConf);
            this.Controls.Add(this.btnCreateConf);
            this.Controls.Add(this.nudNumNights);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudNumAttendees);
            this.Controls.Add(this.tbxConferenceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CSU Conference Reservation System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumAttendees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumNights)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxConferenceName;
        private System.Windows.Forms.NumericUpDown nudNumAttendees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumNights;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radSingle;
        private System.Windows.Forms.RadioButton radDouble;
        private System.Windows.Forms.RadioButton radSuite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxInternet;
        private System.Windows.Forms.CheckBox cbxGym;
        private System.Windows.Forms.Button btnCreateConf;
        private System.Windows.Forms.Button btnModifyConf;
        private System.Windows.Forms.Label lblCharges;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
    }
}

