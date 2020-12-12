/*
 * Project:         Assignment 7, Program 16
 * Date:            December 2020
 * Developed By:    KCF
 * Class Name:      Form1, ChartersSummary, AllCharters - Presentation Layer
 *                  Charter, CharterManager - Business Logic
 * Purpose:         Demonstrates adding and removing items to a list with pre-checks done with loops, working with multiple form classes and stuff
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
using System.Globalization;

namespace Program16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CharterManager aCharterManager;


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCharter_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Customer Name.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxYachtType.Text == string.Empty)
            {
                MessageBox.Show("Please select a Yacht type.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxYachtSize.Text == string.Empty)
            {
                MessageBox.Show("Please select a Yacht size.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerName, yachtType;
            int yachtSize;
            decimal charterhours, yachtFee;
            
            Charter aCharter;
            customerName = tbxName.Text;

            

            yachtSize = Convert.ToInt32(cbxYachtSize.SelectedItem);
            yachtType = Convert.ToString(cbxYachtType.SelectedItem);
            charterhours = (nudHoursChartered.Value);

            aCharter = new Charter(customerName, yachtType, yachtSize, charterhours);

            yachtFee = aCharter.CharterFee;

            aCharter = new Charter(customerName, yachtType, yachtSize, charterhours);

            

            if (aCharterManager is null)
            {
                aCharterManager = new CharterManager();
            }
            
            aCharterManager.AddCharter(aCharter);

            allChartersToolStripMenuItem.Enabled = true;
            noChartersForAYachtSizeToolStripMenuItem.Enabled = true;
            chartersSummaryToolStripMenuItem.Enabled = true;
            resetForNextCharterToolStripMenuItem.Enabled = true;
            charterSummaryToolStripMenuItem.Enabled = true;
            //contextMenuStrip2.Items[0].Enabled = true;
            //contextMenuStrip2 = true;
            
            


            
        }

        private void allChartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCharters aCharters = new AllCharters();
            aCharters.charterManagerBindingSource.DataSource = aCharterManager;
            aCharters.ShowDialog();
        }

        private void noChartersForAYachtSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbxYachtSize.Text == string.Empty)
            {
                MessageBox.Show("Please select a Yacht size.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strMessage;
            int aGroup = Convert.ToInt32(cbxYachtSize.SelectedItem);
            strMessage = aCharterManager.GetCharterCount(aGroup).ToString();

            MessageBox.Show($"The number of Charters for a {cbxYachtSize.SelectedItem} foot Yacht is {strMessage}.", "Charters By Size", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chartersSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartersSumary aCharterSummary = new ChartersSumary();
            aCharterSummary.lblLowestCharterFee.Text = aCharterManager.FindLowestCharterFee().ToString("C");
            aCharterSummary.lblAvgFees.Text = aCharterManager.GetAverageCharterFee().ToString("C");
            aCharterSummary.lblTotalFees.Text = aCharterManager.GetTotalCharterFees().ToString("C");
            aCharterSummary.ShowDialog();
            
           
        }

        private void addYachtTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (cbxYachtType.Text == string.Empty)
            {
                MessageBox.Show("Enter a new Yacht Type", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newYacht = cbxYachtType.Text;
            bool duplicate = false;

            foreach (string aItem in cbxYachtType.Items)
            {
                if (string.Equals(newYacht, aItem, StringComparison.OrdinalIgnoreCase))
                {
                    duplicate = true;
                    break;
                }
            }

            if (duplicate)
            {
                MessageBox.Show("Yacht not added", "Duplicate Yacht", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxYachtType.Text = string.Empty;
            }
            else
            {
                TextInfo aTextInfo = new CultureInfo("en-US", false).TextInfo;

                newYacht = aTextInfo.ToTitleCase(newYacht);

                cbxYachtType.Items.Add(newYacht);
                MessageBox.Show("New Yacht Type added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxYachtType.Text = string.Empty;
            }
        }

        private void removeYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbxYachtType.SelectedIndex == -1)
            {
                MessageBox.Show("Select the yacht to remove", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cbxYachtType.Items.RemoveAt(cbxYachtType.SelectedIndex);
                MessageBox.Show("Yacht removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxYachtType.Text = string.Empty;
            }
        }

        private void resetForNextCharterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxName.Text = null;
            nudHoursChartered.Value = nudHoursChartered.Minimum;
            cbxYachtSize.SelectedIndex = -1;
            cbxYachtType.SelectedIndex = -1;
        }
    }
}
