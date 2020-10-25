using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectile___Program12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Projectile aProjectile;

        int initialHeight, initialVelocity;
        //double landTime, maxHeight;

       

        private void btnCalcMaxHeight_Click(object sender, EventArgs e)
        {
            initialHeight = Convert.ToInt32(nudInitialHeight.Value);
            initialVelocity = Convert.ToInt32(nudInitialVelocity.Value);

            aProjectile = new Projectile(initialVelocity, initialHeight);

            lblInfo.Text = Convert.ToString(aProjectile.Feet);
        }

        private void btnCalcHangTime_Click(object sender, EventArgs e)
        {

        }
    }
}
