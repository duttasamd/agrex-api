using Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IItemTypeLogic
    {
        void Add(ItemType itemType);
        List<ItemType> Get();
    }
}