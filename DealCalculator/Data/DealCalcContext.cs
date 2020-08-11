using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DealCalculator.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealCalculator.Data
{
    //[Table("")]
    public class DealCalcContext:DbContext
    {
        public DealCalcContext (DbContextOptions<DealCalcContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<MortgageAssumption> MortgageAssumptions { get; set; }
        public DbSet<ProForma> ProFormas { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<RentComp> RentComps { get; set; }
        public DbSet<RentHistory> RentHistories { get; set; }
        public DbSet<SaleComp> SaleComps { get; set; }
        public DbSet<SaleHistory> SaleHistories { get; set; }

    }
}
