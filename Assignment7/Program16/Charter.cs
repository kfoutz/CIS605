using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{
    //#region "Enumeration"

    //public enum yachtgroup
    //{
    //    yacht22 = 1,
    //    yacht24 = 2,
    //    yacht30 = 3,
    //    yacht32 = 4,
    //    yacht36 = 5,
    //    yacht38 = 6,
    //    yacht45 = 7
    //}
    class Charter
    {

        #region "Constants"

        const decimal yacht22 = 208;
        const decimal yacht24 = 283;
        const decimal yacht30 = 305;
        const decimal yacht32 = 397;
        const decimal yacht36 = 495;
        const decimal yacht38 = 546;
        const decimal yacht45 = 675;

        #endregion

        #region "Properties"

        public string CustName { get; set; }
        public string YachtType { get; set; }
        public int YachtSize { get; set; }
        public decimal HoursChartered { get; set; }
        public decimal CharterFee { get; set; }

        #endregion "Properties"

        #region "Constructor"

        public Charter(string custname, string yachtType, int yachtSize, decimal hoursChartered)
        {
            CustName = custname;
            YachtType = yachtType;
            YachtSize = yachtSize;
            HoursChartered = hoursChartered;
            

            CalcCharterFee();
        }

        #endregion

        #region "Methods"

        public void CalcCharterFee()
        {
            
            decimal yachtFee = 0;

            CharterFee = yachtFee;

            switch (YachtSize)
            {
                case 22:
                    yachtFee = 208 * HoursChartered;
                    break;
                case 24:
                    yachtFee = yacht24 * HoursChartered;
                    break;
                case 30:
                    yachtFee = yacht30 * HoursChartered;
                    break;
                case 32:
                    yachtFee = yacht32 * HoursChartered;
                    break;
                case 36:
                    yachtFee = yacht36 * HoursChartered;
                    break;
                case 38:
                    yachtFee = yacht38 * HoursChartered;
                    break;
                case 45:
                    yachtFee = yacht45 * HoursChartered;
                    break;

                    
            }

            

            
        }

        #endregion
    }

}
