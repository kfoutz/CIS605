/*
 * Project:         Assignment 3 Program 6 - BMI
 * Date:            October 2020
 * Developed By:    Kerry Foutz
 * Class Name:      BMI
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calulation
{
    class BMI
    {

        #region "Variables/Fields"

        private string userName;
        private int userWeight, userInch;

        #endregion

        #region "Properties"

        public int UserWeight
        {
            get
            {
                return userWeight;
            }
            set
            {
                userWeight = value;
                //CalculateBMI();
            }
        }
        
       
        public int UserInch
        {
            get
            {
                return userInch;
            }
            set
            {
                userInch = value;
                CalculateBMI();
            }
        }

        #endregion

        #region"Auto-implemented Properties"

        public string UserName { get; set; }
        public int calcBMI { get; set; }


        #region "Constructors"

        public BMI(string userName, int userWeight, int userInch)
        {
            UserName = userName;
            UserWeight = userWeight;
            UserInch = userInch;
        }
        
        public BMI() { }

        #endregion

        #region "Methods"

        private void CalculateBMI()
        {
            //constructs and variables

            const int MagicNumber = 703;

            //const int userInch = 70;
            int userTallnes = (int)Math.Pow(userInch, 2);

            int userBMI;

            
            userBMI = (userWeight * MagicNumber/userTallnes);

            //set the BMI property value

             calcBMI = userBMI;

        }

        #endregion




    }
}
#endregion