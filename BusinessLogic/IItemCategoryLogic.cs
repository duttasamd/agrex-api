﻿using Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IItemCategoryLogic
    {
        List<ItemCategory> List();
        void Add(ItemCategory itemCategory);
    }
}