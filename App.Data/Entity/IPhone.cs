using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class IPhone
    {
        public int IphoneID { get; set; }
        public string ModelName { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
        public double ScreenSize { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }
        public int Battery { get; set; }
        public string ImageUrl  { get; set; }
       
        //Nav. props. for related comments and dealers
        public ICollection<Comment> Comments { get; set; }

        public ICollection<DealerIphone> DealerIphones { get; set; }

    }
}