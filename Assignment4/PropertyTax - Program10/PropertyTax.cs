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

        }










    }
}
