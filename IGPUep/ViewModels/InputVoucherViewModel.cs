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
            "Cash - Collecting Officers",
            "Travelling Expenses - Local",
            "Office Supplies",
            "Fuel, Oil & Lubricants Expense",
            "Semi - Expendable Machinery & Equipment Expense",
            "Other Machinery & Equipment",
            "Electricity Expenses",
            "Internet Subscription Expenses",
            "Postage & Counter Expenses",
            "Repairs and Maintenance - Investment Property",
            "Repairs and Maintenance - Machinery Equipment",
            "Taxes, Dutties & Licenses",
            "Labor & Wages",
            "Other Maintenance & Operating Expense - Subscription Expenses",
            "Other Maintenance & Operating Expense"
        };

        public ICollection<string> UacsCodeList { get; set; } = new List<string>
        {
            "1010101000",
            "5020101000",
            "5020301000",
            "5020309000",
            "5020321000",
            "5020321099",
            "5020402000",
            "5020503000",
            "5020501000",
            "5021301000",
            "5021305000",
            "5021501001",
            "5021601000",
            "5029907000",
            "5029999002"
        };





        //public string ModeOfPayment { get; set; }
        //public string TinOrEmployeeNumber { get; set; }
        //public string OrsOrBurs { get; set; }
        //public string Address { get; set; }
        //public string Particulars { get; set; }
        //public string Amount { get; set; }
        //public string MFOPAP { get; set; }


        //Voucher

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
                NotifyOfPropertyChange();

            }
        }

        private DateTime? _dateTime1;

        public DateTime? DateTime1
        {
            get
            {
                return _dateTime1;
            }
            set
            {
                _dateTime1 = value;
                NotifyOfPropertyChange();
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
                NotifyOfPropertyChange();
            }
        }

        private string _modeOfPayment;

        public string ModeOfPayment
        {
            get
            {
                return _modeOfPayment;
            }
            set
            {
                _modeOfPayment = value;
                NotifyOfPropertyChange();
            }
        }

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
                NotifyOfPropertyChange();
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
                NotifyOfPropertyChange();
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
                NotifyOfPropertyChange();
            }
        }

        private string _mFOPAP;

        public string MFOPAP
        {
            get {
                return _mFOPAP;
            }
            set
            {
                _mFOPAP = value;
                NotifyOfPropertyChange();
            }
        }

        private string _amount1;

        public string Amount1
        {
            get
            {
                return _amount1;
            }
            set
            {
                _amount1 = value;
                NotifyOfPropertyChange(() => Amount1);
            }
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
                  ModeOfPayment = _modeOfPayment,
                  TinOrEmployeeNumber = _tinOrEmployeeNumber,
                  OrsOrBurs = _orsOrBurs,
                  Particulars = _particulars,
                  MFOPAP = _mFOPAP,
                  
                  

                };

            

                //Voucher dvNumber = new Voucher() { DVNumber = _dvNumber };
                ctx.Vouchers.Add(fundClusterNumber);
            
            
                ctx.SaveChanges();
                
                ClearBtn();
            }
        }

        public void ClearBtn()
        {
            FundCluster = "";
            DVNumber = "";
            
            ModeOfPayment = "";
            TinOrEmployeeNumber = "";
            OrsOrBurs = "";
            Particulars = "";
            MFOPAP = "";
        }
    }
}
