using App.Business.Services.Abstracts;
using App.Data;
using App.Data.Entity;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace App.Business.Services
{
    public class IphoneService : IiphoneService
    {
        private readonly AppDbContext _db;

        public IphoneService(AppDbContext db)
        {
            _db = db;
        }

        public List<IPhone> GetAllPhones()
        {
            var entityList = _db.Iphone.ToList();
            return entityList;
        }

        public IPhone GetIphoneByID(int id)
        {
            var iphone = _db.Iphone.FirstOrDefault(u => u.IphoneID == id);
            return iphone;
        }
        public bool InsertIphone(IPhone phone)
        {
            _db.Iphone.Add(phone);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool DeleteIphoneByID(int id)
        {
            var dealer = _db.Dealers.Find(id);
            _db.Dealers.Remove(dealer);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool DeleteIphone(IPhone iphone)
        {
            _db.Iphone.Remove(iphone);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public IPhone GetIPhoneWithPriceAndDealers(int id)
        {
            var iphone = _db.Iphone.Include(i => i.DealerIphones)
                .ThenInclude(i => i.Dealer)
                .FirstOrDefault(i => i.IphoneID == id);

            return iphone;
        }

        public List<IPhone> GetAllIPhonesWithPriceAndDealers()
        {
            var iphones = _db.Iphone
                .Include(i => i.DealerIphones)
                .ThenInclude(di => di.Dealer)
                .ToList();

            return iphones;
        }

        public List<Comment> GetCommentsByIphoneID(int id)
        {
            //var iphone = _db.Iphone.Where(i => i.IphoneID == id).ToList();
            //var comments = iphone.First().Comments.ToList();
            var comments = _db.Comments.Include(u=>u.User).Where(c => c.iPhoneID == id).ToList();            
            return comments ?? new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            _db.Comments.Add(comment);
            _db.SaveChanges();
        }
    }
}
