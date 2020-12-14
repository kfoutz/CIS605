namespace CIS605FinalExam
{
    partial class SeatingChartForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfTakenSeatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfSeatsAvailableByRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfRowsWithAllSeatsTakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(699, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfTakenSeatsToolStripMenuItem,
            this.numberOfSeatsAvailableByRowToolStripMenuItem,
            this.numberOfRowsWithAllSeatsTakenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.displayToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // numberOfTakenSeatsToolStripMenuItem
            // 
            this.numberOfTakenSeatsToolStripMenuItem.Name = "numberOfTakenSeatsToolStripMenuItem";
            this.numberOfTakenSeatsToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.numberOfTakenSeatsToolStripMenuItem.Text = "Number of Taken Seats";
            this.numberOfTakenSeatsToolStripMenuItem.Click += new System.EventHandler(this.numberOfTakenSeatsToolStripMenuItem_Click);
            // 
            // numberOfSeatsAvailableByRowToolStripMenuItem
            // 
            this.numberOfSeatsAvailableByRowToolStripMenuItem.Name = "numberOfSeatsAvailableByRowToolStripMenuItem";
            this.numberOfSeatsAvailableByRowToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.numberOfSeatsAvailableByRowToolStripMenuItem.Text = "Number of Seats Available by Row";
            this.numberOfSeatsAvailableByRowToolStripMenuItem.Click += new System.EventHandler(this.numberOfSeatsAvailableByRowToolStripMenuItem_Click);
            // 
            // numberOfRowsWithAllSeatsTakenToolStripMenuItem
            // 
            this.numberOfRowsWithAllSeatsTakenToolStripMenuItem.Name = "numberOfRowsWithAllSeatsTakenToolStripMenuItem";
            this.numberOfRowsWithAllSeatsTakenToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.numberOfRowsWithAllSeatsTakenToolStripMenuItem.Text = "Number of Rows with All Seats Taken";
            this.numberOfRowsWithAllSeatsTakenToolStripMenuItem.Click += new System.EventHandler(this.numberOfRowsWithAllSeatsTakenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(290, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 598);
            this.panel1.TabIndex = 1;
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 24;
            this.lstResult.Location = new System.Drawing.Point(637, 48);
            this.lstResult.Name = "lstResult";
            this.lstResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstResult.Size = new System.Drawing.Size(50, 604);
            this.lstResult.TabIndex = 2;
            // 
            // SeatingChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 658);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SeatingChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIS 605 - Final Exam";
            this.Load += new System.EventHandler(this.SeatingChartForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfTakenSeatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfSeatsAvailableByRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfRowsWithAllSeatsTakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstResult;
    }
}

