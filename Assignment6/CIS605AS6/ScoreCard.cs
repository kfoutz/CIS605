﻿/*
 * Project:         Assignment Set 6 - Program 15
 * Date:            November 2020
 * Developed By:    LV and KCF
 * Class Name:      ScoreCard
 * Assumption:      The scorecard is for a specific tournament and year
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS605AS6
{
    class ScoreCard
    {
        #region "Constants"

        const string PGATour = "2020 U.S. Open Championship", CourseName = "Winged Foot Golf Club";

        int[] CoursePars = { 4, 4, 3, 4, 4, 4, 3, 4, 5, 3, 4, 5, 3, 4, 4, 4, 4, 4 };

        #endregion

        #region "Properties"

        public string PlayerName { get; private set; }
        public int[,] ScoresByRound { get; private set; }

        #endregion

        #region "Constructor"

        public ScoreCard(string name, int[,] scores)
        {
            PlayerName = name;

            ScoresByRound = scores;
        }

        #endregion

        #region "Methods"

        /* Complete this method to calculate and return the player's status after each hole for a given round.
         * 
         * Status after hole 1 =  Score for hole 1 - Par for hole 1
         * 
         * Status after holes 2 through 18 = 
         * 
         *    Status after previous hole + (Score for current hole - Par for current hole)
        */



        public int[] CalcStatusAfterHole(int round)
        {

            int numHoles = ScoresByRound.GetLength(1);

            int[] statusByHole = new int[numHoles];

            statusByHole[0] = ScoresByRound[round - 1, 0] - CoursePars[0];

            for (int col = 1; col < numHoles; ++col)
            {
                statusByHole[col] = statusByHole[col - 1] + (ScoresByRound[round - 1, col] - CoursePars[col]);
            }

            return statusByHole;
        }
        /* Complete this method to calculate and return the player's average score for holes of a specific par (i.e., 3, 4 or 5).
         * 
         * Player's average score for holes of a specific par = 
         * 
         *  Player's total score for holes of a specific par for all 4 rounds / (Total number of holes of a specific par
         *           * number of rounds (i.e., 4))
         *           
         *  Note: Do not use a manual count of the number of holes of a specific par.
         *  
         *  Instead, write code to find the number of holes of a specific par.
        */

        public double CalcAverageScoreByPar(int par)
        {
                int numRounds = ScoresByRound.GetLength(0);
                int numHoles = ScoresByRound.GetLength(1);

                int numParHoles = 0;

                double totalParScore = 0;

                for (int col = 0; col < numHoles; ++col)
                {
                    if (CoursePars[col] ==par)
                    {
                        ++numParHoles;

                        for (int row = 0; row < numRounds; ++row)
                        {
                            totalParScore += ScoresByRound[row, col];
                        }
                    }
                }

            return totalParScore / (numParHoles * numRounds);

        }

        /* A player's score for a given hole is "consistent" if it is the same for all four rounds. 
         * 
         * Complete this method to find and return the number of holes for which the player's score was "consistent".
        */

        public int FindNumberOfHolesWithConsistentScore()
        {
            int countConsistentHoles = 0;
            int numRounds = ScoresByRound.GetLength(0);
            int numHoles = ScoresByRound.GetLength(1);

            for (int col = 0; col < numHoles; ++col)
            {
                bool status = true;
                for (int row = 0; row < numRounds -1;  ++row)
                {
                    if (ScoresByRound[row, col] != ScoresByRound[row+ 1, col])
                    {
                        status = false;
                        break;
                    }
                }
                if (status == true)
                {
                    ++countConsistentHoles;
                }
            }
            return countConsistentHoles;
        }

        /* Complete this method to calculate and return the player's overall performance by score type (i.e., Number of Eagles, Birdies, Pars, Bogeys and Double Bogeys)
         * 
         * Number of Eagles = Count of number of times player's score is two strokes below par
         * 
         * Number of Birdies = Count of number of times player's score is one stroke below par
         * 
         * Number of Pars = Count of number of times player's score is equal to par
         * 
         * Number of Bogeys = Count of number of times player's score is one stroke above par
         * 
         * Number of Double Bogeys = Count of number of times player's score is two strokes above par
        */

        public string CalcPerformanceByScoreType()
        {
            int numRounds = ScoresByRound.GetLength(0);
            int numHoles = ScoresByRound.GetLength(1);
            int eagleCounter = 0;
            int birdieCounter = 0;
            int parCounter = 0;
            int bogeyCounter = 0;
            int doubleBogeyCounter = 0;

            string message = string.Empty;


            for (int row =0; row < numRounds; ++ row)
            {
                for (int col = 0; col < numHoles -1; ++col)
                {
                    switch (ScoresByRound[row,col] - CoursePars[col])
                    {
                        case -2:
                            eagleCounter++;
                            break;
                        case -1:
                            birdieCounter++;
                            break;
                        case 0:
                            parCounter++;
                            break;
                        case 1:
                            bogeyCounter++;
                            break;
                        case 2:
                            doubleBogeyCounter++;
                            break;

                    }
                } message = $"{PlayerName} scored {eagleCounter} Eagles, {birdieCounter} Birdies, {parCounter} Pars, {bogeyCounter} Bogeys and {doubleBogeyCounter} Double Bogeys.";
            }
            return message;
        }

        #endregion
    }
}