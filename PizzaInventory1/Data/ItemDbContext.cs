using Microsoft.EntityFrameworkCore;
using PizzaInventory1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaInventory1.Data
{
    public class ItemDbContext
    {
        public DbSet<ItemCategory> Categories { get; set; }
    }
}
