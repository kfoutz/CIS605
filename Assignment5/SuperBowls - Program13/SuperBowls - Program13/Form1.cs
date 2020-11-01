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
            string teamToFind = cboTeams.SelectedItem.ToString();

            int counter = 0;

            for (int x = 0; x < cboSuperBowlWinners.Items.Count; ++x)
            {
                if (teamToFind == cboSuperBowlWinners.Items[x].ToString())
                {
                    ++counter;
                }
            }

            lblOutput.Text = $"{teamToFind} won {counter} times.";
        }

        private void btnBack2Back_Click(object sender, EventArgs e)
        {
            string teamToFind = cboSuperBowlWinners.SelectedItem.ToString();
            
            int counter = 0;

            for (int x = 0; x < cboSuperBowlWinners.Items.Count-1; ++x)
            {
                if (cboSuperBowlWinners.Items[x].ToString() == cboSuperBowlWinners.Items[x+1].ToString())
                {
                    ++counter; 
                }
            }

            lblBack2Back.Text = $"Teams have won back to back {counter} times.";
        }
    }
}
