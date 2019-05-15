using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class clsCustumer
    {
        //  PROPERTIES
        public string firstName { get; set; } // JOHN
        public string lastName { get; set; } // DOE
        public string address { get; set; } // 350 college st
        public string city { get; set; }// toronto
        public string province { get; set; }// ontario
        public string country { get; set; } // Canada
        public Guid uniqueIdCustumer { get; set; } // something more complex... '2837b519-198e-4f08-9825-1080657844db'
        public string typePayment { get; set; } // e-transfer, debit or credict
        public decimal paidAmount { get; set; } // 10.00
        public string  product { get; set; } // skirt, jeans etc 


        // ALL METHODS/FUNCTIONS HERE 
        public void Byproduct(decimal paidAmount, string productName)
        {
            // code goes here
        }

        public void NewCustumer( string firstName, string lastName)
        {
            // code goes here
        }

    }
}
