
namespace Program16
{
    partial class AllCharters
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
            this.charterManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursCharteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charterFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charterManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // charterManagerDataGridView
            // 
            this.charterManagerDataGridView.AutoGenerateColumns = false;
            this.charterManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.charterManagerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNameDataGridViewTextBoxColumn,
            this.yachtTypeDataGridViewTextBoxColumn,
            this.yachtSizeDataGridViewTextBoxColumn,
            this.hoursCharteredDataGridViewTextBoxColumn,
            this.charterFeeDataGridViewTextBoxColumn});
            this.charterManagerDataGridView.DataSource = this.charterManagerBindingSource;
            this.charterManagerDataGridView.Location = new System.Drawing.Point(12, 12);
            this.charterManagerDataGridView.Name = "charterManagerDataGridView";
            this.charterManagerDataGridView.Size = new System.Drawing.Size(544, 218);
            this.charterManagerDataGridView.TabIndex = 1;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "CustName";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yachtTypeDataGridViewTextBoxColumn
            // 
            this.yachtTypeDataGridViewTextBoxColumn.DataPropertyName = "YachtType";
            this.yachtTypeDataGridViewTextBoxColumn.HeaderText = "YachtType";
            this.yachtTypeDataGridViewTextBoxColumn.Name = "yachtTypeDataGridViewTextBoxColumn";
            // 
            // yachtSizeDataGridViewTextBoxColumn
            // 
            this.yachtSizeDataGridViewTextBoxColumn.DataPropertyName = "YachtSize";
            this.yachtSizeDataGridViewTextBoxColumn.HeaderText = "YachtSize";
            this.yachtSizeDataGridViewTextBoxColumn.Name = "yachtSizeDataGridViewTextBoxColumn";
            // 
            // hoursCharteredDataGridViewTextBoxColumn
            // 
            this.hoursCharteredDataGridViewTextBoxColumn.DataPropertyName = "HoursChartered";
            this.hoursCharteredDataGridViewTextBoxColumn.HeaderText = "HoursChartered";
            this.hoursCharteredDataGridViewTextBoxColumn.Name = "hoursCharteredDataGridViewTextBoxColumn";
            this.hoursCharteredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // charterFeeDataGridViewTextBoxColumn
            // 
            this.charterFeeDataGridViewTextBoxColumn.DataPropertyName = "CharterFee";
            this.charterFeeDataGridViewTextBoxColumn.HeaderText = "CharterFee";
            this.charterFeeDataGridViewTextBoxColumn.Name = "charterFeeDataGridViewTextBoxColumn";
            this.charterFeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // charterManagerBindingSource
            // 
            this.charterManagerBindingSource.AllowNew = false;
            this.charterManagerBindingSource.DataMember = "Charters";
            this.charterManagerBindingSource.DataSource = typeof(Program16.CharterManager);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(247, 267);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AllCharters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 316);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.charterManagerDataGridView);
            this.Name = "AllCharters";
            this.Text = "AllCharters";
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView charterManagerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursCharteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterFeeDataGridViewTextBoxColumn;
        internal System.Windows.Forms.BindingSource charterManagerBindingSource;
        private System.Windows.Forms.Button btnClose;
    }
}