/*
 * Project:         Assignment 5 Program 12
 * Date:            November 2020
 * Developed By:    KCF
 * Class Name:      Projectile
 * Purpose:         Caculations, bools and loops
*/


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

        #region "Constants"
        const int fakeGravity = 32;
        const double interval = .1;

        #endregion

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
            maxHeightTime = (double)InitialVelocity / fakeGravity;

            MaxHeight = (FindHeight(maxHeightTime));

            MaxHeight = Math.Round(MaxHeight, 2);
            return MaxHeight;
        }


        private double CalcLandTime()
        {

            do
            {                
                atTime += interval;
                
                FindHeight(atTime);
                               
            }
            while ((double)feet > 0);
            return atTime;
        }
        #endregion
    }
}
