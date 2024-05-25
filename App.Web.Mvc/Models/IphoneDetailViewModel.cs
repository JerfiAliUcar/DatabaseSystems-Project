using App.Data.Entity;

namespace App.Web.Mvc.Models
{
    public class IphoneDetailViewModel
    {
        public IPhone Iphone { get; set; }
        public List<DealerIphone> DealerIphones { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
