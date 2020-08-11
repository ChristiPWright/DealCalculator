using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DealCalculator.Models
{
    public class SaleComp
    {
        [Key]
        public int SaleCompId { get; set; }
        public int PropertyId { get; set; }
        public int SaleId1 { get; set; }
        public int SaleId2 { get; set; }
        public int SaleId3 { get; set; }
    }
}
