/*
 * Project:         Final Exam
 * Date:            December 2020
 * Developed By:    LV
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS605FinalExam
{
    public partial class SalesPersonForm : Form
    {
        private SPManager aManager;
        public SalesPersonForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (aManager is null)
                aManager = new SPManager();

            string salespersonName = txtName.Text;
            int numCars = Convert.ToInt32(nudCarsSold.Value);
            decimal dollarValue = nudValue.Value;

            lblMonthlyCommission.Text = aManager.AddSalesPerson(salespersonName, numCars, dollarValue).ToString("c");
            
            lblaverageMonthlyCommission.Text = aManager.CalcAverageMonthlyCommission().ToString("c");

            lstHighPerformers.DataSource = aManager.FindHighPerformers();

            grpSalesPersonData.Enabled = false;
            
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            foreach (GroupBox aGroup in this.Controls.OfType<GroupBox>())
            {
                foreach (TextBox aBox in aGroup.Controls.OfType<TextBox>())
                {
                    aBox.Clear();
                }

                foreach (Label aLabel in aGroup.Controls.OfType<Label>())
                {
                    if (aLabel.Name.StartsWith("lbl"))
                        aLabel.Text = string.Empty;
                }

                foreach (NumericUpDown aNud in aGroup.Controls.OfType<NumericUpDown>())
                {
                    aNud.Value = aNud.Minimum;
                }

                foreach (ListBox aList in aGroup.Controls.OfType<ListBox>())
                {
                    aList.DataSource = null;
                }
            }

            grpSalesPersonData.Enabled = true;

            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form

            this.Close();
        }
    }
}
