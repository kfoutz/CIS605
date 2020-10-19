using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSU_Conference_Serivices___Program_9
{
    #region "Enumeration"
    public enum AccomodationType
    {
        Single,
        Double,
        Suite
    }
    #endregion
    class Conference
    {

        #region "Constants"

        //const decimal Single = 61.03;
        //const decimal Double = 39.59;
        //const decimal Suite = 73.45;

        #endregion


        #region "Auto-implemented Properties"

        public string ConferenceName { get; set; }
        public decimal AccomodationCharge { get; private set; }
        public decimal OptionalServicesCharge { get; private set; }
        public decimal Discount { get; private set; }
        public decimal TotalCharge { get; private set; }

        #endregion

        #region "Fields"

        private int numberOfAttendees, numberOfNights;
        private AccomodationType accomodationChoice;
        private bool internetAccess, recCenterAccess;
        private decimal internetAccessCharge, recCenterAccessCharge;
        

        public int NumberOfAttendees
        {
            get { return numberOfAttendees; }
            set 
            { 
                numberOfAttendees = value;
                CalculateRoomRate();
                ReturnAccomodationRate();
            }

        }

        public int NumberOfNights
        {
            get { return numberOfNights; }
            set 
            {
                numberOfNights = value;
                CalculateRoomRate();
                ReturnAccomodationRate();
            }
        }

        public AccomodationType AccomodationChoice
        {
            get { return accomodationChoice; }
            set 
            { 
                accomodationChoice = value;
                CalculateRoomRate();
                ReturnAccomodationRate();
            }
        }

        public bool InternetAccess
        {
            get { return internetAccess; }
            set 
            {
                internetAccess = value;
                CalculateRoomRate();
            }
        }
        
        public bool RecCenterAccess
        {
            get { return recCenterAccess; }
            set 
            {
                recCenterAccess = value;
                CalculateRoomRate();
            }
        }


        #endregion

        #region "Constructor"

        public Conference(string nameOfConference, int numberOfAttendees, int numberOfNights, AccomodationType accomodationChoice, bool internet, bool gym)
        {
            ConferenceName = nameOfConference;
            NumberOfAttendees = numberOfAttendees;
            NumberOfNights = numberOfNights;
            AccomodationChoice = accomodationChoice;
            InternetAccess = internet;
            RecCenterAccess = gym;
            
            //TotalCharge = CalcConferenceCharges();
            
        }

        #endregion

        

        #region "Instance Methods"

        private decimal ReturnAccomodationRate()
        {
            
            switch (AccomodationChoice)
            {
                case AccomodationType.Single:
                    AccomodationCharge = (decimal)61.03;
                    break;
                case AccomodationType.Double:
                    AccomodationCharge = (decimal)39.59;
                    break;
                default: AccomodationCharge = (decimal)73.45;
                    break;


            }
            return AccomodationCharge;
        }
        
        
        
        private void CalculateRoomRate()
        {
            const decimal inetCharge = 6.12M;
            const decimal recCharge = 5.37M;
            const decimal roomDiscount = .10M;
            const decimal optSrvcDiscount = .05M;
            
            decimal accomodationTotal;
            //decimal optInternet = inetCharge * numberOfAttendees * numberOfNights;
            //decimal optGym = recCharge * numberOfAttendees * numberOfNights;
            //decimal optServicesCharge;
            //decimal TotalCharge;
                
                
                 accomodationTotal = AccomodationCharge * NumberOfAttendees * NumberOfNights;


            if (InternetAccess == true)
            {
                internetAccessCharge = inetCharge * NumberOfAttendees * NumberOfNights;
            }
            else
            {
                internetAccessCharge = 0;
            }

            if (RecCenterAccess == true)
            {
                recCenterAccessCharge = recCharge * NumberOfAttendees * NumberOfNights;
            }
            else
            {
                recCenterAccessCharge = 0;
            }

            if (NumberOfAttendees >= 50 && NumberOfNights >= 7)
            {
                Discount = (accomodationTotal * roomDiscount) + (OptionalServicesCharge * optSrvcDiscount);
            }
            else
                Discount = 0;



            OptionalServicesCharge = internetAccessCharge + recCenterAccessCharge;
            TotalCharge = accomodationTotal + OptionalServicesCharge - Discount;


            //return TotalCharge;
        }

    }

    #endregion

}


