using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyTax___Program10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCreateTax_Click(object sender, EventArgs e)
        {
            if (tbxOwnersName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must provide an owner's name.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxOwnersName.Focus();

                //if (nudYear.Value > DateTime.Now)
            }
        }




        private void DisplayTax()
        {
            string strTax = $" Building Age: {aPropertyTax.BuildingAge.ToString()}\n Building Tax: {aPropertyTax.BuildingTax:c2} \n Land Tax: {aPropertyTax.LandTax:c2} \n Building Tax Deduction: {aPropertyTax.BuildingTaxDeduction:c2} \n Land Tax Deduction: {aPropertyTax.LandTaxDeduction:c2}\n Property Tax: {aPropertyTax.TotalPropertyTax:c2}";

            lblTaxes.Text = strTax;
        }
    }
}
