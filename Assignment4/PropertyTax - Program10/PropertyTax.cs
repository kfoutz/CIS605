using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTax___Program10
{
    #region "Enumeration"
    public enum LocationType
    {
        City,
        Suburb,
        Rural
    }
    #endregion


    class PropertyTax
    {






        #region "Instance Properties"

        private readonly string NamePropertyOwner;
        private readonly int BuildingSquareFootage, LandSquareFootage, YearBuilt;
        private readonly LocationType PropertyLocation;

        #endregion

        #region "Auto-Implemented Properties"

        public int BuildingAge { get; private set; }
        public decimal BuildingTax { get; private set; }
        public decimal BuildingTaxDeduction { get; private set; }
        public decimal LandTax { get; private set; }
        public decimal LandTaxDeduction { get; private set; }
        public decimal TotalPropertyTax { get; private set; }

        #endregion

        #region "Constructor"

        public PropertyTax(string namePropertyOwner, int buildingSquareFootage, int landSquareFootage, int yearBuilt, LocationType propertyLocation)
        {
            NamePropertyOwner = namePropertyOwner;
            BuildingSquareFootage = buildingSquareFootage;
            LandSquareFootage = landSquareFootage;
            YearBuilt = yearBuilt;
            PropertyLocation = propertyLocation;

            //CalculateBuildingTax();
            //CalculateLandTax();
            //CalcBuildingTaxDeduction();
            //CalcLandTaxDeduction();
            CalcPropertyTaxTotal();
        }

        #region "Private Methods"

        private void CalculateBuildingTax()
        {
            if (1 <= BuildingSquareFootage && BuildingSquareFootage <= 1000)
             
            {
                BuildingTax = (decimal)(BuildingSquareFootage * .71);
            }
            else if (BuildingSquareFootage <= 2000)
            {
                BuildingTax = (decimal)(((BuildingSquareFootage - 1000) * .73) + 710);
            }
            else if (BuildingSquareFootage <= 3000)
            {
                BuildingTax = (decimal)(((BuildingSquareFootage - 2000) * .75) + 1440);
            }
            else if (BuildingSquareFootage <= 4000)
            {
                BuildingTax = (decimal)(((BuildingSquareFootage - 3000) * .77) + 2190);
            }
            else { BuildingTax = (decimal)(((BuildingSquareFootage - 4000) * .80) + 2960); }

            
        }

        private void CalculateLandTax()
        {
            if (LandSquareFootage <= 10000)
            {
                LandTax = (decimal)(LandSquareFootage * .04);
            }
            else if (LandSquareFootage <= 20000)
            {
                LandTax = (decimal)(((LandSquareFootage - 10000) * .06) + 400);
            }
            else if (LandSquareFootage <= 30000)
            {
                LandTax = (decimal)(((LandSquareFootage - 20000) * .08) + 1000);
            }
            else if (LandSquareFootage <= 40000)
            {
                LandTax = (decimal)(((LandSquareFootage - 30000) * .1) + 1800);
            }
            else { LandTax = (decimal)(((LandSquareFootage - 40000) * .13) + 2800); }

            
        }

        private void CalcBuildingTaxDeduction()
        {
            DateTime current = DateTime.Now;
            BuildingAge = current.Year - YearBuilt;

            if (BuildingAge > 15)
            {
                BuildingTaxDeduction = (Decimal)(BuildingAge * (.005 * (double)BuildingTax));
            }
            else { BuildingTaxDeduction = 0; }

            
        }

        private void CalcLandTaxDeduction()
        {
            if (PropertyLocation == LocationType.Rural)
            {
                if (LandSquareFootage <= 22250)
                {
                    LandTaxDeduction = LandTax * (decimal)0.0025;
                }
                else LandTaxDeduction = LandTax * (decimal)0.0175;
            }
            else { LandTaxDeduction = 0; }

            
        }

        private void CalcPropertyTaxTotal()
        {

            CalculateBuildingTax();
            CalculateLandTax();
            CalcBuildingTaxDeduction();
            CalcLandTaxDeduction();
            TotalPropertyTax = (BuildingTax + LandTax) - (LandTaxDeduction + BuildingTaxDeduction);

        }
    }
}

    

        #endregion






    


#endregion