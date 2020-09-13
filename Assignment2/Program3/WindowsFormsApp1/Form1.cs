/*
 * Project:         Assignment 2; Example 3
 * Date:            Semptember 13 2020
 * Developed By:    KCF
 * Class Name:      N/A
 * Description:     Form control 
 * Purpose:         Demonstrate examples of simple form controls
*/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radBlack7_CheckedChanged(object sender, EventArgs e)
        {
            this.lblBand.ForeColor = System.Drawing.Color.Black;
        }

        private void radPurple1_CheckedChanged(object sender, EventArgs e)
        {
            this.lblBand.ForeColor = System.Drawing.Color.Purple;
        }

        private void radBlue2_CheckedChanged(object sender, EventArgs e)
        {
            this.lblBand.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }

        private void radGreen2_CheckedChanged(object sender, EventArgs e)
        {
            this.lblBand.ForeColor = System.Drawing.Color.LimeGreen;
        }

        private void radYellow4_CheckedChanged(object sender, EventArgs e)
        {
            this.lblBand.ForeColor = System.Drawing.Color.Gold;
        }

        private void radOrange5_CheckedChanged(object sender, EventArgs e)
        {
            this.lblBand.ForeColor = System.Drawing.Color.Orange;
        }

        private void radRed6_CheckedChanged(object sender, EventArgs e)
        {
            this.lblBand.ForeColor = System.Drawing.Color.Red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                this.lblGrabber.Visible = false;
            }
            else
            if (checkBox1.Checked == true)
            {
                this.lblGrabber.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                this.lblBand.Visible = false;
            }
            else
            if (checkBox2.Checked == true)
            {
                this.lblBand.Visible = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                this.pictureBoxAlbumCover.Visible = false;
            }
            else
            if (checkBox3.Checked == true)
            {
                this.pictureBoxAlbumCover.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                this.lblDeveloper.Visible = false;
            }
            else
            if (checkBox4.Checked == true)
            {
                this.lblDeveloper.Visible = true;
            }
        }
    }
}
