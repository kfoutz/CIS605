using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program8_PaySlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreatePaySlip_Click(object sender, EventArgs e)
        {
            //declare local variables
            string strEmployeeName;
            decimal decHoursWorked, decPayRate, decNetPay;

            PaySlip aPayslip;

            // convert data in numeric up down controls and assign to variables

            strEmployeeName = Convert.ToString(tbxEmployeeName);
            decHoursWorked = Convert.ToDecimal(nudHoursWorked.Value);
            decPayRate = Convert.ToDecimal(nudPayRate.Value);

            // call the static  method CalculatePay

            aPayslip = new PaySlip(strEmployeeName, decHoursWorked, decPayRate);

            decNetPay = aPayslip.NetPay;

            //display netpay

            lblResultNetPay.Text = decNetPay.ToString("N0");
        }

        private void btnDisplaySummary_Click(object sender, EventArgs e)
        {
            string strMessage = $" Number of Pay Slips: {PaySlip.TotalNumPaySlips.ToString("n0")} \n Total Gross Pay: {PaySlip.TotalGrossPay.ToString("n0")} \n Total Net Pay: {PaySlip.TotalNetPay.ToString("n2")} Average Net Pay: {PaySlip.CalculateAverageNetPay().ToString("n2")}";

            MessageBox.Show(strMessage, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
