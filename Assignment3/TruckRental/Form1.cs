using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables

            string name;
            int beginODO, endODO, numDays;
            decimal truckRentalCharge;

            TruckRental aTruckRental;

            // assign input data to variables

            name = tbxName.Text;

            beginODO = Convert.ToInt32(nudBeginODO.Value);
            endODO = Convert.ToInt32(nudEndODO.Value);
            numDays = Convert.ToInt32(nudDaysRented.Value);

            // instantiate a food object

            aTruckRental = new TruckRental() { CustomerName = name, BeginODO = beginODO, EndODO = endODO, NumDays = numDays };

            truckRentalCharge = aTruckRental.RentalCharge;

            lblRentalCharge.Text = truckRentalCharge.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
