using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DealCalculator.Models
{
    public class ProForma
    {
        [Key]
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
