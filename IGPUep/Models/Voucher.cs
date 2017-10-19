using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGPUep.Models
{
    public class Voucher
    {
        public Voucher()
        {
        }

        public int VoucherID { get; set; }
        public string FundCluster { get; set; }
       
        public string DVNumber { get; set; }
        public string ModeOfPayment { get; set; }
        public string TinOrEmployeeNumber { get; set; }
        public string OrsOrBurs { get; set; }
        public string Particulars { get; set; }
        public string Amount { get; set; }
        public string MFOPAP { get; set; }
        public string AccountTitle { get; set; }
        public string UacsCode { get; set; }
        public string Credit { get; set; }
        public string Debit { get; set; }
        public string JevNumber { get; set; }
        public DateTime? DateTIme1 { get; set; }

    }
}
