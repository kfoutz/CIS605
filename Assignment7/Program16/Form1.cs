using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CharterManager aCharterManager;


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCharter_Click(object sender, EventArgs e)
        {
            string customerName;
            int yachtSize;
            string yachtType;
            decimal charterhours;

            Charter aCharter;

            customerName = tbxName.Text;

            yachtSize = Convert.ToInt32(cbxYachtSize.SelectedValue);

            yachtType = Convert.ToString(cbxYachtType.SelectedValue);

            charterhours = Convert.ToInt32(nudHoursChartered.Value);

            aCharter = new Charter(customerName, yachtType, yachtSize, charterhours);

            if (aCharterManager is null)
            {
                aCharterManager = new CharterManager();
            }
            
            aCharterManager.AddCharter(aCharter);
        }

        private void allChartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllCharters().Show();
        }
    }
}
