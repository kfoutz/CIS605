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
            this.cboTeams = new System.Windows.Forms.ComboBox();
            this.cboSuperBowlWinners = new System.Windows.Forms.ComboBox();
            this.btnHowManyWins = new System.Windows.Forms.Button();
            this.btnBack2Back = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblBack2Back = new System.Windows.Forms.Label();
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
            "The Washington Football Team"});
            this.cboTeams.Location = new System.Drawing.Point(29, 66);
            this.cboTeams.Name = "cboTeams";
            this.cboTeams.Size = new System.Drawing.Size(121, 21);
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
            "The Washington Football Team",
            "Raiders",
            "49ers",
            "Bears",
            "Giants",
            "The Washington Football Team",
            "49ers",
            "49ers",
            "Giants",
            "The Washington Football Team",
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
            this.cboSuperBowlWinners.Location = new System.Drawing.Point(181, 65);
            this.cboSuperBowlWinners.Name = "cboSuperBowlWinners";
            this.cboSuperBowlWinners.Size = new System.Drawing.Size(176, 21);
            this.cboSuperBowlWinners.TabIndex = 1;
            // 
            // btnHowManyWins
            // 
            this.btnHowManyWins.Location = new System.Drawing.Point(431, 26);
            this.btnHowManyWins.Name = "btnHowManyWins";
            this.btnHowManyWins.Size = new System.Drawing.Size(134, 23);
            this.btnHowManyWins.TabIndex = 2;
            this.btnHowManyWins.Text = "How Many SuperBowls?";
            this.btnHowManyWins.UseVisualStyleBackColor = true;
            this.btnHowManyWins.Click += new System.EventHandler(this.btnHowManyWins_Click);
            // 
            // btnBack2Back
            // 
            this.btnBack2Back.Location = new System.Drawing.Point(582, 26);
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
            this.lblOutput.Location = new System.Drawing.Point(431, 66);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "label1";
            // 
            // lblBack2Back
            // 
            this.lblBack2Back.AutoSize = true;
            this.lblBack2Back.Location = new System.Drawing.Point(582, 72);
            this.lblBack2Back.Name = "lblBack2Back";
            this.lblBack2Back.Size = new System.Drawing.Size(35, 13);
            this.lblBack2Back.TabIndex = 5;
            this.lblBack2Back.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.lblBack2Back);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnBack2Back);
            this.Controls.Add(this.btnHowManyWins);
            this.Controls.Add(this.cboSuperBowlWinners);
            this.Controls.Add(this.cboTeams);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

