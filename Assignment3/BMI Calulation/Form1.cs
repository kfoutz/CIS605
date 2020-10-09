using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcBMI_Click(object sender, EventArgs e)
        {
            //declare local (i.e. method-level) variables

            string username;
            int weight, height, BMIcalc;

            BMI aBMI;

            //assign input data to variables

            username = tbxName.Text;

            weight = Convert.ToInt32(nudWeight.Value);
            height = Convert.ToInt32(nudIn.Value);
            

            // instantiate a BMI object

            aBMI = new BMI(username, weight, height);

            BMIcalc = aBMI.calcBMI;

            //display BMI

            lblBMIcalc.Text = BMIcalc.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reset the form for fresh inputs

            tbxName.Clear();
            nudIn.Value = 0;
            nudWeight.Value = 0;
            lblBMIcalc.Text = null;

            //set focus

            tbxName.Focus();
        }
    }
}
