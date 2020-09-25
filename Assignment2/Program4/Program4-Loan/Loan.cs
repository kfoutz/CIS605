/*
 * Project:         Assignment 2; Program 4
 * Date:            September 13 2020
 * Developed By:    KCF
 * Class Name:      Loan
 * Description:     Business Logic class for Calculation Loans
 * Purpose:         Demonstrate examples of simple methods
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4_Loan
{
    class Loan
    {

             



     public double CalculateMonthlyPayment( double nudLoanAmount,  int nudDuration,  double nudAPR)

        
        {


            double monthlyIntrest, varDuration, varAmount, varMonthlyPayment ;

            monthlyIntrest = ((nudAPR /(100*12)));


            varDuration = nudDuration*12;

            varAmount = nudLoanAmount;

            varMonthlyPayment = varAmount * (monthlyIntrest * Math.Pow((1 + monthlyIntrest), varDuration)) / (Math.Pow((1 + monthlyIntrest), varDuration) - 1);

            return varMonthlyPayment;

            //Troubleshooting option.  Comment out above 'return' and uncomment below.  
            //return monthlyIntrest;
        }

    


    }
}
