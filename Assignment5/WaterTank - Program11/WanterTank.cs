using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterTank___Program11
{
    class WaterTank
    {

        #region "Constants"

        const double addwater = 50; 

        #region "Auto-Implemented Properties"

        public double Radius { get; private set; }
        public double Depth { get; private set; }
        public double CurrentWaterLevel { get; private set; }
        public double MaximumWaterCapicity { get; private set; }

        #endregion

        #region "Constructor"

        public WaterTank(double radius, double depth, double currentWaterLevel, double maximumWaterCapacity)
        {
            Radius = radius;
            Depth = depth;
            CurrentWaterLevel = currentWaterLevel;
            MaximumWaterCapicity = maximumWaterCapacity;
        }

        #endregion

        #region "Methods"

        private void CalcTankCapacity()
        {
            MaximumWaterCapicity = Math.PI * Math.Pow(Radius, Radius) * Depth * 1000;
        }
        
        
        
        public string AddWater()

        {
            if (CurrentWaterLevel < MaximumWaterCapicity)
            

                do
                {
                    ++CurrentWaterLevel;
                }
                while (CurrentWaterLevel < MaximumWaterCapicity);
            
            else Console.WriteLine( "")
        }


    }
}
