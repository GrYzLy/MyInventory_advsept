using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInventory.Models
{
    public class MockItemRepository : IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Item> AllItems =>
            new List<Item>
            {
                new Item{Id = 1, Name = "Ship", InStock = true, Category = _categoryRepository.AllCategories.ToList()[0]},
                new Item{Id = 1, Name = "Hammer", InStock = false, Category = _categoryRepository.AllCategories.ToList()[1]},
                new Item{Id = 1, Name = "Pin", InStock = true, Category = _categoryRepository.AllCategories.ToList()[2]}
            };

        public Item GetItemById(int id)
        {
            return AllItems.FirstOrDefault(p => p.Id == id);
        }
    }
}
