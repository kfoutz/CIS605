
namespace Program16
{
    partial class ChartersSumary
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblLowestCharterFee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAvgFees = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.charterManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(167, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Lowest Charter Fee";
            // 
            // lblLowestCharterFee
            // 
            this.lblLowestCharterFee.AutoSize = true;
            this.lblLowestCharterFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestCharterFee.Location = new System.Drawing.Point(294, 9);
            this.lblLowestCharterFee.Name = "lblLowestCharterFee";
            this.lblLowestCharterFee.Size = new System.Drawing.Size(57, 20);
            this.lblLowestCharterFee.TabIndex = 1;
            this.lblLowestCharterFee.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Fees From all Charters";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(294, 34);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(57, 20);
            this.lblTotalFees.TabIndex = 3;
            this.lblTotalFees.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average Fees From all Charters";
            // 
            // lblAvgFees
            // 
            this.lblAvgFees.AutoSize = true;
            this.lblAvgFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgFees.Location = new System.Drawing.Point(294, 62);
            this.lblAvgFees.Name = "lblAvgFees";
            this.lblAvgFees.Size = new System.Drawing.Size(57, 20);
            this.lblAvgFees.TabIndex = 5;
            this.lblAvgFees.Text = "label3";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(137, 107);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // charterManagerBindingSource
            // 
            this.charterManagerBindingSource.DataMember = "Charters";
            this.charterManagerBindingSource.DataSource = typeof(Program16.CharterManager);
            // 
            // ChartersSumary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 159);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAvgFees);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLowestCharterFee);
            this.Controls.Add(this.lbl1);
            this.Name = "ChartersSumary";
            this.Text = "Kerry Foutz Charters Sumary";
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.BindingSource charterManagerBindingSource;
        internal System.Windows.Forms.Label lblLowestCharterFee;
        internal System.Windows.Forms.Label lblTotalFees;
        internal System.Windows.Forms.Label lblAvgFees;
        private System.Windows.Forms.Button btnClose;
    }
}