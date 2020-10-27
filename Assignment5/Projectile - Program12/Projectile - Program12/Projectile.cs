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
        private double landTime;
        private double feet;
        private double atTime;
        private double maxHeightTime;

        #endregion

        #region "Instance Properties"

        public int InitialHeight { get; private set; }
        public int InitialVelocity { get; private set; }
        //private double MaxHeightTime { get; set;  }
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
                //FindHeight(atTime);
            }
        }
        public double AtTime
        {
            get
            {
                return atTime;
            }
            set
            {
                atTime = value;
                //FindHeight(atTime);
            }
        }
        //private double Feet { get; set; }

                #endregion

                #region "Constructor"

                public Projectile(int initialHeight, int initialVelocity)
        {
            InitialHeight = initialHeight;
            InitialVelocity = initialVelocity;
            LandTime = landTime;
            MaxHeight = maxHeight;
            //MaxHeightTime = maxHeightTime;
            //Feet = feet;
            CalcMaxHeight();
            CalcLandTime();
            FindHeight(atTime);

        }

        #endregion

        #region "Methods"


        

        private double FindHeight(double atTime)
        {

            //atTime = 1;
            //time = atTime;
            //double feet;

            feet = InitialHeight + (InitialVelocity * atTime) - (16 * Math.Pow(atTime, 2));

            return feet;
        }

        private double CalcMaxHeight()
        {

            maxHeightTime = InitialVelocity / 32;

            //maxHeightTime = atTime;

            MaxHeight = FindHeight(maxHeightTime);




            return MaxHeight;
        }


        private double CalcLandTime()
        {
           
           
            //feet=FindHeight(atTime);
           
            
            
            do
            {
                //AtTime = MaxHeight+.1;
                //double landTime = .1;
                //landTime = atTime;
                feet = FindHeight(atTime);
                FindHeight(atTime);
                
                atTime += .1;
                //return feet, landTime;
            }
            while (feet > 0);
            return atTime;
       


        }
        #endregion
    }
}
