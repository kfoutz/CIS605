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
    class SPManager
    {
        #region "Property"

        public List<SalesPerson> SalesPersonList { get; private set; } // a List collection for holding SalesPerson objects

        #endregion

        #region "Constructor"

        public SPManager()
        {
            SalesPersonList = new List<SalesPerson>();
        }

        #endregion

        #region "Methods"

        // instantiate a SalesPerson object, add it to the SalesPerson List collection, and return the monthly commission for the newly added salesperson

        
        public void AddSalesPerson(SalesPerson aSalesPerson)
        {
            SalesPersonList.Add(aSalesPerson);
        }
        
        public decimal AddSalesPerson(string salesPersonName, int numCarsSold, decimal dollarValueOfCarsSold)
        {
            SalesPerson aSalesPerson = new SalesPerson(salesPersonName, numCarsSold, dollarValueOfCarsSold);

            SalesPersonList.Add(aSalesPerson);

            return aSalesPerson.MonthlyCommission;
        }

        /*
         ***** Requirement 5 ***** (10 Points)
         * 
         * Write a public CalcAverageMonthlyCommission method to calculate and return the average monthly commission for all salespersons (the returned value's type should be decimal).
         * 
        */
        public decimal CalcAverageMonthlyCommission()
        {
            var average = (from aSalesPerson in SalesPersonList
                           select aSalesPerson.MonthlyCommission).Average();

            return average;
        }
        

        
        /*
         ***** Requirement 6 ***** (25 Points)
         * 
         * Complete the public FindHighPerformers method to find and return the name(s) of the salesperson(s) who either sold more than 10 cars OR the dollar value of the cars sold by them is more than $380,000 (return the name(s) as a List<string>).
         * 
         * * 
         * Declare and use constants as needed.
        */

        public List<string> FindHighPerformers()
        {
            var moreThanTen = (from aSalePerson in SalesPersonList
                               where aSalePerson.NumberOfCarsSold > 9
                               select aSalePerson.SalesPersonName);

            var moreThan380 = (from aSalesPerson in SalesPersonList
                               where aSalesPerson.DollarValueOfCarsSold > 380000
                               select aSalesPerson.SalesPersonName);


            return new List<string>();


           

        }

        #endregion
    }
}
