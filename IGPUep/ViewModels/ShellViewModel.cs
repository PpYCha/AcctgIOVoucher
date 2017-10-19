using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGPUep.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public void LoadIGP()
        {
            ActivateItem(new IGPViewModel());
        }

        public void LoadInputVoucher()
        {
            ActivateItem(new InputVoucherViewModel());
        }

        public void LoadCheckdj()
        {
            ActivateItem(new CheckdjViewModel());
        }

    }
}
