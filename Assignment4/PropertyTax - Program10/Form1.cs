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

        PropertyTax aPropertyTax;
        string namePropertyOwner;
        int buildingSquareFootage, landSquareFootage, yearBuilt;
        LocationType locationSetting;

        private void btnCreateTax_Click(object sender, EventArgs e)
        {
            if (tbxOwnersName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must provide an owner's name.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxOwnersName.Focus();
                return;
            
            //if (nudYear.Value > DateTime.Now)
            }

            

            AssignInputs();

            

            

            DisplayTax();
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            nudBuildingSquareFootage.Value = 0;
            nudLandSquareFootage.Value = 0;
            nudYear.Value = 0;
            radCity.Checked = false;
            radSuburb.Checked = false;
            radRural.Checked = false;
            lblTaxes.Text = null;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radCity.Checked = true;
            nudYear.Maximum = DateTime.Today.Year;

        }

        private void AssignInputs()
        {
            

            namePropertyOwner = tbxOwnersName.Text;
            buildingSquareFootage = Convert.ToInt32(nudBuildingSquareFootage.Value);
            landSquareFootage = Convert.ToInt32(nudLandSquareFootage.Value);
            yearBuilt = Convert.ToInt32(nudYear.Value);


     
            if (radCity.Checked)
            {
                locationSetting = LocationType.City;
            }
            else if (radSuburb.Checked)
            {
                locationSetting = LocationType.Suburb;
            }
            else
            {
                locationSetting = LocationType.Rural;
            }

            aPropertyTax = new PropertyTax(namePropertyOwner, buildingSquareFootage, landSquareFootage, yearBuilt, locationSetting);
        }

        private void DisplayTax()
        {
            string strTax = $" Building Age: {aPropertyTax.BuildingAge.ToString()}\n Building Tax: {aPropertyTax.BuildingTax:c2} \n Land Tax: {aPropertyTax.LandTax:c2} \n Building Tax Deduction: {aPropertyTax.BuildingTaxDeduction:c2} \n Land Tax Deduction: {aPropertyTax.LandTaxDeduction:c2}\n Property Tax: {aPropertyTax.TotalPropertyTax:c2}";

            lblTaxes.Text = strTax;
        }
    }
}
