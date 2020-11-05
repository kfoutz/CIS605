namespace SuperBowls___Program13
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
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.cboSuperBowlWinners = new System.Windows.Forms.ComboBox();
            this.btnHowManyWins = new System.Windows.Forms.Button();
            this.btnBack2Back = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblBack2Back = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboTeams
            // 
            this.cboTeams.FormattingEnabled = true;
            this.cboTeams.Items.AddRange(new object[] {
            "Cardinals",
            "Falcons",
            "Ravens",
            "Bills",
            "Panthers",
            "Bears",
            "Bengals",
            "Browns",
            "Cowboys",
            "Broncos",
            "Lions",
            "Packers",
            "Texans",
            "Colts",
            "Jaguars",
            "Chiefs",
            "Dolphins",
            "Vikings",
            "Patriots",
            "Saints",
            "Giants",
            "Jets",
            "Raiders",
            "Eagles",
            "Steelers",
            "Chargers",
            "49ers",
            "Seahawks",
            "Rams",
            "Buccaneers",
            "Titans",
            "Washington"});
            this.cboTeams.Location = new System.Drawing.Point(29, 66);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(134, 21);
            this.cboTeams.TabIndex = 0;
            // 
            // cboSuperBowlWinners
            // 
            this.cboSuperBowlWinners.FormattingEnabled = true;
            this.cboSuperBowlWinners.Items.AddRange(new object[] {
            "Packers",
            "Packers",
            "Jets",
            "Chiefs",
            "Colts",
            "Cowboys",
            "Dolphins",
            "Dolphins",
            "Steelers",
            "Steelers",
            "Raiders",
            "Cowboys",
            "Steelers",
            "Steelers",
            "Raiders",
            "49ers",
            "Washington",
            "Raiders",
            "49ers",
            "Bears",
            "Giants",
            "Washington",
            "49ers",
            "49ers",
            "Giants",
            "Washington",
            "Cowboys",
            "Cowboys",
            "49ers",
            "Cowboys",
            "Packers",
            "Broncos",
            "Broncos",
            "Rams",
            "Ravens",
            "Patriots",
            "Buccaneers",
            "Patriots",
            "Patriots",
            "Steelers",
            "Colts",
            "Giants",
            "Steelers",
            "Saints",
            "Packers",
            "Giants",
            "Ravens",
            "Seahawks",
            "Patriots",
            "Broncos",
            "Patriots",
            "Eagles",
            "Patriots",
            "Chiefs"});
            this.cboSuperBowlWinners.Location = new System.Drawing.Point(182, 66);
            this.cboSuperBowlWinners.Name = "cboSuperBowlWinners";
            this.cboSuperBowlWinners.Size = new System.Drawing.Size(176, 21);
            this.cboSuperBowlWinners.TabIndex = 1;
            // 
            // btnHowManyWins
            // 
            this.btnHowManyWins.Location = new System.Drawing.Point(29, 12);
            this.btnHowManyWins.Name = "btnHowManyWins";
            this.btnHowManyWins.Size = new System.Drawing.Size(134, 48);
            this.btnHowManyWins.TabIndex = 2;
            this.btnHowManyWins.Text = "How Many SuperBowls Have They Won?";
            this.btnHowManyWins.UseVisualStyleBackColor = true;
            this.btnHowManyWins.Click += new System.EventHandler(this.btnHowManyWins_Click);
            // 
            // btnBack2Back
            // 
            this.btnBack2Back.Location = new System.Drawing.Point(394, 26);
            this.btnBack2Back.Name = "btnBack2Back";
            this.btnBack2Back.Size = new System.Drawing.Size(140, 23);
            this.btnBack2Back.TabIndex = 3;
            this.btnBack2Back.Text = "Back-to-Back Winners";
            this.btnBack2Back.UseVisualStyleBackColor = true;
            this.btnBack2Back.Click += new System.EventHandler(this.btnBack2Back_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(26, 102);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 4;
            // 
            // lblBack2Back
            // 
            this.lblBack2Back.AutoSize = true;
            this.lblBack2Back.Location = new System.Drawing.Point(391, 66);
            this.lblBack2Back.Name = "lblBack2Back";
            this.lblBack2Back.Size = new System.Drawing.Size(0, 13);
            this.lblBack2Back.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(459, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "SuperBowl Champions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "61 Foutz ILB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBack2Back);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnBack2Back);
            this.Controls.Add(this.btnHowManyWins);
            this.Controls.Add(this.cboSuperBowlWinners);
            this.Controls.Add(this.cboTeams);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperBowl Facts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTeams;
        private System.Windows.Forms.ComboBox cboSuperBowlWinners;
        private System.Windows.Forms.Button btnHowManyWins;
        private System.Windows.Forms.Button btnBack2Back;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblBack2Back;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

