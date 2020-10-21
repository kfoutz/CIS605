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

        //declare class vars

        private Conference aConference;
        private string conferenceName;
        private int numberAttendees, numberNights;
        private bool internetYN, recCenterYN;
        private AccomodationType accomodationChoice;

       

        private void btnCreateConf_Click(object sender, EventArgs e)
        {
            // check Name Text box
            
          
            if (tbxConferenceName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must provide a Conference Name.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxConferenceName.Focus();
                return;
            } 


            AssignInputs();

            //Conference aConference;

            aConference = new Conference(conferenceName, numberAttendees, numberNights, accomodationChoice, internetYN, recCenterYN);

            DisplayCharges();

            //disable/enable controls

            tbxConferenceName.Enabled = false;
            btnCreateConf.Enabled = false;
            btnModifyConf.Enabled = true;
        }

        private void btnModifyConf_Click(object sender, EventArgs e)
        {
            AssignInputs();

            //reset properties
            
            aConference.AccomodationChoice = accomodationChoice;
            aConference.NumberOfAttendees = numberAttendees;
            aConference.NumberOfNights = numberNights;
            aConference.InternetAccess = internetYN;
            aConference.RecCenterAccess = recCenterYN;

            DisplayCharges();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnModifyConf.Enabled = false;
            radSuite.Checked = true;
        }

        private void AssignInputs()
        {
            conferenceName = tbxConferenceName.Text;
            numberAttendees = Convert.ToInt32(nudNumAttendees.Value);
            numberNights = Convert.ToInt32(nudNumNights.Value);

            if (radSingle.Checked)
            {
                accomodationChoice = AccomodationType.Single;
            }
            else if (radDouble.Checked)
            {
                accomodationChoice = AccomodationType.Double;
            }
            else
            {
                accomodationChoice = AccomodationType.Suite;
            }

            internetYN = (cbxInternet.Checked) ? true : false;
            recCenterYN = (cbxGym.Checked) ? true : false;
        }

        private void DisplayCharges()
        {
            string strCharges = $" Accomodation Charge: {aConference.AccomodationCharge.ToString("c2")} \n Optional Services Charge: {aConference.OptionalServicesCharge.ToString("c2")} \n Discount: {aConference.Discount.ToString("c2")} \n Total Charges: {aConference.TotalCharge.ToString("c2")}";

            lblCharges.Text = strCharges;
        
        }

        





        //string confName;
        //    int numAttendees, numNights;
        //    AccomodationType roomType;
        //    bool internet, gym;


            
            //Conference aConference;
            
                      
            
        //    confName = tbxConferenceName.Text;

            
        //    numAttendees = Convert.ToInt32(nudNumAttendees.Value);
        //    numNights = Convert.ToInt32(nudNumNights.Value);


        //roomType = (radSingle.Checked) ? AccomodationChoice.SingleRoom : (radDouble.Checked) ? AccomodationChoice.DoubleRoom : AccomodationChoice.SuiteRoom;
        //    //internet = (cbxInternet.Checked) ? Conference.I;

        //    aConference = new Conference(confName, numAttendees, numNights, roomType, internet, gym);


        }
    }

