using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectile___Program12
{
    class Projectile
    {

        #region "Fields"

        private double maxHeight;
        private double feet;
        private double atTime;
        private double maxHeightTime;

        #endregion

        #region "Instance Properties"

        public int InitialHeight { get; private set; }
        public int InitialVelocity { get; private set; }
        public double MaxHeight
        {
            get
            {
                return maxHeight;
            }
            set
            {
                maxHeight = value;                
            }
        }
        public double AtTime
        {
            get
            {
                return Math.Round(atTime, 3);
            }
            set
            {
                atTime=value;
            }
        }
        
                #endregion

                #region "Constructor"

                public Projectile(int initialHeight, int initialVelocity)
        {
            InitialHeight = initialHeight;
            InitialVelocity = initialVelocity;
            MaxHeight = maxHeight;
            CalcMaxHeight();
            CalcLandTime();
            FindHeight(atTime);

        }

        #endregion

        #region "Methods"

        private double FindHeight(double atTime)
        {
            feet = InitialHeight + (InitialVelocity * atTime) - (16 * Math.Pow(atTime, 2));

            return feet;
        }

        private double CalcMaxHeight()
        {
            maxHeightTime = InitialVelocity / 32;

            MaxHeight = FindHeight(maxHeightTime);

            return MaxHeight;
        }


        private double CalcLandTime()
        {           
            do
            {                
                feet = FindHeight(atTime);
                FindHeight(atTime);
                
                atTime += .1;                
            }
            while (feet > 0);
            
            return atTime;
        }
        #endregion
    }
}
