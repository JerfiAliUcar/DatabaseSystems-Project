using App.Business.Services.Abstracts;
using App.Data;
using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _db;

        public UserService(AppDbContext db)
        {
            _db = db;
        }

        public List<User> GetAllUsers()
        {
            var users = _db.Users.ToList();
            return users;
        }
        public User GetUserById(int id)
        {
            var user = _db.Users.FirstOrDefault(u => u.UserID == id);
            return user;
        }

        public List<User> GetAllUsersWithComments()
        {
            var users = _db.Users.Include(c => c.Comments).ToList();
            return users;
        }

        public bool Delete(User user)
        {
            _db.Users.Remove(user);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool DeleteUserById(int id)
        {
            var user = _db.Users.Find(id);
            _db.Users.Remove(user);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool InsertUser(User user)
        {
            _db.Users.Add(user);
            int affected = _db.SaveChanges();
            return affected > 0;
        }

        public bool Update(User user)
        {
            _db.Users.Update(user);
            int affected = _db.SaveChanges();
            return affected > 0;
        }
    }
}
