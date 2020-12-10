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
            decimal yachtFee;

            Charter aCharter;

            customerName = tbxName.Text;

            yachtSize = Convert.ToInt32(cbxYachtSize.SelectedItem);

            yachtType = Convert.ToString(cbxYachtType.SelectedItem);

            charterhours = Convert.ToInt32(nudHoursChartered.Value);

            aCharter = new Charter(customerName, yachtType, yachtSize, charterhours);

            yachtFee = aCharter.CharterFee;

            aCharter = new Charter(customerName, yachtType, yachtSize, charterhours);

            

            if (aCharterManager is null)
            {
                aCharterManager = new CharterManager();
            }
            
            aCharterManager.AddCharter(aCharter);

            
        }

        private void allChartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCharters aCharters = new AllCharters();
            aCharters.charterManagerBindingSource.DataSource = aCharterManager;
            aCharters.ShowDialog();
            //new AllCharters().Show();
        }

        //private void noChartersForAYachtSizeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    string count;
            
        //    yachtgroup aYachtgroup = (yachtgroup)cbxYachtSize.SelectedValue;

        //    count = aCharterManager.GetCharterCount(aYachtgroup).ToString();

        //    //MessageBox
        //}
    }
}
