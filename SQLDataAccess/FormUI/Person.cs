using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{

    /*
     * 
     * When going through the stored procedure, will go through & grab the data aligned with the exact match for the fields listed. If not found,
     * it will fill it with Null.
     */
    public class Person
    {


        public string BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public string NameStlye { get; set; }
        public string title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }

        /*Errors out when this line is in there. Guessing it doesn't fit in a string.
        public string rowguid { get; set; }
        */

        public string ModifiedDate { get; set; }

        public string EmailAddress { get; set; }

        
        public string FullInfo
        {
            get 
            { 
                // "Catherine Abel (catherine0@adventure-works.com)"
                return $"{ FirstName } { LastName } ({ EmailAddress })"; 
            }
            
        }

    }
}
