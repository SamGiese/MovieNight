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
    public class Movie
    {


        public int ID { get; set; }
        public string MovieName { get; set; }
        public int Available { get; set; }
        

        
        
        public string FullInfo
        {
            get 
            { 
                // "Catherine Abel (catherine0@adventure-works.com)"
                return $"{ MovieName }"; 
            }
            
        }

    }
}
