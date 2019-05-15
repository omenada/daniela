using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    class clsdog
    {
        public string firstName { get; set; } // loly
        public Guid uniqueIdDog { get; set; } // something more complex... '2837b519-198e-4f08-9825-1080657844db'
        public string sex { get; set; } // male, female 
        public string color { get; set; } // black, gold etc 
        
    }


    public void femaleDogs(string firstName, string sex, Guid uniqueIdDog)
    {
        // code goes here
    }
    public void maleDogs(string firstName, string sex, Guid uniqueIdDog)
    {
        // code goes here
    }

    public void blackDogs(string firstName, string color, Guid uniqueIdDog)
    {
        // code goes here
    }
}


