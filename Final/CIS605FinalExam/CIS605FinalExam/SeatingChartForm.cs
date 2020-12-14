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
    public partial class SeatingChartForm : Form
    {
        public SeatingChartForm()
        {
            InitializeComponent();
        }

        SeatingChart aChart;

        #region "Ignore"
        private void SeatingChartForm_Load(object sender, EventArgs e)
        {
            aChart = new SeatingChart();

            TableLayoutPanel aTable = new TableLayoutPanel();

            aTable.AutoSize = true;

            aTable.RowCount = aChart.Seats.GetLength(0);
            aTable.ColumnCount = aChart.Seats.GetLength(1);

            // The Seats array is used to populate the TableLayoutPanel object

            for (int row = 0; row < aChart.Seats.GetLength(0); ++row)
            {
                for (int col = 0; col < aChart.Seats.GetLength(1); ++col)
                {
                    aTable.Controls.Add(aChart.Seats[row, col], col, row);
                }
            }

            panel1.Controls.Add(aTable);
        }

        #endregion

        private void numberOfTakenSeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aChart.FindNumberOfTakenSeats().ToString(), "Number of Taken Seats", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numberOfSeatsAvailableByRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstResult.DataSource = aChart.FindSeatsAvailableByRow();
        }

        private void numberOfRowsWithAllSeatsTakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aChart.FindNumberOfRowsWithAllSeatsTaken().ToString(), "Number of Rows with Full Occupancy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
