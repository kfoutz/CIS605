using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4_Loan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Clear previous result
            lblPaymentAmount.ResetText();

            //Call the calulate method


            Loan aLoan = new Loan();
            lblPaymentAmount.Text = aLoan.CalculateMonthlyPayment(Convert.ToDouble(nudLoanAmount.Value), Convert.ToInt16(nudDuration.Value), Convert.ToDouble(nudAPR.Value)).ToString("C");
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset for new entry
            nudAPR.ResetText();
            nudDuration.ResetText();
            nudLoanAmount.ResetText();
            lblPaymentAmount.ResetText();
          

        }

        private void btnExit_Click(object sender, EventArgs e)
            //exit application
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
