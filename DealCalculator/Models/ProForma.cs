using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealCalculator.Models
{
    public class ProForma
    {
        public int ProFormaId { get; set; }
        public int PropertyId { get; set; }
        public decimal Vacancy { get; set; }
        public decimal PropertyManagement { get; set; }
        public decimal PropertyTaxes { get; set; }
        public decimal PropertyInsurance { get; set; }
        public decimal Mortgage { get; set; }
        public decimal Garderner { get; set; }

    }
}
