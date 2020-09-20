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


            //Call the calulate method

            Loan aLoan = new Loan();
            lblPaymentAmount.Text = aLoan.CalculateMonthlyPayment(nudLoanAmount.Value, Convert.ToInt32(nudDuration.Value), nudAPR.Value).ToString("N2");

        }
    }
}
