using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace WaterTank___Program11
{
    class WaterTank
    {

        #region "Constants"

        //const double addwater = 50; 
        #endregion

        #region "Parameters"
        private int litersToAdd;
        



        #region "Auto-Implemented Properties"

        public double Radius { get; private set; }
        public double Depth { get; private set; }
        public int WaterLevel { get; private set; }
        public double TankCapacity { get; private set; }

        #endregion

        #region "Constructor"

        public WaterTank(double radius, double depth, int waterLevel, int tankCapacity)
        {
            Radius = radius;
            Depth = depth;
            WaterLevel = waterLevel;
            TankCapacity = tankCapacity;

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
            if (WaterLevel < TankCapacity  && litersToAdd>0)
               
                do
                {
                    WaterLevel += litersToAdd;
                }
                while (WaterLevel < TankCapacity);
                return Convert.ToString(WaterLevel);
            
        }

        public bool DrainTank(int litersPerSecond)
        {
            if (WaterLevel == 0)
                return false;
            else
            
            do
            {
                WaterLevel-= litersPerSecond;
            }
            while (WaterLevel >= 0);

            return true;

        }

        

        public string WithdrawWater(int litersToWithdraw)
        {
            if (WaterLevel >= 0 && litersToWithdraw>0)
                do
                {
                    WaterLevel -= litersToWithdraw;
                }
                while (WaterLevel >= 0);
            return Convert.ToString(WaterLevel);

           
        }

        public bool FillTank(int litersPerSecond)
        {
            if (WaterLevel == TankCapacity)
                return false;
            else
                do
                {
                    WaterLevel += litersToAdd;
                }
                while (WaterLevel < TankCapacity);
            return true;
            


        }   
     }
    #endregion
}
#endregion