using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Program8_PaySlip
{
    class PaySlip
    {
        #region "Instance Fields"

        public readonly string EmployeeName;

        public readonly decimal HoursWorked, PayRate, NetPay, GrossPay;

        #endregion

        #region "Auto-Implemented Static Properties"

        public static int TotalNumPaySlips { get; private set; }
        public static decimal TotalGrossPay { get; private set; }
        public static decimal TotalNetPay { get; private set; }

        #endregion

        #region "Constructors"

        public PaySlip(string employeeName, decimal hoursWorked, decimal payRate)
        {
            EmployeeName = employeeName;
            HoursWorked = hoursWorked;
            PayRate = payRate;
            GrossPay = hoursWorked * payRate;
            NetPay = CalculatePay();

            IncrementTotals();
        }

        
        #endregion

        #region "Instance Methods"

        private decimal CalculatePay()

        {

            //constants and variables

            const decimal fedTaxRate = .1075M;
            const decimal stateTaxRate = .0463M;
            const decimal socsecTaxRate = .062M;
            const decimal medTaxRate = .0145M;

            decimal grossPay;
            decimal netPay;

            grossPay = HoursWorked * PayRate;

            netPay = grossPay - ((grossPay * fedTaxRate) + (grossPay * stateTaxRate) + (grossPay * socsecTaxRate) + (grossPay * medTaxRate));

            //return netpay

            return netPay;
            
        
        }

        private void IncrementTotals()
        {
            //increment pay slips

            TotalNumPaySlips++;

            //add to gross pay

            TotalGrossPay += GrossPay;

            TotalNetPay += NetPay;
        }

        #endregion

        #region "Static Method"

        public static decimal CalculateAverageNetPay()
        {
            decimal result = 0;

            if (TotalNumPaySlips > 1)
            {
                result = (decimal)TotalNetPay / TotalNumPaySlips;
            }

            return result;
        }
        
        #endregion

    }
}
