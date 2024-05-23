using App.Data.Entity;

namespace App.Web.Mvc.Models
{
    public class IphoneDealerViewModel
    {
        public int IphoneID { get; set; }
        public string ModelName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float ScreenSize { get; set; }
        public string CPU { get; set; }
        public int RAM { get; set; }
        public int Battery { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public decimal DealerPrice { get; set; }
        public string DealerName { get; set; }

    }
}
