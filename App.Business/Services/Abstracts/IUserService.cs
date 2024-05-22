using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services.Abstracts
{
    public interface IUserService
    {
        public List<User> GetAllUsers();
        public User GetUserById(int id);
        public List<User> GetAllUsersWithComments();
        public bool InsertUser(User user);
        public bool Update(User user);

        public bool Delete(User user);

        public bool DeleteUserById(int id);

    }
}
