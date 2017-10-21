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

            //using (var context = new AccountingContext())
            //{
            //    // Query for all blogs with names starting with B 

            //    foreach (var item in context.IGPss)
            //    {
               
            //    }
            //}
        }

      
        public void LoadCheckdj()
        {
            ActivateItem(new ManageIGPViewModel());
            

           
        }


   

    }
}
