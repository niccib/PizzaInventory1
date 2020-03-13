using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaInventory1.Data;
using PizzaInventory1.Models;
using PizzaInventory1.ViewModels;

namespace PizzaInventory1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ItemDbContext context;
        
        public CategoryController(ItemDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<ItemCategory> categories = context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Add() 
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
            return View(addCategoryViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new category to my existing categories
                ItemCategory newCategory = new ItemCategory
                {
                    Name = addCategoryViewModel.Name,
                };

                context.Categories.Add(newCategory);
                //context.SaveChanges();

                return Redirect("/Category");
            }

            return View(addCategoryViewModel);
        }
    }
}