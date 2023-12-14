using MyInventory_base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInventory_base.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>()
        {
            new User { Id = 111, Name = "bartosz", Password = "zaq1", FavoritColor="blue", Role="Admin"}
        };


        public User GetByUsernameAndPassword(string username, string password)
        {
            var user = users.SingleOrDefault(u => u.Name == username && u.Password == password);

            return user;
        }
    }
}
