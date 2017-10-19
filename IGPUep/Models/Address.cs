using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGPUep.Models
{
    public class Address
    {
        public Address()
        {
        }

        public int AddressID { get; set; }
        public string Zone { get; set; }
        public string  Baranggay { get; set; }
        public string Municipality { get; set; }

    }

    

}
