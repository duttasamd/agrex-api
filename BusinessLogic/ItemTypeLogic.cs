using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class ItemTypeLogic : IItemTypeLogic
    {
        ApplicationDbContext context;


        public ItemTypeLogic(ApplicationDbContext context)
        {
            this.context = context;
        }
        public List<ItemType> List()
        {
            List<ItemType> itemTypes = null;

            itemTypes = context.ItemTypes.ToList();

            return itemTypes;
        }

        public List<ItemType> List(Guid itemCategoryId)
        {
            List<ItemType> itemTypes = null;

            itemTypes = context.ItemTypes.Where(x => x.ItemCategoryId == itemCategoryId).ToList();

            return itemTypes;
        }

        public void Add(ItemType itemType)
        {
            itemType.Id = Guid.NewGuid();
            context.ItemTypes.Add(itemType);
            context.SaveChanges();
        }
    }

}
