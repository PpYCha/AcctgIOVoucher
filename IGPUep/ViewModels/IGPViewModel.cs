﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGPUep.ViewModels
{
    public class IGPViewModel : Conductor<object>
    {
        public void LoadInputVoucher()
        {
            ActivateItem(new InputVoucherViewModel());
          

        }


       

    }
}
