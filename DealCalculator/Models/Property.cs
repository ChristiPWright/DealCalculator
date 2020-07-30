using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealCalculator.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string StreetAddress { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int Sqft { get; set; }
        public int Bed { get; set; }
        public decimal Bath { get; set; }
        public int YearBuilt { get; set; }
        public decimal LotSize { get; set; }
        public string Heating { get; set; }
        public string Cooling { get; set; }
        public int CurrentOwner { get; set; }
        public string Note { get; set; }
        //public string Picture { get; set; }

    }
}
