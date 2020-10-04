using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckRental
{
    class TruckRental
    {
        #region "Auto-implemented Properties"

        public string CustomerName { get; set; }

        public decimal  RentalCharge { get; private set; }

        #endregion

        #region "Variables/ Fields"

        private int beginODO, endODO, numDays;

        #endregion

        #region "Properties"

        public int BeginODO
        {
            get
            {
                return beginODO;
            }
            set
            {
                beginODO = value;
                CalculateRentalCharge();
            }
        }
        public int EndODO
        {
            get
            {
                return endODO;
            }
            set
            {
                endODO = value;
                CalculateRentalCharge();

            }
        }

        public int NumDays
        {
            get
            {
                return numDays;
            }
            set
            {
                numDays = value;
                CalculateRentalCharge();
            }
        }

        #endregion

        #region "Constructors"

        public TruckRental() { }

        public TruckRental(string customerName, decimal rentalCharge, int beginODO, int endODO, int numDays)
        {
            customerName = CustomerName;
            rentalCharge = RentalCharge;
            beginODO = BeginODO;
            endODO = EndODO;
            numDays = NumDays;
        }
        #endregion

        #region "Methods"

        // a private method to calculate and set the cost for the truck rental object.

        private void CalculateRentalCharge()
        {
            //constants and variables

            const decimal chargePerDay = 52.75M;
            const decimal chargePerMile = 0.69M;

            decimal truckRentalCharge;

            //calculate rental charge

            truckRentalCharge = (NumDays * chargePerDay) + ((EndODO - BeginODO) * chargePerMile);

            RentalCharge = truckRentalCharge;

        }
        #endregion
    }
}
