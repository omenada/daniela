using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class clsMovie
    {
        //  PROPERTIES
        public string firstName { get; set; } // JOHN
        public string lastName { get; set; } // DOE
        public Guid uniqueIdCustumer { get; set; } // something more complex... '2837b519-198e-4f08-9825-1080657844db'
        public string typePayment { get; set; } // e-transfer, debit or credict
        public decimal paidAmount { get; set; } // 10.00
        public string movieName { get; set; } // skirt, jeans etc 
        
        // ALL METHODS/FUNCTIONS HERE 
        public void ByTicket( string movieName, string typePayment, Guid uniqueIdCustumer)
        {
            // code goes here
        }

        public void PAYMENT(decimal paidAmount, string movieName)
        {
            // code goes here
        }

    }
}
