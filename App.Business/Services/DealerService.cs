using App.Business.Services.Abstracts;
using App.Data;
using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services
{
    public class DealerService : IDealerService
    {
        private readonly AppDbContext _db;

        public DealerService(AppDbContext db)
        {
            _db = db;
        }
        public List<Dealer> GetAllDealers()
        {
            var entityList = _db.Dealers.ToList();
            return entityList;
        }
        public Dealer GetDealerById(int id)
        {
            var dealer = _db.Dealers.FirstOrDefault(u => u.DealerID == id);
            return dealer;
        }
        public bool Delete(Dealer dealer)
        {
            _db.Dealers.Remove(dealer);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool DeleteDealerById(int id)
        {
            var dealer = _db.Dealers.Find(id);
            _db.Dealers.Remove(dealer);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool InsertDealer(Dealer dealer)
        {
            _db.Dealers.Add(dealer);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool Update(Dealer dealer)
        {
            _db.Dealers.Update(dealer);
            int affected = _db.SaveChanges();
            return affected > 0;
        }
    }
}
