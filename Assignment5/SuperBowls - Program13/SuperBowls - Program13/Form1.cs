/*
 * Project:         Assignment 5 Program 13
 * Date:            November 2020
 * Developed By:    KCF
 * Class Name:      n/a
 * Purpose:         Functional Forms
*/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBowls___Program13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHowManyWins_Click(object sender, EventArgs e)
        {

            if (cboTeams.SelectedItem == null)
            {
                MessageBox.Show("You must a pick a team.", "Missing Team", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTeams.Focus();
                return;
            }

            else
            {
                string teamToFind = cboTeams.SelectedItem.ToString();

                int counter = 0;

                for (int x = 0; x < cboSuperBowlWinners.Items.Count; ++x)
                {
                    if (teamToFind == cboSuperBowlWinners.Items[x].ToString())
                    {
                        ++counter;
                    }

                }

                if (counter == 0)
                {
                    lblOutput.Text = $"The {teamToFind} have never\n won the SuperBowl.";
                }
                else if (counter == 1)
                {
                    lblOutput.Text = $"The {teamToFind} have won\n the SuperBowl once.";
                }
                else
                {
                    lblOutput.Text = $"The {teamToFind} have won\n the SuperBowl {counter} times.";
                }
            }
            
        }

        private void btnBack2Back_Click(object sender, EventArgs e)
        {
                        
            int counter = 0;

            for (int x = 0; x < cboSuperBowlWinners.Items.Count-1; ++x)
            {
                if (cboSuperBowlWinners.Items[x].ToString() == cboSuperBowlWinners.Items[x+1].ToString())
                {
                    ++counter; 
                }
            }

            lblBack2Back.Text = $"Teams have won the \nSuperbowl back to back {counter} times.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
