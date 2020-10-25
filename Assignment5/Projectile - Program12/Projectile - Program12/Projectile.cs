using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectile___Program12
{
    class Projectile
    {

        #region "Fields"

        private double maxHeight;
        private double landTime;
        private double feet;

        #endregion

        #region "Instance Properties"

        public int InitialHeight { get; private set; }
        public int InitialVelocity { get; private set; }
        public double LandTime
        {
            get
            {
                return landTime;
            }
            set
            {
                landTime = value;
            }
        }
        public double MaxHeight
        {
            get
            {
                return maxHeight;
            }
            set
            {
                maxHeight = value;
                //FindHeight();
            }
        }
        public double Feet
        {
            get
            {
                return feet;
            }
            set
            {
                feet = value;
                //FindHeight();
            }
        }


                #endregion

                #region "Constructor"

                public Projectile(int initialHeight, int initialVelocity)
        {
            InitialHeight = initialHeight;
            InitialVelocity = initialVelocity;
            LandTime = landTime;
            MaxHeight = maxHeight;
            Feet = feet;
            CalcMaxHeight();
            CalcLandTime();

        }

        #endregion

        #region "Methods"
        private double FindHeight(double time)
        {
           
            double atTime = maxHeight;
            time = atTime;
            double feet;

            feet = InitialHeight + (InitialVelocity * time) - (16 * Math.Pow(time, 2));

            return feet;
        }


        private double CalcMaxHeight()
        {
            
              maxHeight = InitialVelocity / 32;

            return maxHeight;
        }

        private double CalcLandTime()
        {
            double landTime = .01;
            double feet;
            feet=FindHeight(landTime);
            //int i = 1;

            do
            {
                FindHeight(landTime);
                ++landTime;
            }
            while (feet > 0);
            return landTime;
       


        }
        #endregion
    }
}
