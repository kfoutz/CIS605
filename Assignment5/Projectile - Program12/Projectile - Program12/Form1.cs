﻿using System;
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
        //double  maxHeight;

       

        private void btnCalcMaxHeight_Click(object sender, EventArgs e)
        {
            InitialHeight = Convert.ToInt32(nudInitialHeight.Value);
            InitialVelocity = Convert.ToInt32(nudInitialVelocity.Value);
            
            aProjectile = new Projectile(InitialVelocity, InitialHeight);
            //maxHeight = aProjectile.MaxHeight;

            lblInfo.Text = Convert.ToString(aProjectile.MaxHeight);
        }

        private void btnCalcHangTime_Click(object sender, EventArgs e)
        {
            InitialHeight = Convert.ToInt32(nudInitialHeight.Value);
            InitialVelocity = Convert.ToInt32(nudInitialVelocity.Value);

            aProjectile = new Projectile(InitialVelocity, InitialHeight);

            lblInfo.Text = Convert.ToString(aProjectile.AtTime);
        }
    }
}
