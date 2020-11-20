/*
 * Project:         Assignment Set 6 - Program 14
 * Date:            October 2020
 * Developed By:    LV
 * Class Name:      StockAnalyzer
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS605AS6
{
    class StockAnalyzer
    {
        #region "Properties"

        public string TickerSymbol { get; private set; }
        public decimal[] StockPrices { get; private set; }

        #endregion

        #region "Constructor"

        public StockAnalyzer(string symbol, decimal[] prices)
        {
            TickerSymbol = symbol;
            
            StockPrices = prices;
        }

        #endregion

        #region "Methods"

        /* Complete this method to find and return the smallest percentage gain in price between any two consecutive trading days.
         * 
         *  The return value should be formatted to display with a % sign and 5 decimal places.
         *  
         *  Percentage change in price between two consecutive trading days (e.g., Days 1 and 2) =
         *  
         *        (Day 2 Price - Day 1 Price) / Day 1 Price
        */

        public string FindSmallestPercentageGainInPrice()
        {
            string output = "No gain in Price";

            decimal currentMinGain = Decimal.MaxValue;

            for (int x = 1; x < StockPrices.Length -1; ++x)
            {
                decimal change = (StockPrices[x + 1] - StockPrices[x]) / StockPrices[x];

                if (change > 0 && change < currentMinGain)
                {
                    currentMinGain = change;
                }
            }

            output = $"{currentMinGain.ToString("p5")}";

            return output;
        }

        /* Complete this method to find and return the largest price change (either up or down) between any two consecutive trading days.  
         * 
         * Price change (either up or down) between two consecutive trading days (e.g., Days 1 and 2) =
         * 
         *        Absolute value of (Day 2 Price - Day 1 Price) 
        */

        public decimal FindLargestPriceChange()
        {
            //string output = "No change in Price";

            decimal currentMaxChange = (Math.Abs(StockPrices[1] - StockPrices[0]));
            

            for (int x = 1; x < StockPrices.Length -1; ++x)
            {
                decimal gain = (Math.Abs(StockPrices[x+1] - StockPrices[x]));

                if (gain > currentMaxChange)
                {
                    currentMaxChange = gain;
                }
            }


            return currentMaxChange;
        }

        /* Complete this method to find and return the number of times there is a negative change in price between any two consecutive trading days.
         * 
         * There is a negative change in price between two consecutive trading days (e.g., Days 1 and 2), if Day 2 Price - Day 1 Price < 0
        */

        public int FindNumTimesNegativePriceChange()
        {
            int counter = 1;    

            for (int x=1; x<StockPrices.Length -1; ++x)
            {
                
                if (StockPrices[x+1]-StockPrices[x]<0)
                {
                    ++counter;
                }
            }

            return counter;
        }

        /* Complete this method to find and return the longest period (in days) of continuous price gain.
         * 
         * There is a gain in price between two consecutive trading days (e.g., Days 1 and 2), if Day 2 Price - Day 1 Price > 0
        */

        public int FindLongestPriceGainStreak()
        {
            int streakCounter = 0;
            int counter = 0;

            for (int x=1; x < StockPrices.Length-1; ++x)
            {
                decimal priceGain = StockPrices[x+1] - StockPrices[x];
                if (priceGain > 0)
                {
                    ++counter;

                    if (counter > streakCounter)
                    {
                        ++streakCounter;
                    }
                }
                else counter = 0;
            }
            return streakCounter;
        }
   
        #endregion
    }
}