﻿
namespace Program16
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allChartersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noChartersForAYachtSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartersSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetForNextCharterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addYachtTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblhrsChartered = new System.Windows.Forms.Label();
            this.nudHoursChartered = new System.Windows.Forms.NumericUpDown();
            this.lblYachtType = new System.Windows.Forms.Label();
            this.cbxYachtType = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYachtSize = new System.Windows.Forms.Label();
            this.cbxYachtSize = new System.Windows.Forms.ComboBox();
            this.btnAddCharter = new System.Windows.Forms.Button();
            this.lblAttribution = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.charterSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charterManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursChartered)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allChartersToolStripMenuItem,
            this.noChartersForAYachtSizeToolStripMenuItem,
            this.chartersSummaryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // allChartersToolStripMenuItem
            // 
            this.allChartersToolStripMenuItem.Enabled = false;
            this.allChartersToolStripMenuItem.Name = "allChartersToolStripMenuItem";
            this.allChartersToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.allChartersToolStripMenuItem.Text = "All Charters";
            this.allChartersToolStripMenuItem.Click += new System.EventHandler(this.allChartersToolStripMenuItem_Click);
            // 
            // noChartersForAYachtSizeToolStripMenuItem
            // 
            this.noChartersForAYachtSizeToolStripMenuItem.Enabled = false;
            this.noChartersForAYachtSizeToolStripMenuItem.Name = "noChartersForAYachtSizeToolStripMenuItem";
            this.noChartersForAYachtSizeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.noChartersForAYachtSizeToolStripMenuItem.Text = "No. Charters for a Yacht Size";
            this.noChartersForAYachtSizeToolStripMenuItem.Click += new System.EventHandler(this.noChartersForAYachtSizeToolStripMenuItem_Click);
            // 
            // chartersSummaryToolStripMenuItem
            // 
            this.chartersSummaryToolStripMenuItem.Enabled = false;
            this.chartersSummaryToolStripMenuItem.Name = "chartersSummaryToolStripMenuItem";
            this.chartersSummaryToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.chartersSummaryToolStripMenuItem.Text = "Charters Summary";
            this.chartersSummaryToolStripMenuItem.Click += new System.EventHandler(this.chartersSummaryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(223, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetForNextCharterToolStripMenuItem,
            this.toolStripSeparator2,
            this.addYachtTypeToolStripMenuItem1,
            this.removeYachtTypeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // resetForNextCharterToolStripMenuItem
            // 
            this.resetForNextCharterToolStripMenuItem.Enabled = false;
            this.resetForNextCharterToolStripMenuItem.Name = "resetForNextCharterToolStripMenuItem";
            this.resetForNextCharterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.resetForNextCharterToolStripMenuItem.Text = "Reset for Next Charter";
            this.resetForNextCharterToolStripMenuItem.Click += new System.EventHandler(this.resetForNextCharterToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // addYachtTypeToolStripMenuItem1
            // 
            this.addYachtTypeToolStripMenuItem1.Name = "addYachtTypeToolStripMenuItem1";
            this.addYachtTypeToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.addYachtTypeToolStripMenuItem1.Text = "Add Yacht Type";
            this.addYachtTypeToolStripMenuItem1.Click += new System.EventHandler(this.addYachtTypeToolStripMenuItem1_Click);
            // 
            // removeYachtTypeToolStripMenuItem
            // 
            this.removeYachtTypeToolStripMenuItem.Name = "removeYachtTypeToolStripMenuItem";
            this.removeYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.removeYachtTypeToolStripMenuItem.Text = "Remove Yacht Type";
            this.removeYachtTypeToolStripMenuItem.Click += new System.EventHandler(this.removeYachtTypeToolStripMenuItem_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Customer Name";
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.DarkGray;
            this.tbxName.Location = new System.Drawing.Point(212, 60);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(159, 20);
            this.tbxName.TabIndex = 2;
            // 
            // lblhrsChartered
            // 
            this.lblhrsChartered.AutoSize = true;
            this.lblhrsChartered.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblhrsChartered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblhrsChartered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrsChartered.Location = new System.Drawing.Point(13, 98);
            this.lblhrsChartered.Name = "lblhrsChartered";
            this.lblhrsChartered.Size = new System.Drawing.Size(129, 22);
            this.lblhrsChartered.TabIndex = 3;
            this.lblhrsChartered.Text = "Hours Chartered";
            // 
            // nudHoursChartered
            // 
            this.nudHoursChartered.BackColor = System.Drawing.Color.DarkGray;
            this.nudHoursChartered.DecimalPlaces = 2;
            this.nudHoursChartered.Location = new System.Drawing.Point(212, 97);
            this.nudHoursChartered.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHoursChartered.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHoursChartered.Name = "nudHoursChartered";
            this.nudHoursChartered.Size = new System.Drawing.Size(120, 20);
            this.nudHoursChartered.TabIndex = 4;
            this.nudHoursChartered.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblYachtType
            // 
            this.lblYachtType.AutoSize = true;
            this.lblYachtType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblYachtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYachtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYachtType.Location = new System.Drawing.Point(13, 145);
            this.lblYachtType.Name = "lblYachtType";
            this.lblYachtType.Size = new System.Drawing.Size(91, 22);
            this.lblYachtType.TabIndex = 5;
            this.lblYachtType.Text = "Yacht Type";
            // 
            // cbxYachtType
            // 
            this.cbxYachtType.BackColor = System.Drawing.Color.DarkGray;
            this.cbxYachtType.ContextMenuStrip = this.contextMenuStrip1;
            this.cbxYachtType.FormattingEnabled = true;
            this.cbxYachtType.Items.AddRange(new object[] {
            "Express Cruiser",
            "Flybridge",
            "Sedan Bridge",
            "Motor Yacht",
            "Tri-Deck",
            "Sportfish",
            "Skylounge",
            "Mega Yacht"});
            this.cbxYachtType.Location = new System.Drawing.Point(212, 145);
            this.cbxYachtType.Name = "cbxYachtType";
            this.cbxYachtType.Size = new System.Drawing.Size(121, 21);
            this.cbxYachtType.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addYachtTypeToolStripMenuItem,
            this.removeYachtTypeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 48);
            // 
            // addYachtTypeToolStripMenuItem
            // 
            this.addYachtTypeToolStripMenuItem.Name = "addYachtTypeToolStripMenuItem";
            this.addYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addYachtTypeToolStripMenuItem.Text = "Add Yacht Type";
            this.addYachtTypeToolStripMenuItem.Click += new System.EventHandler(this.addYachtTypeToolStripMenuItem1_Click);
            // 
            // removeYachtTypeToolStripMenuItem1
            // 
            this.removeYachtTypeToolStripMenuItem1.Name = "removeYachtTypeToolStripMenuItem1";
            this.removeYachtTypeToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.removeYachtTypeToolStripMenuItem1.Text = "Remove Yacht Type";
            this.removeYachtTypeToolStripMenuItem1.Click += new System.EventHandler(this.removeYachtTypeToolStripMenuItem_Click);
            // 
            // lblYachtSize
            // 
            this.lblYachtSize.AutoSize = true;
            this.lblYachtSize.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblYachtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYachtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYachtSize.Location = new System.Drawing.Point(16, 194);
            this.lblYachtSize.Name = "lblYachtSize";
            this.lblYachtSize.Size = new System.Drawing.Size(88, 22);
            this.lblYachtSize.TabIndex = 7;
            this.lblYachtSize.Text = "Yacht Size";
            // 
            // cbxYachtSize
            // 
            this.cbxYachtSize.BackColor = System.Drawing.Color.DarkGray;
            this.cbxYachtSize.FormattingEnabled = true;
            this.cbxYachtSize.Items.AddRange(new object[] {
            "22",
            "24",
            "30",
            "32",
            "36",
            "38",
            "45"});
            this.cbxYachtSize.Location = new System.Drawing.Point(212, 193);
            this.cbxYachtSize.Name = "cbxYachtSize";
            this.cbxYachtSize.Size = new System.Drawing.Size(121, 21);
            this.cbxYachtSize.TabIndex = 8;
            // 
            // btnAddCharter
            // 
            this.btnAddCharter.Location = new System.Drawing.Point(137, 245);
            this.btnAddCharter.Name = "btnAddCharter";
            this.btnAddCharter.Size = new System.Drawing.Size(75, 23);
            this.btnAddCharter.TabIndex = 9;
            this.btnAddCharter.Text = "Add Charter";
            this.btnAddCharter.UseVisualStyleBackColor = true;
            this.btnAddCharter.Click += new System.EventHandler(this.btnAddCharter_Click);
            // 
            // lblAttribution
            // 
            this.lblAttribution.AutoSize = true;
            this.lblAttribution.Location = new System.Drawing.Point(457, 343);
            this.lblAttribution.Name = "lblAttribution";
            this.lblAttribution.Size = new System.Drawing.Size(78, 13);
            this.lblAttribution.TabIndex = 11;
            this.lblAttribution.Text = "Foutz Software";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charterSummaryToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 48);
            // 
            // charterSummaryToolStripMenuItem
            // 
            this.charterSummaryToolStripMenuItem.Enabled = false;
            this.charterSummaryToolStripMenuItem.Name = "charterSummaryToolStripMenuItem";
            this.charterSummaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.charterSummaryToolStripMenuItem.Text = "Charter Summary";
            this.charterSummaryToolStripMenuItem.Click += new System.EventHandler(this.chartersSummaryToolStripMenuItem_Click);
            // 
            // charterManagerBindingSource
            // 
            this.charterManagerBindingSource.DataSource = typeof(Program16.CharterManager);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program16.Properties.Resources.bp_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(547, 365);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.lblAttribution);
            this.Controls.Add(this.btnAddCharter);
            this.Controls.Add(this.cbxYachtSize);
            this.Controls.Add(this.lblYachtSize);
            this.Controls.Add(this.cbxYachtType);
            this.Controls.Add(this.lblYachtType);
            this.Controls.Add(this.nudHoursChartered);
            this.Controls.Add(this.lblhrsChartered);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kerry\'s Yacht Chartering Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursChartered)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allChartersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noChartersForAYachtSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartersSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetForNextCharterToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblhrsChartered;
        private System.Windows.Forms.NumericUpDown nudHoursChartered;
        private System.Windows.Forms.Label lblYachtType;
        private System.Windows.Forms.Label lblYachtSize;
        private System.Windows.Forms.ComboBox cbxYachtSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addYachtTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem;
        private System.Windows.Forms.Button btnAddCharter;
        private System.Windows.Forms.BindingSource charterManagerBindingSource;
        internal System.Windows.Forms.ComboBox cbxYachtType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem addYachtTypeToolStripMenuItem;
        private System.Windows.Forms.Label lblAttribution;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem charterSummaryToolStripMenuItem;
    }
}

