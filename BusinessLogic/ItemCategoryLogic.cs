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
            itemCategory.Id = Guid.NewGuid();

            if (itemCategory.ItemTypes != null)
                itemCategory.ItemTypes.ToList()
                    .ForEach(itemType => itemType.Id = Guid.NewGuid());

            context.ItemCategories.Add(itemCategory);
            context.SaveChanges();
        }

        public List<ItemCategory> List()
        {
            List<ItemCategory> itemCategories = null;

            itemCategories = context.ItemCategories
                // .Include(x => x.ItemTypes)
                // .ThenInclude(x => x.ItemSubTypes)
                .ToList();

            return itemCategories;
        }
    }

}
