
using IGPUep.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGPUep
{
    public class AccountingContext:DbContext
    {
        public AccountingContext() : base("name=AccountingContext")
        {
        }
        public virtual DbSet<Voucher> Vouchers { get; set; }
       // public DbSet<Payee> Payees { get; set; }
    }
}
