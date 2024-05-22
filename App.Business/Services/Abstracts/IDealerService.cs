using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services.Abstracts
{
    public interface IDealerService
    {
        public List<Dealer> GetAllDealers();
        public Dealer GetDealerById(int id);
        public bool InsertDealer(Dealer dealer);
        public bool Update(Dealer dealer);

        public bool Delete(Dealer dealer);

        public bool DeleteDealerById(int id);
    }
}
