using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInventory.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Large" },
                new Category{CategoryId = 2, CategoryName =  "Medium" },
                new Category{CategoryId = 3, CategoryName = "Small" },
            };
    }
}
