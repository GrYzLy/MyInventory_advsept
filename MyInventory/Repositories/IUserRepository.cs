using MyInventory_base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInventory_base.Repositories
{
    public interface IUserRepository
    {
        User GetByUsernameAndPassword(String username, string password);

    }
}
