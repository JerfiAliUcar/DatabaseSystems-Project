using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class Dealer
    {
        public int DealerID { get; set; }
        public string DealerName { get; set; }
        public string DealerAddress { get; set; }
        public string Description { get; set; }
    
        //Nav. prop. for related iPhones
        public ICollection<DealerIphone> DealerIphones { get; set; }
    
    }
}