/*
 * Project:         Assignment 5 Program 11
 * Date:            November 2020
 * Developed By:    KCF
 * Class Name:      WaterTank
 * Purpose:         Caculations, bools and loops
*/

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

        
        const int minWater = 0;
        const int maxRadiusDepth = 6700;
        const int literConversion = 1000;
        #endregion

        #region "Parameters"

        #endregion




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
            
            CalcTankCapacity();
        }

        #endregion


        #region "Methods"

        private int CalcTankCapacity()
        
            { 
                TankCapacity = Convert.ToInt32(Math.Floor(Math.PI * Math.Pow(Radius, 2) * Depth * literConversion));
                return Convert.ToInt32(TankCapacity);
            }

        

            public string AddWater(int litersToAdd)
            {
                int currentToMax = (int)(TankCapacity - WaterLevel);

                string message = string.Empty;


                if (WaterLevel + litersToAdd <= TankCapacity)

                {
                    WaterLevel += litersToAdd;
                int currentToMax2 = (int)(TankCapacity - WaterLevel);
                message = $"Water level increased by {litersToAdd} liters. \n Current water level is {WaterLevel} liters.\n Water may be increased by {currentToMax2} liters.";
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

            if (WaterLevel - litersToWithdraw >= minWater)
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
