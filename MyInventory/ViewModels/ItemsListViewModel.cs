using Microsoft.AspNetCore.Mvc;
using MyInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyInventory.ViewModels
{
    public class ItemsListViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public string Title { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
    }
}
