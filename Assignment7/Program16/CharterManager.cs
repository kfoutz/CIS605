using System;
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
            Charter aCharter = new Charter(customerName, yachtType, yachtSize, (int)charterHours);

            Charters.Add(aCharter);
        }


        public decimal FindLowestCharterFee()
        {
            var lowest = Charters.Min(f => f.CharterFee);

            return lowest;
        }

        public decimal GetAverageCharterFee()
        {
            var average = (from aCharter in Charters
                           select aCharter.CharterFee).Average();

            return average;
        }

        public int GetCharterCount(yachtgroup aGroup)
        {


            int count = (from aCharter in Charters
                         where aCharter.YachtSize == (int)aGroup
                         select aCharter).Count();

            return count;
        }
       
        

    }
}
#endregion