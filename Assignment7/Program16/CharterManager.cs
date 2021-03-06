﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{
    class CharterManager
    {

        #region "Properties"

        public List<Charter> Charters { get; set; }

        #endregion

        #region "Constructor"

        public CharterManager()
        {
            Charters = new List<Charter>();
        }

        #endregion

        #region "Methods"

        public void AddCharter(Charter aCharter)
        {
            Charters.Add(aCharter);
        }


        public void AddCharter(string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            Charter aCharter = new Charter(customerName, yachtType, yachtSize, charterHours);

            Charters.Add(aCharter);
        }


        public decimal FindLowestCharterFee()
        {
            var lowest = Charters.Min(f => f.CharterFee);

            return lowest;
        }

        public List<Charter> GetAllCharters()
        {
            return Charters;
        }

        public decimal GetAverageCharterFee()
        {
            var average = (from aCharter in Charters
                           select aCharter.CharterFee).Average();

            return average;
        }

        public int GetCharterCount(int aGroup)
        {


            int count = (from aCharter in Charters
                         where aCharter.YachtSize == aGroup
                         select aCharter).Count();

            return count;
        }

        public decimal GetTotalCharterFees()
        {
            var total = (from aCharter in Charters
                         select aCharter.CharterFee).Sum();

            return total;
        }

    }  
}
#endregion