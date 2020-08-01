using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealCalculator.Models
{
    public class MortgageAssumption
    {
        public int ProFormaId { get; set; }
        public int DownPayment { get; set; }
        public decimal InterestRate { get; set; }
        public int Term { get; set; }
    }
}
