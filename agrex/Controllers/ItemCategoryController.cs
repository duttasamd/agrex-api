using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agrex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemCategoryController : ControllerBase
    {
        IItemCategoryLogic itemCategoryLogic;
        public ItemCategoryController(IItemCategoryLogic _itemCategoryLogic)
        {
            itemCategoryLogic = _itemCategoryLogic;
        }

        [Route("test")]
        [HttpGet]
        public string TestAPI()
        {
            return "Hello";
        }

        [HttpGet]
        [Route("list")]
        public List<ItemCategory> GetItemCategories()
        {
            List<ItemCategory> itemCategories = null;

            itemCategories = itemCategoryLogic.GetItemCategories();

            return itemCategories;
        }
    }
}
