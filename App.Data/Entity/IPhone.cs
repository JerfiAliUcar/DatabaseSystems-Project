using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class IPhone
    {
        public int iPhoneID { get; set; }
        public string ModelName { get; set; }
        public DateTime RealaseDate { get; set; }
        public double ScreenSize { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Battery { get; set; }
        public string ImageUrl  { get; set; }
        public double Price { get; set; }
    }
}