using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInventory_base.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { set; get; }

        public string FavoritColor { get; set; }

        public string Role { get; set; }

        public string GoogleId { get; set; }

    }
}
