using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaInventory1.Data;

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
            return View();
        }
    }
}