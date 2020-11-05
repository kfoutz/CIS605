using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WaterTank___Program11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //declare class-level variables

        private WaterTank aWaterTank;

        private void btnCreateWaterTank_Click(object sender, EventArgs e)
        {
            //declare method level variables

            int radius, depth, maxRadiusDepth;



            // assign inputs to local vars

            radius = ((int)nudRadius.Value);
            depth = ((int)nudDepth.Value);

            maxRadiusDepth = 6700;
            //instantiate obj

            

            {
                if (radius * depth > maxRadiusDepth)
                {
                    MessageBox.Show($"The combination of your Radius and Depth exceed the maximum capcity.  \nThe two multiplied together may not exceed {maxRadiusDepth}.", "No Olympic Pools", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nudDepth.Value = nudDepth.Minimum;
                    nudRadius.Value = nudRadius.Minimum;
                    nudRadius.Focus();
                    return;
                }
                else
                {
                    aWaterTank = new WaterTank(radius, depth);
                }

                //disable/enable cobntrols

                grpWaterTank.Enabled = false;
                grpWaterTankData.Enabled = true;
                grpAddWithdraw.Enabled = true;
                grpFillDrainWater.Enabled = true;
            }

        }
        

        private void btnMaximumCapacity_Click(object sender, EventArgs e)
        {
            //string strMaxCap = Convert.ToString(TankCapacity);

            tbxMaximumCapacity.Text = aWaterTank.TankCapacity.ToString("N0");

            //aWaterTank = new WaterTank(Radius, Depth, WaterLevel, TankCapacity);
        }

        private void btnCurrentWaterLevel_Click(object sender, EventArgs e)
        {
            tbxCurrentWaterLevel.Text = aWaterTank.WaterLevel.ToString("N0");
        }


        private void btnAddWithdrawWater_Click(object sender, EventArgs e)
        {
            int liters = Convert.ToInt32(nudLiters.Value);

            lblUpdate.Text = (radAddWater.Checked) ? aWaterTank.AddWater(liters) : aWaterTank.WithdrawWater(liters);

        }

        private void btnFillDrain_Click(object sender, EventArgs e)
        {
            string output = string.Empty;
            int liters = Convert.ToInt32(nudFillDrain.Value);

            if (radFill.Checked)
            {
                while (aWaterTank.FillTank(liters))
                {
                    output += aWaterTank.WaterLevel.ToString("N0") + " liters\r\n";
                    tbxFillDrain.Text = output;

                }
                tbxFillDrain.Text = output += "Full Tank";

            }
            else
            {
                while (aWaterTank.DrainTank(liters))
                {
                    output += aWaterTank.WaterLevel.ToString("N0") + " liters\r\n";

                }
                tbxFillDrain.Text = output += "Empty tank";
                tbxFillDrain.ScrollToCaret();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset the form for more adventures

            nudDepth.Value = nudDepth.Minimum;
            nudRadius.Value = nudRadius.Minimum;
            nudLiters.Value = nudLiters.Minimum;
            nudFillDrain.Value = nudFillDrain.Minimum;

            radAddWater.Checked = true;
            radFill.Checked = true;

            tbxFillDrain.Clear();
            tbxCurrentWaterLevel.Clear();
            tbxMaximumCapacity.Clear();


            //enable/disable controls
            grpWaterTank.Enabled = true;
            grpWaterTankData.Enabled = false;
            grpAddWithdraw.Enabled = false;
            grpFillDrainWater.Enabled = false;


            //set focus

            nudRadius.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //disable/enable cobntrols

            grpWaterTank.Enabled = true;
            grpWaterTankData.Enabled = false;
            grpAddWithdraw.Enabled = false;
            grpFillDrainWater.Enabled = false;

            radAddWater.Checked = true;
            radFill.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
