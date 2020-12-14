/*
 * Project:         Final Exam
 * Date:            December 2020
 * Developed By:    LV
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS605FinalExam
{
    class SalesPerson
    {

        #region "Properties"

        public string SalesPersonName { get; private set; }
        public int NumberOfCarsSold { get; private set; }
        public decimal DollarValueOfCarsSold { get; private set; }
        public decimal MonthlyCommission { get; private set; }

        #endregion

        #region "Constructor"
    
        public SalesPerson(string salesPersonName, int numCarsSold, decimal dollarValueOfCarsSold)
        {
            SalesPersonName = salesPersonName;
            NumberOfCarsSold = numCarsSold;
            DollarValueOfCarsSold = dollarValueOfCarsSold;

            MonthlyCommission = CalcMonthlyCommission();
        }

        #endregion

        #region "Methods"

        /*
         ***** Requirement 4 ***** (15 Points)
         * 
         * Write a private CalcMonthlyCommission method to calculate and return the monthly commission for a salesperson (the returned value's type should be decimal) based on the logic provided below:
         * 
         ********************************************************************** 
         * Number of Card Sold	     *          Monthly Commission            *
         **********************************************************************
         * 5 or fewer                *    2.19% of dollar value of cars sold  *
         **********************************************************************
         * 10 or fewer               *    3.53% of dollar value of cars sold  *
         * ********************************************************************
         * More than 10              *    4.82% of dollar value of cars sold  *
         **********************************************************************
         * 
         * Declare and use constants as needed.
        */

        private decimal CalcMonthlyCommission()
        {
            decimal monthlyCommissionFee;
            monthlyCommissionFee = MonthlyCommission;
            
            if (NumberOfCarsSold<=5)
            {
                MonthlyCommission = (decimal).0219 * (DollarValueOfCarsSold);
            }
            if (NumberOfCarsSold<=10)
            {
                MonthlyCommission = (decimal).0353 * DollarValueOfCarsSold;
            }
            else 
            {
                MonthlyCommission = (decimal).0482 * DollarValueOfCarsSold;
            }
            return MonthlyCommission;
        }

            

        #endregion
    }
}
