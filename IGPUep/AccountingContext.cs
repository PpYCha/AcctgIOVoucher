
using IGPUep.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGPUep
{
    public class AccountingContext : DbContext
    {
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public AccountingContext()
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Voucher>().HasKey(k => k.VoucherID);
            modelBuilder.Entity<Payee>().HasKey(k => k.PayeeID);
        }
    }
}
