using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services.Abstracts
{
    public interface IiphoneService
    {
        public List<IPhone> GetAllPhones();
        public IPhone GetIphoneByID(int id);
        public bool InsertIphone(IPhone phone);
        public bool DeleteIphone(IPhone iphone);
        public bool DeleteIphoneByID(int id);
        public IPhone GetIPhoneWithPriceAndDealers(int id);
    }
}
