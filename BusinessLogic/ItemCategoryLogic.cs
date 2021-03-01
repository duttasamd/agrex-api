using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic
{
    public class ItemCategoryLogic : IItemCategoryLogic
    {
        ApplicationDbContext context;
        public ItemCategoryLogic(ApplicationDbContext _context)
        {
            context = _context;
        }
        public List<ItemCategory> GetItemCategories()
        {
            List<ItemCategory> itemCategories = null;

            itemCategories = context.ItemCategories.ToList();
            return itemCategories;
        }
    }

}
