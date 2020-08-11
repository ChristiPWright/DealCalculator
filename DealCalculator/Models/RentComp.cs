using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DealCalculator.Models
{
    public class RentComp
    {
        [Key]
        public int RentCompId { get; set; }
        public int PropertyId { get; set; }
        public int RentId1 { get; set; }
        public int RentId2 { get; set; }
        public int RentId3 { get; set; }
    }
}
