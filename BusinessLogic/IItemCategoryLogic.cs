using Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IItemCategoryLogic
    {
        List<ItemCategory> GetItemCategories();
        void Add(ItemCategory itemCategory);
    }
}