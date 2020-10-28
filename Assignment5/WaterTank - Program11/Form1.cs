using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterTank___Program11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WaterTank aWaterTank;

        double Radius, Depth;
        int WaterLevel, TankCapacity;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximumCapacity_Click(object sender, EventArgs e)
        {
            //string strMaxCap = Convert.ToString(TankCapacity);



            aWaterTank = new WaterTank(Radius, Depth, WaterLevel, TankCapacity);
        }

        private void btnCreateWaterTank_Click(object sender, EventArgs e)
        {
            Radius = Convert.ToDouble(nudRadius.Value);
            Depth = Convert.ToDouble(nudDepth.Value);

            aWaterTank = new WaterTank(Radius, Depth, WaterLevel, TankCapacity);

            Convert.ToString(TankCapacity) = tbxMaximumCapacity.Text;
        }
    }
}
