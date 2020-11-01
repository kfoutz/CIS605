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

        private double feet;
        private double atTime;
        private double maxHeightTime;

        #endregion

        #region "Instance Properties"

        public int InitialHeight { get; private set; }
        public int InitialVelocity { get; private set; }
        public double MaxHeight { get; set; }
        public double AtTime
        {
            get
            {
                return Math.Round(atTime, 2);
            }
            set
            {
                atTime = value;
            }
        }

        #endregion

        #region "Constructor"

        public Projectile(int initialHeight, int initialVelocity)
        {
            InitialHeight = initialHeight;
            InitialVelocity = initialVelocity;
            CalcMaxHeight();
            CalcLandTime();
        }

        #endregion

        #region "Methods"

        private double FindHeight(double atTime)
        {
            feet = (double)InitialHeight + ((double)InitialVelocity * atTime) - (16 * (atTime* atTime));

            return feet;
        }

        private double CalcMaxHeight()
        {
            maxHeightTime = (double)InitialVelocity / 32;

            MaxHeight = (FindHeight(maxHeightTime));

            MaxHeight = Math.Round(MaxHeight, 2);
            return MaxHeight;
        }


        private double CalcLandTime()
        {

            do
            {                
                atTime += .1;
                
                FindHeight(atTime);
                               
            }
            while ((double)feet > 0);
            return atTime;
        }
        #endregion
    }
}
