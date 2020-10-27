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

        int InitialHeight, InitialVelocity;
        

       

        private void btnCalcMaxHeight_Click(object sender, EventArgs e)
        {
            InitialHeight = Convert.ToInt32(nudInitialHeight.Value);
            InitialVelocity = Convert.ToInt32(nudInitialVelocity.Value);
            
            aProjectile = new Projectile(InitialVelocity, InitialHeight);


            lblMaxHeight.Text = Convert.ToString(aProjectile.MaxHeight);
            lblHangTime.Text = Convert.ToString(aProjectile.AtTime);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblMaxHeight.Text = null;
            lblHangTime.Text = null;
            nudInitialHeight.Value = 0;
            nudInitialVelocity.Value = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
