using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSU_Conference_Serivices___Program_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateConf_Click(object sender, EventArgs e)
        {
            
            //declare local vars

            string confName;
            int numAttendees, numNights;
            AccomodationChoice roomType;
            bool internet, gym;


            
            Conference aConference;
            
                      
            
            confName = tbxConferenceName.Text;

            
            numAttendees = Convert.ToInt32(nudNumAttendees.Value);
            numNights = Convert.ToInt32(nudNumNights.Value);
            roomType = (radSingle.Checked) ? AccomodationChoice.SingleRoom : (radDouble.Checked) ? AccomodationChoice.DoubleRoom : AccomodationChoice.SuiteRoom;
            //internet = (cbxInternet.Checked) ? Conference.I;

            aConference = new Conference(confName, numAttendees, numNights, roomType, internet, gym);


        }
    }
}
