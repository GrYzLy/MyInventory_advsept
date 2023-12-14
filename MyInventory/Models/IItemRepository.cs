using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInventory.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> AllItems { get; }
        Item GetItemById(int id);

    }
}
