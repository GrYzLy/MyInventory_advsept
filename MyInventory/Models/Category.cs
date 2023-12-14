using System.Collections.Generic;

namespace MyInventory.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Item> Items { get; set; }
    }
}