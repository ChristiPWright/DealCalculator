using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DealCalculator.Models
{
    public class RentHistory
    {
        public int RentId { get; set; }
        public int PropertyId { get; set; }
        public int Term { get; set; }
        public decimal Rent { get; set; }
        public decimal Deposit { get; set; }
        public bool Pet { get; set; }
        public decimal PetRent { get; set; }
        public int PropertyManager { get; set; }
        public string Concession { get; set; }
        public bool Dishwasher { get; set; }
        public bool WasherDryer { get; set; }
        [DataType(DataType.Date)]
        public DateTime RentedDate { get; set; }
    }
}
