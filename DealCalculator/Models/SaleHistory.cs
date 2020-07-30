using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DealCalculator.Models
{
    public class SaleHistory
    {
        public int SaleId { get; set; }
        public int PropertyId { get; set; }
        public DateTime ListDate { get; set; }
        public decimal ListPrice { get; set; }
        public DateTime SoldDAte { get; set; }
        public decimal SoldPrice { get; set; }
        public int BuyerAgent { get; set; }
        public int SellerAgent { get; set; }
        public int Seller { get; set; }
        public int Buyer { get; set; }
    }
}
