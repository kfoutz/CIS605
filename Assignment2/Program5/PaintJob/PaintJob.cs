﻿/*
 * Project:         Assignment 2; Program 5
 * Date:            September 13 2020
 * Developed By:    KCF
 * Class Name:      PainJob
 * Description:     Business Logic class for estimating paint jobs
 * Purpose:         Demonstrate examples of simple methods
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5_PaintJob
{
    class PaintJob
    {
        public double EstimatePaintJob( double txtSqft, double txtCostGallon)

        {

            //set some variables ($3.20 per sq ft is robbery.)

            double LaborCost, Coverage;

            LaborCost = 3.20;
            Coverage = 375;

            //calculate job cost.  


            return (((txtSqft / Coverage) * txtCostGallon) + (txtSqft * LaborCost));

        }

    }
}
