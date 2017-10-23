using Caliburn.Micro;
using IGPUep.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IGPUep.ViewModels
{
    public class ManageIGPViewModel:Screen
    {

        private string _choosenPhoto;

        public string ChoosenPhoto
        {
            get { return _choosenPhoto; }
            set { Set(ref _choosenPhoto, value); }
        }



        private string _igpName;

        public string IGPName
        {
            get
            {
                return _igpName;
            }
            set
            {
                _igpName = value;
                NotifyOfPropertyChange();
            }
        }

        private string _igpZone;

        public string IGPZone
        {
            get
            {
                return _igpZone;
            }
            set
            {
                _igpZone = value;
                NotifyOfPropertyChange();
            }
        }



    


        public void SaveIgp()
        {
            using (var ctx = new AccountingContext())
            {
                //Voucher stud = new Voucher() { ModeOfPayment = "Cash" };
                //ctx.Vouchers.Add(stud);

                IGPs igpInfo = new IGPs()
                {
                    IGPsName = _igpName,
                    IGPsZone = _igpName


                };



                //Voucher dvNumber = new Voucher() { DVNumber = _dvNumber };
                ctx.IGPss.Add(igpInfo);


                ctx.SaveChanges();

                ClearIgp();
                
            }

          
        }

  


        public void ClearIgp()
        {
            _igpName = "";
            _igpZone = "";

        }


       

    }
}
