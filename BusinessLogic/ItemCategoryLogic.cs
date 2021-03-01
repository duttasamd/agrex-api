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

        public void Add(ItemCategory itemCategory)
        {
            context.ItemCategories.Add(itemCategory);
            context.SaveChanges();
        }

        public List<ItemCategory> GetItemCategories()
        {
            List<ItemCategory> itemCategories = null;

            itemCategories = context.ItemCategories.ToList();
            return itemCategories;
        }
    }

}
