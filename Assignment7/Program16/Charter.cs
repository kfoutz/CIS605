using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{
    
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
            

            CharterFee = CalcCharterFee();
        }

        #endregion

        #region "Methods"

        public decimal CalcCharterFee()
        {
            
            decimal yachtFee = 0;

            CharterFee = yachtFee;

            switch (YachtSize)
            {
                case 22:
                    yachtFee = yacht22 * HoursChartered;
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
            CharterFee = yachtFee;
            return CharterFee;

        }

        #endregion
    }

}
