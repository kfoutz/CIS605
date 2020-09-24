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

namespace Program4_Loan
{
    class Loan
    {

     public  double CalculateMonthlyPayment( double nudLoanAmount,  double nudDuration,  double nudAPR)
    



        {



            return nudLoanAmount * (nudAPR / (100* 12)) * Math.Pow(1 + (nudAPR / (100* 12)), nudDuration)/ Math.Pow(1 + (nudAPR / (100* 12)), nudDuration -1);


        }

    


    }
}
