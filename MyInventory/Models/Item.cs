using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInventory.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public bool InStock { get; set; }
        public Category Category {get; set;}
        public string Comment { get; set; }
    }
}
