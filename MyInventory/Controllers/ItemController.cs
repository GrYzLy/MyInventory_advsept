using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyInventory.Models;
using MyInventory.ViewModels;

namespace MyInventory.Controllers
{
    
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        [AllowAnonymous]
        public ViewResult List(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
                searchTerm = "";

            ItemsListViewModel itemsListViewModel = new ItemsListViewModel();
            itemsListViewModel.Items = _itemRepository.AllItems.Where(x => x.Name.Contains(searchTerm));


            itemsListViewModel.Title = "My Inventory";
            return View(itemsListViewModel);
        }

        
        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();
            return View(item);
        }
    }
}