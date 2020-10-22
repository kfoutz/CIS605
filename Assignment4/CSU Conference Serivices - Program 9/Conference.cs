/*
 * Project:         Assignment 4 Program 09
 * Date:            October 2020
 * Developed By:    KCF
 * Class Name:      Conference
 * Purpose:         Demos public / private class scope, ennumeration, boolean form controls
*/


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

        const decimal Single = 61.03M;
        const decimal Double = 39.59M;
        const decimal Suite = 73.45M;
        const decimal inetCharge = 6.12M;
        const decimal recCharge = 5.37M;
        const decimal roomDiscount = .10M;
        const decimal optSrvcDiscount = .05M;

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
                
            }

        }

        public int NumberOfNights
        {
            get { return numberOfNights; }
            set 
            {
                numberOfNights = value;
                CalculateRoomRate();
               
            }
        }

        public AccomodationType AccomodationChoice
        {
            get { return accomodationChoice; }
            set 
            { 
                accomodationChoice = value;
                CalculateRoomRate();
                
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
            
            
            
        }

        #endregion

        

        #region "Instance Methods"

        private decimal ReturnAccomodationRate()
        {
            decimal roomRate;
            switch (AccomodationChoice)
            {
                case AccomodationType.Single:
                    roomRate = Single;
                    break;
                case AccomodationType.Double:
                    roomRate = Double;
                    break;
                default: roomRate = Suite;
                    break;


            }
            
            return roomRate;
        }
        
        
        
        private void CalculateRoomRate()
        {
            AccomodationCharge =  ReturnAccomodationRate()* NumberOfAttendees * NumberOfNights;

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
                Discount = (AccomodationCharge * roomDiscount) + (OptionalServicesCharge * optSrvcDiscount);
            }
            else
                Discount = 0;

            

            OptionalServicesCharge = internetAccessCharge + recCenterAccessCharge;
            TotalCharge = (AccomodationCharge + OptionalServicesCharge) - Discount;

        }

    }

    #endregion

}


