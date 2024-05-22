using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class DealerIphone
    {
        public int DealerID { get; set; }
        public int IphoneID { get; set; }
        public double Price { get; set; }

        //Nav. props for related dealer and iPhone
        public Dealer Dealer { get; set; }
        public IPhone IPhone { get; set; }
    }
}
