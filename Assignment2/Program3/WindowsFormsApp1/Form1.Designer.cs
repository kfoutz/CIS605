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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxAlbumCover = new System.Windows.Forms.PictureBox();
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
            this.toolTipAlbumCover = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).BeginInit();
            this.grpBoxPickAcolor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAlbumCover
            // 
            this.pictureBoxAlbumCover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAlbumCover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlbumCover.BackgroundImage")));
            this.pictureBoxAlbumCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAlbumCover.Location = new System.Drawing.Point(271, 90);
            this.pictureBoxAlbumCover.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAlbumCover.Name = "pictureBoxAlbumCover";
            this.pictureBoxAlbumCover.Size = new System.Drawing.Size(533, 491);
            this.pictureBoxAlbumCover.TabIndex = 0;
            this.pictureBoxAlbumCover.TabStop = false;
            // 
            // lblGrabber
            // 
            this.lblGrabber.AutoSize = true;
            this.lblGrabber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrabber.Location = new System.Drawing.Point(24, 11);
            this.lblGrabber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrabber.Name = "lblGrabber";
            this.lblGrabber.Size = new System.Drawing.Size(267, 29);
            this.lblGrabber.TabIndex = 1;
            this.lblGrabber.Text = "The New Album From";
            // 
            // lblBand
            // 
            this.lblBand.AutoSize = true;
            this.lblBand.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBand.Location = new System.Drawing.Point(383, 28);
            this.lblBand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.grpBoxPickAcolor.Location = new System.Drawing.Point(21, 190);
            this.grpBoxPickAcolor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxPickAcolor.Name = "grpBoxPickAcolor";
            this.grpBoxPickAcolor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxPickAcolor.Size = new System.Drawing.Size(143, 242);
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
            this.radBlack7.Location = new System.Drawing.Point(9, 197);
            this.radBlack7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radBlack7.Name = "radBlack7";
            this.radBlack7.Size = new System.Drawing.Size(58, 19);
            this.radBlack7.TabIndex = 6;
            this.radBlack7.TabStop = true;
            this.radBlack7.Text = "&Black";
            this.radBlack7.UseVisualStyleBackColor = true;
            this.radBlack7.CheckedChanged += new System.EventHandler(this.radBlack7_CheckedChanged);
            // 
            // radRed6
            // 
            this.radRed6.AutoSize = true;
            this.radRed6.Checked = true;
            this.radRed6.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed6.ForeColor = System.Drawing.Color.Red;
            this.radRed6.Location = new System.Drawing.Point(9, 166);
            this.radRed6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radRed6.Name = "radRed6";
            this.radRed6.Size = new System.Drawing.Size(48, 19);
            this.radRed6.TabIndex = 5;
            this.radRed6.TabStop = true;
            this.radRed6.Text = "&Red";
            this.radRed6.UseVisualStyleBackColor = true;
            this.radRed6.CheckedChanged += new System.EventHandler(this.radRed6_CheckedChanged);
            // 
            // radOrange5
            // 
            this.radOrange5.AutoSize = true;
            this.radOrange5.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOrange5.ForeColor = System.Drawing.Color.Orange;
            this.radOrange5.Location = new System.Drawing.Point(9, 138);
            this.radOrange5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radOrange5.Name = "radOrange5";
            this.radOrange5.Size = new System.Drawing.Size(68, 19);
            this.radOrange5.TabIndex = 4;
            this.radOrange5.TabStop = true;
            this.radOrange5.Text = "&Orange";
            this.radOrange5.UseVisualStyleBackColor = true;
            this.radOrange5.CheckedChanged += new System.EventHandler(this.radOrange5_CheckedChanged);
            // 
            // radYellow4
            // 
            this.radYellow4.AutoSize = true;
            this.radYellow4.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radYellow4.ForeColor = System.Drawing.Color.Gold;
            this.radYellow4.Location = new System.Drawing.Point(9, 110);
            this.radYellow4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radYellow4.Name = "radYellow4";
            this.radYellow4.Size = new System.Drawing.Size(64, 19);
            this.radYellow4.TabIndex = 3;
            this.radYellow4.TabStop = true;
            this.radYellow4.Text = "&Yellow";
            this.radYellow4.UseVisualStyleBackColor = true;
            this.radYellow4.CheckedChanged += new System.EventHandler(this.radYellow4_CheckedChanged);
            // 
            // radGreen2
            // 
            this.radGreen2.AutoSize = true;
            this.radGreen2.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen2.ForeColor = System.Drawing.Color.LimeGreen;
            this.radGreen2.Location = new System.Drawing.Point(9, 81);
            this.radGreen2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radGreen2.Name = "radGreen2";
            this.radGreen2.Size = new System.Drawing.Size(58, 19);
            this.radGreen2.TabIndex = 2;
            this.radGreen2.TabStop = true;
            this.radGreen2.Text = "&Green";
            this.radGreen2.UseVisualStyleBackColor = true;
            this.radGreen2.CheckedChanged += new System.EventHandler(this.radGreen2_CheckedChanged);
            // 
            // radBlue2
            // 
            this.radBlue2.AutoSize = true;
            this.radBlue2.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.radBlue2.Location = new System.Drawing.Point(9, 53);
            this.radBlue2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radBlue2.Name = "radBlue2";
            this.radBlue2.Size = new System.Drawing.Size(50, 19);
            this.radBlue2.TabIndex = 1;
            this.radBlue2.TabStop = true;
            this.radBlue2.Text = "&Blue";
            this.radBlue2.UseVisualStyleBackColor = true;
            this.radBlue2.CheckedChanged += new System.EventHandler(this.radBlue2_CheckedChanged);
            // 
            // radPurple1
            // 
            this.radPurple1.AutoSize = true;
            this.radPurple1.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPurple1.ForeColor = System.Drawing.Color.Purple;
            this.radPurple1.Location = new System.Drawing.Point(9, 25);
            this.radPurple1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radPurple1.Name = "radPurple1";
            this.radPurple1.Size = new System.Drawing.Size(62, 19);
            this.radPurple1.TabIndex = 0;
            this.radPurple1.TabStop = true;
            this.radPurple1.Text = "&Purple";
            this.radPurple1.UseVisualStyleBackColor = true;
            this.radPurple1.CheckedChanged += new System.EventHandler(this.radPurple1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(848, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(163, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show/ Hide";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(8, 140);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 22);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Developer";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(8, 106);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(112, 22);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "AlbumCover";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(8, 71);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 22);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Band";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(8, 37);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Grabber";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloper.Location = new System.Drawing.Point(16, 635);
            this.lblDeveloper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(144, 20);
            this.lblDeveloper.TabIndex = 5;
            this.lblDeveloper.Text = "Developed by: KCF";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(951, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTipAlbumCover
            // 
            this.toolTipAlbumCover.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTipAlbumCover.ToolTipTitle = "RainBow Pancakes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 671);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxPickAcolor);
            this.Controls.Add(this.lblBand);
            this.Controls.Add(this.lblGrabber);
            this.Controls.Add(this.pictureBoxAlbumCover);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).EndInit();
            this.grpBoxPickAcolor.ResumeLayout(false);
            this.grpBoxPickAcolor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlbumCover;
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
        private System.Windows.Forms.ToolTip toolTipAlbumCover;
    }
}

