using Caliburn.Micro;
using IGPUep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGPUep.ViewModels
{
    public class InputVoucherViewModel : Screen
    {

        public ICollection<string> MFOPAPList { get; set; } = new List<string>
        {
           "GAS - 1001 003 02 001",
           "STO - 1001 002 01 001",
           "MFO1 - 1001 003 01 001",
           "MFO2 - 1001 003 02 001",
           "MFO3 - 1001 003 03 001",
           "MFO4 - 1001 003 04 001"
        };

        public ICollection<string> ModeOfPaymentList { get; set; } = new List<string>
        {
            "MDS Check",
            "Command Check",
            "ADA",
            "Others (Plase Specify)"
        };

        public ICollection<string> AccountTitleList { get; set; } = new List<string>
        {
            "Account Title 1",
            "Account Title 2",
            "Account Title 3",
            "Account Title 4",
            "Account Title 5"
        };

        public ICollection<string> UacsCodeList { get; set; }

        private string _fundCluster;

        public string FundCluster
        {
            get
            {
                return _fundCluster;
            }
            set
            {
                _fundCluster = value;
              
            }
        }

        private string _dvNumber;

        public string DVNumber
        {
            get
            {
                return _dvNumber;
            }
            set
            {
                _dvNumber = value;
            }
        }

        private DateTime?  _dateTime1;

        public DateTime?  DateTime1
        {
            get
            {
                return _dateTime1;
            }
            set
            {
                _dateTime1 = value;
            }
        }


        //public string ModeOfPayment { get; set; }
        //public string TinOrEmployeeNumber { get; set; }
        //public string OrsOrBurs { get; set; }
        //public string Address { get; set; }
        //public string Particulars { get; set; }
        //public string Amount { get; set; }
        //public string MFOPAP { get; set; }

        private string _tinOrEmployeeNumber;

        public string TinOrEmployeeNumber
        {
            get
            {
                return _tinOrEmployeeNumber;
            }
            set
            {
                _tinOrEmployeeNumber = value;
            }
        }

        private string _orsOrBurs;

        public string OrsOrBurs
        {
            get
            {
                return _orsOrBurs;
            }
            set
            { _orsOrBurs = value;
            }
        }

        private string _particulars;

        public string Particulars
        {
            get
            {
                return _particulars;
            }
            set {
                _particulars = value;
            }
        }

        private string _mFOPAP;

        public string MFOPAP
        {
            get { return _mFOPAP; }
            set { _mFOPAP = value; }
        }






        public void SaveBtn()
        {
            using (var ctx = new AccountingContext())
            {
                //Voucher stud = new Voucher() { ModeOfPayment = "Cash" };
                //ctx.Vouchers.Add(stud);

                Voucher fundClusterNumber = new Voucher()
                { FundCluster = _fundCluster,
                  DVNumber = _dvNumber,
                  DateTIme1 = _dateTime1,
                  TinOrEmployeeNumber = _tinOrEmployeeNumber,
                  MFOPAP = _mFOPAP

                };

                //Voucher dvNumber = new Voucher() { DVNumber = _dvNumber };
                ctx.Vouchers.Add(fundClusterNumber);
                ctx.SaveChanges();

                ClearBtn();
            }
        }

        public void ClearBtn()
        {
            //_fundCluster = "";
            //NotifyOfPropertyChange(() => FundCluster);
        }
    }
}
