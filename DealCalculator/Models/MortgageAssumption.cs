using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealCalculator.Models
{
    public class MortgageAssumption
    {
        [Key]
        public int MortgageId { get; set; }
        public int ProFormaId { get; set; }
        public int DownPayment { get; set; }
        public decimal InterestRate { get; set; }
        public int Term { get; set; }
    }
}
