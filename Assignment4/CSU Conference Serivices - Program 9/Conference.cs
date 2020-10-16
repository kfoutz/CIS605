using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSU_Conference_Serivices___Program_9
{
    #region "Enumeration"
    public enum AccomodationChoice
    {
        SingleRoom,
        DoubleRoom,
        SuiteRoom
    }
    class Conference
    {

        #region "Constants"

        //const double SingleRoom = 61.03;
        //const double DoubleRoom = 39.59;
        //const double SuiteRoom = 73.45;

        #endregion


        #region "Auto-implemented Properties"
        public string ConferenceName { get; set; }
        public double AccomodationCharge { get; private set; }
        public double OptionalServiceCharge { get; private set; }
        public double Discount { get; private set; }
        public double TotalCharge { get; private set; }

        #endregion

        #region "Properties"

        private int numberOfAttendees, numOfNights;
        private int accomodationChoice;
        private bool internetAccess, recCenterAccess;
        private AccomodationChoice roomType;

        public int NumberOfAttendees
        {
            get { return numberOfAttendees; }
            set 
            { 
                numberOfAttendees = value;
                CalculateRoomRate();
            }

        }

        public int NumOfNights
        {
            get { return numOfNights; }
            set 
            {
                numOfNights = value;
                CalculateRoomRate();
            }
        }

        public AccomodationChoice RoomType
        {
            get { return roomType; }
            set 
            { 
                roomType = value;
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

        public Conference(string nameOfConference, int attendeesNumber, int nightsNumber, int accomodationChoice, bool internet, bool gym)
        {
            ConferenceName = nameOfConference;
            NumberOfAttendees = attendeesNumber;
            NumOfNights = nightsNumber;
            AccomodationChoice = accomodationChoice;
            InternetAccess = internet;
            RecCenterAccess = gym;
            
            //totalCharge = CalculateRoomRate();
            
        }

        #endregion

        

        #region "Instance Methods"

        private double RoomChoice()
        {
            //double room = 0;
            //if (AccomodationChoice >= 3)
            //{
            //    room = SuiteRoom;
            //}
            //else if (AccomodationChoice >= 2)
            //{
            //    room = DoubleRoom;
            //}
            //else 
            //{
            //    room = SingleRoom;
            //}
            
            switch (room)
            {
                case accomodationChoice.SingleRoom:
                    room = 31.03;
                    break;
                case 2:
                    break;
                default:
                    break;


            }
            //return room;
        }
        
        private double CalculateRoomRate()
        {
            const double inetCharge = 6.12;
            const double recCharge = 5.37;
            const double roomDiscount = .10;
            const double optSrvcDiscount = .05;
                    
            
            double accomodationCharge = RoomChoice() * numberOfAttendees * numOfNights;
            double optInternet = inetCharge * numberOfAttendees * numOfNights;
            double optGym = recCharge * numberOfAttendees * numOfNights;
            double optServicesCharge = optInternet + optGym;

            if (NumberOfAttendees > 50 && numOfNights > 7)
            {
                Discount = (AccomodationCharge * roomDiscount) + (optServicesCharge * optSrvcDiscount);
            }
            else
                Discount = 0;



            TotalCharge = AccomodationCharge + optServicesCharge - Discount;


            return CalculateRoomRate();
        }

    }

    #endregion

}


#endregion