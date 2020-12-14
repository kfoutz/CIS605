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
using System.Windows.Forms;

namespace CIS605FinalExam
{
    /*
         ***** SeatingChart Class *****
         * 
         * This class has one property - a two dimensional array of CheckBoxes called Seats
         * 
         * To keep things simple, assume every seating chart object will have 25 rows (represented by the row dimension) and 10 seats per row (represented by the column dimension) 
         * 
         * The SeatingChartForm has code to instantiate a SeatingChart object and display the checkboxes in the Seats array. A user can indicate that a seat is taken by checking the corresponding checkbox
         * 
         * Requirements 1, 2, and 3 require you to write methods that process the two-dimensional array, Seats. 
        */

    class SeatingChart
    {
        #region "Properties"

        public CheckBox[,] Seats { get; private set; }
        
        #endregion

        #region "Ignore"

        public SeatingChart()
        {
            Seats = new CheckBox[25, 10];

            string[] strAlpha = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            
            for (int row = 0; row <= Seats.GetUpperBound(0); ++row)
            {
                for (int col = 0; col <= Seats.GetUpperBound(1); ++col)
                { 
                    CheckBox aBox = new CheckBox();
                    aBox.Width = 55;
                    aBox.Height = 18;
                    aBox.Text = (row + 1).ToString() + strAlpha[col];
                    Seats[row, col] = aBox;
                }
            }
        }

        #endregion

        #region "Methods"

        /*
         ***** Requirement 1 ***** (10 Points)
         * 
         * Write a public FindNumberOfTakenSeats method to find and return the number of seats that are taken (the returned value's type should be int)
         * 
        */
        public int FindnumberOfTakenSeats()
        {
            int seatsRow = Seats.GetLength(0);
            int seatsCol = Seats.GetLength(1);

            

            int totalSeats = 0;

            for (int row = 0; row < seatsRow; ++row)
            {
                for (int col = 0; col < seatsCol; ++col)
                {
                    totalSeats += Seats[row, col];

                    //I can't count checks
                }
            }
            return totalSeats;
        }


        

        /*
         ***** Requirement 2 ***** (20 Points)
         * 
         * Write a public FindSeatsAvailableByRow method to find and return the number of seats that are available in each row (the returned value's type should be a one-dimensional int array)
         * 
        */
        public FindSeatsAvailableByRow()
        {
            // I can't figure out how to count check boxes.
            //for each row 1 countRow1++
            //i don't know how to set this as the first item in AvailableSeats[]              //  
            //for each row 2 countRow2++
            //i don't know how to set this as the second item in AvailableSeats[] 
            //etc





            /***** Requirement 3 ***** (20 Points)  
            * 
            * Write a public FindNumberOfRowsWithAllSeatsTaken method to find and return the number of rows that are fully taken (i.e., all seats in that row are taken)
            * 
            * The returned value's type should be int
            * 
            */


            int full = 0;
            int seatsRow = Seats.GetLength(0);
        int seatsCol = Seats.GetLength(1);

            if  (Seats.checkbox[0,0]=checked)
                { full++}



            for (int col = 0; col < seatsCol; ++col)
            {
                for (int row = 0; row < seatsRow; ++row)
                {
                    if row = checked;
                        full++;
                }

            }




        }
       
        #endregion
    }
}
