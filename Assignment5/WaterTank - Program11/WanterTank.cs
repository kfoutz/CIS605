using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterTank___Program11
{
    class WaterTank
    {

        #region "Constants"

        //const double addwater = 50; 
        const int minWater = 0;
        const int maxRadiusDepth = 6700;
        #endregion

        #region "Parameters"
        //public int LitersToAdd;
        



        #region "Auto-Implemented Properties"

        public double Radius { get; private set; }
        public double Depth { get; private set; }
        public int WaterLevel { get; private set; }
        public double TankCapacity { get; private set; }

        #endregion

        #region "Constructor"

        public WaterTank(double radius, double depth)
        {
            Radius = radius;
            Depth = depth;
            //WaterLevel = waterLevel;
            //TankCapacity = tankCapacity;
            //LitersToAdd = litersToAdd;
            CalcTankCapacity();
            //AddWater(litersToAdd);
            //WithdrawWater(litersToAdd);
        }

        #endregion


        #region "Methods"

        private int CalcTankCapacity()
        
            { 
                TankCapacity = Convert.ToInt32(Math.Floor(Math.PI * Math.Pow(Radius, 2) * Depth * 1000));
                return Convert.ToInt32(TankCapacity);
            }

        

            public string AddWater(int litersToAdd)
            {
                int currentToMax = (int)(TankCapacity - WaterLevel);

                string message = string.Empty;


                if (WaterLevel + litersToAdd < TankCapacity)

                {
                    WaterLevel += litersToAdd;
                    message = $"Water level increased by {litersToAdd}. \n Current water level is {WaterLevel} liters.\n Water may be increased by {currentToMax} liters.";
                }
                else
                {
                    message = $"You cannot add {litersToAdd} liters without overflowing. You may add {currentToMax} liters.";
                }

                return message;

            }
        

        public string WithdrawWater(int litersToWithdraw)
        {
            int currentToMin = (WaterLevel - minWater);

            string message = string.Empty;

            if (WaterLevel - litersToWithdraw > minWater)
            {
                WaterLevel -= litersToWithdraw;
                message = $"Water level decreased by {litersToWithdraw} liters.  {WaterLevel} liters remain.";
            }
            else
            {
                message = $"There is not enough water available to withdraw {litersToWithdraw} liters.  You may withdraw {currentToMin} liters.";
            }

            return message;
        }


        public bool DrainTank(int litersPerSecond)
        {
            int currentToMin = (WaterLevel - minWater);

            bool result = false;

            
            if (litersPerSecond<=currentToMin)
            {
                WaterLevel -= litersPerSecond;
                result = true;

            }
            return result;

            
        }

        public bool FillTank(int litersPerSecond)
        {
            int currentToMax = ((int)(TankCapacity - WaterLevel));

            bool result = false;

            if (litersPerSecond <= currentToMax)
            {
                WaterLevel += litersPerSecond;
                result = true;
            }
            return result;
        }   

     }
    #endregion
}
#endregion