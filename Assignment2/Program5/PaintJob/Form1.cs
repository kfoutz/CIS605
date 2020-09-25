using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program5_PaintJob
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEtimate_Click(object sender, EventArgs e)
        {
            PaintJob aPaintJob = new PaintJob();

            string message = aPaintJob.EstimatePaintJob(Convert.ToDouble(nudSqFt.Value), Convert.ToDouble(nudCostGallon.Value)).ToString("C");
            string title = "Cost Estimate";
            MessageBox.Show(message, title);

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudCostGallon.ResetText();
            nudSqFt.ResetText();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudSqFt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
