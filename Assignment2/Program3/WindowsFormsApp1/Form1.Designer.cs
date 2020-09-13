namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGrabber = new System.Windows.Forms.Label();
            this.lblBand = new System.Windows.Forms.Label();
            this.grpBoxPickAcolor = new System.Windows.Forms.GroupBox();
            this.radBlack7 = new System.Windows.Forms.RadioButton();
            this.radRed6 = new System.Windows.Forms.RadioButton();
            this.radOrange5 = new System.Windows.Forms.RadioButton();
            this.radYellow4 = new System.Windows.Forms.RadioButton();
            this.radGreen2 = new System.Windows.Forms.RadioButton();
            this.radBlue2 = new System.Windows.Forms.RadioButton();
            this.radPurple1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxPickAcolor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 399);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblGrabber
            // 
            this.lblGrabber.AutoSize = true;
            this.lblGrabber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrabber.Location = new System.Drawing.Point(18, 9);
            this.lblGrabber.Name = "lblGrabber";
            this.lblGrabber.Size = new System.Drawing.Size(267, 29);
            this.lblGrabber.TabIndex = 1;
            this.lblGrabber.Text = "The New Album From";
            // 
            // lblBand
            // 
            this.lblBand.AutoSize = true;
            this.lblBand.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBand.Location = new System.Drawing.Point(287, 23);
            this.lblBand.Name = "lblBand";
            this.lblBand.Size = new System.Drawing.Size(261, 44);
            this.lblBand.TabIndex = 2;
            this.lblBand.Text = "The Ghosties";
            // 
            // grpBoxPickAcolor
            // 
            this.grpBoxPickAcolor.Controls.Add(this.radBlack7);
            this.grpBoxPickAcolor.Controls.Add(this.radRed6);
            this.grpBoxPickAcolor.Controls.Add(this.radOrange5);
            this.grpBoxPickAcolor.Controls.Add(this.radYellow4);
            this.grpBoxPickAcolor.Controls.Add(this.radGreen2);
            this.grpBoxPickAcolor.Controls.Add(this.radBlue2);
            this.grpBoxPickAcolor.Controls.Add(this.radPurple1);
            this.grpBoxPickAcolor.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxPickAcolor.Location = new System.Drawing.Point(16, 154);
            this.grpBoxPickAcolor.Name = "grpBoxPickAcolor";
            this.grpBoxPickAcolor.Size = new System.Drawing.Size(107, 197);
            this.grpBoxPickAcolor.TabIndex = 3;
            this.grpBoxPickAcolor.TabStop = false;
            this.grpBoxPickAcolor.Text = "Pick a color";
            // 
            // radBlack7
            // 
            this.radBlack7.AutoSize = true;
            this.radBlack7.Checked = true;
            this.radBlack7.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack7.ForeColor = System.Drawing.Color.Black;
            this.radBlack7.Location = new System.Drawing.Point(7, 160);
            this.radBlack7.Name = "radBlack7";
            this.radBlack7.Size = new System.Drawing.Size(58, 19);
            this.radBlack7.TabIndex = 6;
            this.radBlack7.TabStop = true;
            this.radBlack7.Text = "Black";
            this.radBlack7.UseVisualStyleBackColor = true;
            // 
            // radRed6
            // 
            this.radRed6.AutoSize = true;
            this.radRed6.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed6.ForeColor = System.Drawing.Color.Red;
            this.radRed6.Location = new System.Drawing.Point(7, 135);
            this.radRed6.Name = "radRed6";
            this.radRed6.Size = new System.Drawing.Size(48, 19);
            this.radRed6.TabIndex = 5;
            this.radRed6.TabStop = true;
            this.radRed6.Text = "Red";
            this.radRed6.UseVisualStyleBackColor = true;
            // 
            // radOrange5
            // 
            this.radOrange5.AutoSize = true;
            this.radOrange5.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOrange5.ForeColor = System.Drawing.Color.Orange;
            this.radOrange5.Location = new System.Drawing.Point(7, 112);
            this.radOrange5.Name = "radOrange5";
            this.radOrange5.Size = new System.Drawing.Size(68, 19);
            this.radOrange5.TabIndex = 4;
            this.radOrange5.TabStop = true;
            this.radOrange5.Text = "Orange";
            this.radOrange5.UseVisualStyleBackColor = true;
            // 
            // radYellow4
            // 
            this.radYellow4.AutoSize = true;
            this.radYellow4.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYellow4.ForeColor = System.Drawing.Color.Gold;
            this.radYellow4.Location = new System.Drawing.Point(7, 89);
            this.radYellow4.Name = "radYellow4";
            this.radYellow4.Size = new System.Drawing.Size(64, 19);
            this.radYellow4.TabIndex = 3;
            this.radYellow4.TabStop = true;
            this.radYellow4.Text = "Yellow";
            this.radYellow4.UseVisualStyleBackColor = true;
            // 
            // radGreen2
            // 
            this.radGreen2.AutoSize = true;
            this.radGreen2.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen2.ForeColor = System.Drawing.Color.LimeGreen;
            this.radGreen2.Location = new System.Drawing.Point(7, 66);
            this.radGreen2.Name = "radGreen2";
            this.radGreen2.Size = new System.Drawing.Size(58, 19);
            this.radGreen2.TabIndex = 2;
            this.radGreen2.TabStop = true;
            this.radGreen2.Text = "Green";
            this.radGreen2.UseVisualStyleBackColor = true;
            // 
            // radBlue2
            // 
            this.radBlue2.AutoSize = true;
            this.radBlue2.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.radBlue2.Location = new System.Drawing.Point(7, 43);
            this.radBlue2.Name = "radBlue2";
            this.radBlue2.Size = new System.Drawing.Size(50, 19);
            this.radBlue2.TabIndex = 1;
            this.radBlue2.TabStop = true;
            this.radBlue2.Text = "Blue";
            this.radBlue2.UseVisualStyleBackColor = true;
            // 
            // radPurple1
            // 
            this.radPurple1.AutoSize = true;
            this.radPurple1.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPurple1.ForeColor = System.Drawing.Color.Purple;
            this.radPurple1.Location = new System.Drawing.Point(7, 20);
            this.radPurple1.Name = "radPurple1";
            this.radPurple1.Size = new System.Drawing.Size(62, 19);
            this.radPurple1.TabIndex = 0;
            this.radPurple1.TabStop = true;
            this.radPurple1.Text = "Purple";
            this.radPurple1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(636, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show/ Hide";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(6, 114);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 22);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Developer";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(6, 86);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(112, 22);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "AlbumCover";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(6, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 22);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Band";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Grabber";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(12, 516);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(144, 20);
            this.lblDeveloper.TabIndex = 5;
            this.lblDeveloper.Text = "Developed by: KCF";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxPickAcolor);
            this.Controls.Add(this.lblBand);
            this.Controls.Add(this.lblGrabber);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxPickAcolor.ResumeLayout(false);
            this.grpBoxPickAcolor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGrabber;
        private System.Windows.Forms.Label lblBand;
        private System.Windows.Forms.GroupBox grpBoxPickAcolor;
        private System.Windows.Forms.RadioButton radRed6;
        private System.Windows.Forms.RadioButton radOrange5;
        private System.Windows.Forms.RadioButton radYellow4;
        private System.Windows.Forms.RadioButton radGreen2;
        private System.Windows.Forms.RadioButton radBlue2;
        private System.Windows.Forms.RadioButton radPurple1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radBlack7;
    }
}

