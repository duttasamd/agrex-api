using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IItemTypeLogic
    {
        void Add(ItemType itemType);
        List<ItemType> List();
        public List<ItemType> List(Guid itemCategoryId);
    }
}