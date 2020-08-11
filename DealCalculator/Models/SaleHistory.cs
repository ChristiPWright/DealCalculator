using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DealCalculator.Models
{
    public class SaleHistory
    {
        [Key]
        public int SaleId { get; set; }
        public int PropertyId { get; set; }
        [DataType(DataType.Date)]
        public DateTime ListDate { get; set; }
        public decimal ListPrice { get; set; }
        [DataType(DataType.Date)]
        public DateTime SoldDAte { get; set; }
        public decimal SoldPrice { get; set; }
        public int BuyerAgent { get; set; }
        public int SellerAgent { get; set; }
        public int Seller { get; set; }
        public int Buyer { get; set; }
    }
}
